var Employee = /** @class */ (function () {
    function Employee(code, name) {
        var _this = this;
        this.work = function () {
            console.log(this.empName + ' is working today');
        };
        // arrow function
        this.display = function () { return console.log(_this.empName + ' ' + _this.empCode); };
        this.empCode = code;
        this.empName = name;
    }
    return Employee;
}());
// An object of the Class
var emp = new Employee(1, 'First Employee');
emp.work();
emp.display();
