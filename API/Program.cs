using Application.Activities;

var builder = WebApplication.CreateBuilder(args);

// add services to container

builder.Services.AddControllers(opt =>
{
    var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
    opt.Filters.Add(new AuthorizeFilter(policy));
})
    .AddFluentValidation(config =>
{
    config.RegisterValidatorsFromAssemblyContaining<Create>();
});
builder.Services.AddApplicationServices(builder.Configuration);
builder.Services.AddIdentityServices(builder.Configuration);

// Configure the http request pipeline

var app = builder.Build();

app.UseMiddleware<ExceptionMiddleware>();

app.UseXContentTypeOptions();
app.UseReferrerPolicy(opt => opt.NoReferrer());
app.UseXXssProtection(opt => opt.EnabledWithBlockMode());
app.UseXfo(opt => opt.Deny());
app.UseCsp(opt => opt
               .BlockAllMixedContent()
               .StyleSources(s => s.Self().CustomSources(
                   "https://fonts.googleapis.com",
                   "sha256-yChqzBduCCi4o4xdbXRXh4U/t1rP4UUUMJt+rB+ylUI=",
                   "sha256-wkAU1AW/h8YFx0XlzvpTllAKnFEO2tw8aKErs5a26LY="
                   ))
               .FontSources(s => s.Self().CustomSources("https://fonts.gstatic.com", "data:"))
               .FormActions(s => s.Self())
               .FrameAncestors(s => s.Self())
               .ImageSources(s => s.Self().CustomSources(
                   "https://res.cloudinary.com",
                   "https://www.facebook.com",
                   "https://scontent-iad3-2.xx.fbcdn.net",
                   "https://scontent.fcgh7-1.fna.fbcdn.net",
                   "https://platform-lookaside.fbsbx.com",
                   "data:",
                   "blob:"
                   ))
               .ScriptSources(s => s.Self().CustomSources(
                   "https://connect.facebook.net",
                   "sha256-BODXSOip7GpBT4WVS+qjnNRRxTid6JIXiEE5cVAE2Ag=",
                   "sha256-8/x0JSs5MRRLxTgyjVUt/0HkVgclaNajrfry5WL6+Kg=",
                   "sha256-Tui7QoFlnLXkJCSl1/JvEZdIXTmBttnWNxzJpXomQjg=",
                   "sha256-CzYN5MMT8wA9fbIe+4hC2BQ8qaszoPPdWMDLwuEJDcM=",
                   "sha256-PfI8hHm49boscgavNiOm75C7sPZ+nfvTLsSaEaDMYHM="
                   ))
           );

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1"));
}
else
{
    app.Use(async (context, next) =>
    {
        context.Response.Headers.Add("Strict-Transport-Security", "max-age=31536000");
        await next.Invoke();
    });
}

// app.UseHttpsRedirection();

app.UseDefaultFiles();
app.UseStaticFiles();

app.UseCors("CorsPolicy");

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapHub<ChatHub>("/chat");
app.MapFallbackToController("Index", "Fallback");

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

using var scope = app.Services.CreateScope();

var services = scope.ServiceProvider;

try
{
    var context = services.GetRequiredService<DataContext>();
    var userManager = services.GetRequiredService<UserManager<AppUser>>();
    await context.Database.MigrateAsync();
    await Seed.SeedData(context, userManager);
}
catch (Exception ex)
{
    var logger = services.GetRequiredService<ILogger<Program>>();
    logger.LogError(ex, "An error occured during migraiton");
}

await app.RunAsync();
