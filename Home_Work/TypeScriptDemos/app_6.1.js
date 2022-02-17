"use strict";
// To run:
// (a) > tsc --module 06-additionModule.ts 06-app.ts
// (b) > node 06-app.ts
exports.__esModule = true;
var _06_additionModule_1 = require("./06-additionModule");
var addObject = new _06_additionModule_1.Addition(10, 20);
addObject.Sum();
