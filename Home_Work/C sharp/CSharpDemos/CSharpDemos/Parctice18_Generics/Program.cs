using System;

namespace Demo18_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Demo of an integer packaged in the generic object
            int i = 10;
            MyGenericType<int> intVariable = new MyGenericType<int>();
            intVariable.Value = 10;
            intVariable.DisplayInfo();


            MyGenericType<string> stringVariable = new MyGenericType<string>();
            stringVariable.Value = "hello world";
            stringVariable.DisplayInfo();


            MyGenericType<Employee> employeeVariable = new MyGenericType<Employee>();
            employeeVariable.Value = new Employee()
            {
                EmployeeID = 10,
                EmployeeName = "First Employee"
            };
            employeeVariable.DisplayInfo();
        }
    }
}
