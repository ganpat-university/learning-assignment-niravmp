// To run:
// (a) > tsc --module commonjs 06-additionModule.ts 
// (b) > tsc 06-app.ts
// (c) > node 06-app.ts

import {Addition} from './06-additionModule'

let addObject = new Addition(10, 20);
addObject.Sum();
