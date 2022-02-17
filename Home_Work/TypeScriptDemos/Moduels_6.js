"use strict";
//export class Addition {
exports.__esModule = true;
exports.Addition = void 0;
//    x: number;
//    y: number;
//    constructor(x: number, y: number) {
//        this.x = x;
//        this.y = y;
//    }
//    Sum() {
//        console.log('Sum: ' + (this.x + this.y));
//    }
//}
var Addition = /** @class */ (function () {
    function Addition(x, y) {
        this.x = x;
        this.y = y;
    }
    Addition.prototype.Sum = function () {
        console.log('Sum: ' + (this.x + this.y));
    };
    return Addition;
}());
exports.Addition = Addition;
