var user;
// user = { anything: 'anything different' };       // COMPILER ERROR
user = { username: 'manoj', password: 'secretpassword' };
user = { username: 'sharma', password: 'secretpassword', confirmPassword: 'secretpassword' };
console.log('user information:');
console.log(user.username);
console.log(user.password);
console.log(user.confirmPassword);
console.log('\n');
var car = {
    accelerate: function (speed) {
        console.log('accelerating now to :' + speed);
    }
};
car.accelerate(500);
