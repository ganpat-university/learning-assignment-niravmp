class Employee {

    empCode: number;
    empName: string;

    constructor(code: number, name: string) {
        this.empCode = code;
        this.empName = name;
    }

    work = function():void {
        console.log(this.empName + ' is working today');
    }

    // arrow function
    display = () => console.log(this.empName + ' ' + this.empCode);
}

// An object of the Class
let emp = new Employee(1, 'First Employee');
emp.work();
emp.display();
