//export class Addition {

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

export class Addition {

    constructor(private x?: number, private y?: number) {
    }

    Sum() {
        console.log('Sum: ' + (this.x + this.y));
    }
}