class Car {

    engineName: string;
    gears: number;
    private speed: number;

    constructor(speed: number) {
        // set the default speed to 0.
        this.speed = speed || 0;       
    }

    static numberOfWheels(): number {
        return 4;
    }

    accelerate(): void {
        this.speed++;
    }

    throttle(): void {
        this.speed--;
    }

    getSpeed(): void {
        console.log('Speed: ' + this.speed);
    }

}


let car = new Car(5);
car.accelerate();
car.getSpeed();

console.log(Car.numberOfWheels());



