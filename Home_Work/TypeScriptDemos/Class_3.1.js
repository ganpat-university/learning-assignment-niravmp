var Car = /** @class */ (function () {
    function Car(speed) {
        // set the default speed to 0.
        this.speed = speed || 0;
    }
    Car.numberOfWheels = function () {
        return 4;
    };
    Car.prototype.accelerate = function () {
        this.speed++;
    };
    Car.prototype.throttle = function () {
        this.speed--;
    };
    Car.prototype.getSpeed = function () {
        console.log('Speed: ' + this.speed);
    };
    return Car;
}());
var car = new Car(5);
car.accelerate();
car.getSpeed();
console.log(Car.numberOfWheels());
