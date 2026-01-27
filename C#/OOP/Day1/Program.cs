using System;

namespace Day1
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

        static void Main(string[] args)
        {
            Car Car1 = new Car();
            Car1.SetModel("X6");
            Car1.PrintCarInfo();
        }
    }
}
