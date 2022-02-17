// Strongly typed variables

let myString: string;
myString = 'This is a string value';

let myString2: string = 'This is another string value';

// Generates a compiler error because the variable cannot be assigned a 'number'
// myString = 4;



// Typescript can also infer the types

let anotherString = 'This is a string value';		// does not need the ":string" (by inferrence on assignment)


// Typescript can ONLY INFER on assignment during the declaration process.

let yetAnotherString;
yetAnotherString = 'This is a string value';
yetAnotherString = 5;				// NO ERROR: 



// other basic type

let vString: string;
let vNumber: number;
let vBoolean: boolean;
let vArray: Array<string>;			// generic type
let vObject: any;				// inferred as an object

