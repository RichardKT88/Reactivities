<h1 align="center"> Complete guide to building an app with .Net Core and React - Udemy 🔥 </h1> 
<h3 align="center"> The complete guide to building an app from start to finish using ASP.NET Core <br /> , React (with Typescript) and Mobx - by Neil Cummings </h3>


## Table Of Contents
- [Reactivities](#reactivities)
  - [Table Of Contents](#table-of-contents)
  - [Install Packages](#install-packages)
  - [Project Setup and Execution](#project-setup-and-execution)
  - [Screenshots](#screenshots)
  - [What I've learned](#what-ive-learned-)
  - [Tech Stack](#tech-stack-%EF%B8%8F)

# Reactivities
A social platform application that is being continually added to in conjunction with the Udemy course listed below. My end goal is to learn how to create a full application that incorporates data management and API's using dotnet and displays a UI built with React.js from start to finish. 

## Install Packages

Run the command within the project directory to install packages from the project dependencies

```
$ cd ../Reactivities
$ npm install
```

## Project Setup and Execution

### Start the back-end implementation

```
$ cd ../Reactivities/API
$ dotnet run
```

### Start the front-end implementation

In the 'client-app' project directory, you can run the React app:

```
$ cd Reactivities\client-app
$ npm start
```

Runs the app in the development mode.\
Open [http://localhost:3000](http://localhost:3000) to view it in the browser.

## Screenshots

### Landing Page
Not authenticated users will see a login and sign up buttons, authenticated will only see a "Go to Activities" button.
<p><img src="https://github.com/RichardKT88/Reactivities/blob/main/assets/landing.png?raw=true" width="300" /></p>

### Signup/Login
<p><img src="https://github.com/RichardKT88/Reactivities/blob/main/assets/signup.png?raw=true" width="300" /></p>

<p><img src="https://github.com/RichardKT88/Reactivities/blob/main/assets/login.png?raw=true" width="300" /></p>

### Activities Feed
Authenticated users can click an activity to view its details, filter by activities they are going to or activities they host.
they also can view activities from a certain date.
<p><img src="https://github.com/RichardKT88/Reactivities/blob/main/assets/activities.png?raw=true" width="300" /></p>

### Activity Details
Authenticated user can view the activity information including RSVPs, host, location and date.
When the user is host, he also can click on edit to change the activity info.
<p><img src="https://github.com/RichardKT88/Reactivities/blob/main/assets/activity.png?raw=true" width="300" /></p>

### Activity Form
Authenticated user can access this form when clicking on the navigation bar button "Add activity" to create a new activity,
or when trying to edit an activity, in this case the activity information will be filled automatically.
when wrong input is typed, there will be a flashing message to warn the user about it. 
<p><img src="https://github.com/RichardKT88/Reactivities/blob/main/assets/activity-form.png?raw=true" width="300" /></p>

### Profile
A user can manage his profile or view other users profile, on his own profile he is able to edit his bio, upload photos, choose a profile photo, view his hosted activities and activities he's going to, and also view his followers or following.
<p><img src="https://github.com/RichardKT88/Reactivities/blob/main/assets/profile.png?raw=true" width="300" /></p>

### Upload Image,
While adding a photo to the current authenticated user, he can drag and drop or choose an image, crop it and get a real time preview of the result. 
<p><img src="https://github.com/RichardKT88/Reactivities/blob/main/assets/photo-upload.png?raw=true" width="300" /></p>

## What I've learned 📚

✔️ Creating a multi-project solution using the the ASP.NET Core WebAPI and the React app using the DotNet CLI and the create-react-app utility\
✔️ Clean Architecture and the CQRS + Mediator pattern \
✔️ Setting up and configuring ASP.NET Core identity for authentication \
✔️ Using React with Typescript \
✔️ Adding a Client side login and register function to our React application \
✔️ Using React Router \
✔️ Using AutoMapper in ASP.NET Core \
✔️ Building a great looking UI using Semantic UI \
✔️ Adding Photo Upload widget and creating user profile pages \
✔️ Using React Final Form to create re-usable form inputs with validation \
✔️ Paging, Sorting and Filtering \
✔️ Using SignalR to enable real time web communication to a chat feature in our app \
✔️ Publishing the application to both IIS and Linux \
✔️ Getting an ‘A’ rating for security from a well known security scanning site. \
✔️ Many more things as well \


To view the course on Udemy, **[click here](https://www.udemy.com/course/complete-guide-to-building-an-app-with-net-core-and-react/#instructor-1)**


## Tech Stack 🛠️

| Tech | Usage
------------ | -------------
[C#](https://docs.microsoft.com/en-us/dotnet/csharp/) | .NET Language Used
[.NET](https://dotnet.microsoft.com/) | Web Framework Used
[Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/) | Serves as an object-relational mapper (O/RM)
[Postman](https://www.postman.com/use-cases/api-testing-automation/) | Used for API testing
[Axios](https://github.com/axios/axios) | Library for handling HTTP requests with React
[Semantic UI React](https://react.semantic-ui.com/) | React styling framework
[Visual Studio Code](https://code.visualstudio.com/) | IDE Used
