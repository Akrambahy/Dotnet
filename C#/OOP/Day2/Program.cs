using System;
/*
Program divided To'
Code Data
App in Memory Divide To Section For Code And Section For Data

App Loading Process Ram

Data Divided To
Stack Heap
Any Local Variable(Variable On Function) Stored In Stack

Sack Stored Block Of Function Mainly Main Fun And Into Add Fun
Heap Dynamic Allocation Data Stored In RunTime And Removed

Data Types Divide To
Built In Defined By PL Like int,float,boll
User Defined DT Defined By User "Like Any Thing Fro Class

Data Type Root
Value Type Like Struct And Enum Always Have Value
Reference Type Like Class Store Address like Class RefName=new ClassName(); RefName Is Reference Type of Class  
ex 
Car Car1       =     new Car();
Create object type Car depend on constructor Car
"Car Car1 " Create Reference Type Of Class Car Store Address Of Class Car Have Name Car1
"new Car()" Create Object In Memory Of Class Car
"Car()" Constructor Det how object well build 
"=" Store Address Of Object Created In Reference Created
Order Of Execution
1 Create Object
2 Call constructor

nots : 
Ref->Stack
Object->Heap
No Ref point To Object Obj Are Dead
new-> object;
not operations no initialization
we must init any local var before any operation 
build in take value
user define maybe null
var members initiated already  (int->0,bool->false)

we call in fun with object with hidden parameter this is reference of object\\
*/
namespace Day2
{
    class Program
    {
        class Car
        {
            public string brand = "BMW";
            private string _model = "";
            private int _speed = 52;

            public void SetModel(string model)
            {
                _model = model;
            }

            public string GetModel()
            {
                return _model;
            }

            public void PrintCarInfo()
            {
                Console.WriteLine($"Car Is {brand}:{_model}");
                Console.WriteLine($"Speed Is {_speed}M/H");
            }
        }

        class Employee
        {
            private string _name;
            public string title;
            public int salary;

            Employee() // constructor
            {
                salary = 3000;
            }

            public void display(/*hidden parameter this = ref of object*/)
            {
                Console.WriteLine($"{_name}:{title}:{_salary}");
            }
        }

        static void Main(string[] args)
        {
            Car Car1; // Create Ref Of Class Car;
            new Car(); //  Create Object Car In Memory
            Car Car2 = new Car(); // store address of obj car created in Car2
            Employee Employee1 = new Employee(); //Create refrence Employee and store  Create object Type  Employee  depend on constructor Employee


        }
    }
}
