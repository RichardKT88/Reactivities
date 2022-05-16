let data = 42;
data = '42';

let data2 : any = 42;
data2 = '42';

let data3: number | string = 42;
data3 = 42;

export interface Duck {
    name: string;
    numLegs: number;
    makeSound?: (sound: string) => void;
}

//DuckTyping
const duck1: Duck = {
    name: 'huguinho',
    numLegs: 2,
    makeSound : (sound: any) => console.log(sound)
}

const duck2 : Duck = {
    name: 'zezinho',
    numLegs: 2,
    //makeQuack : (sound: any) => console.log(sound)
    //makeSound : (sound: any) => console.log(sound)
}

duck1.makeSound!('quack');

export const ducks = [duck1, duck2]