using System;
// Polymorphism

namespace Day4
{

    class Program
    {

        abstract class Creature
        {
            public string Job;
            public int age, hight, width;

            public virtual void Move()
            {
                Console.WriteLine("Creature Is Moving ....");
            }
            public abstract void Eat()
            {
                Console.WriteLine("Creature Is Eating ....");
            }
        }
        class Human : Creature
        {
            public override void Move()
            {
                Console.WriteLine("Human Is Moving ....");
            }
            public override void Eat()
            {
                Console.WriteLine("Human Is Eating ....");
            }
        }


        static void Main(string[] args)
        {
            Creature c = new Human(); // compiler see c is ref from creature and have members of creature 
            c.Move();// Move form Creature Class Print Creature Is Moving ....
                     // after polymorphism(add virtual on base class and override on sub class)
            c.Move; // Move form Human Class Print Human Is Moving ....
        }
        // abstract class we use when class are general concept we cant do real object from it and cant do object for it
        // we cant do "new Creature()" because Creature is abstract class
        //Creature c = new Creature(); //Error
        // abstract function is fun we cant do implementation tile in current class we do it to override
        //like Eat in creature Eat Is virtual-abstract   

    }
}