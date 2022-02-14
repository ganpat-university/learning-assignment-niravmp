using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Person
    {
        private string _name;

        public string Name
        {
            
            get
            {
                return _name;
            }
            
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Please Enter Your Name");
                }
                else
                {
                    _name = value;
                }
            }
        }

        
        private int _age;


        public int Age
        {
            
            get
            {
                return _age;
            }
            
            set
            {
                if (value >= 18 && value <= 65)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Age has to be 18 and 65");
                }
            }
        }

    }
}
