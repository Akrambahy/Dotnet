using System;
/*
Classes Relations
1-Association 
Association Short Relation Are without any Creation For Other Ex Fun Class Call Ref From anther class and Use it
Anther class are temp for specific Time
2-Aggregation
Aggregation Long Relation Are without any Creation For Other Ex Crate Ref on Class And make it point to object From Anther Class And Use it on all Class tile it dead 
3- Composition
Composition Long Relation Are with any Creation For Other like Class A Consist Of Class B
4-Inheritance
Inheritance Is Relation Between Classes to simulate Is a in life like class1 Is a class2 ex human is a creature
Logic How Simulate Is a
syntax How reduce code 
*/
namespace Day3
{
    class Program
    {
        //Association
        class Pain { }
        class Board
        {
            public void WriteOnBoard(Pain RedPain)
            {

            }
        }

        //Aggregation

        class Instructor { }

        class Session
        {
            public Instructor? inst; //create Ref Type Of Instructor

            public Session()
            {
                inst = null;
            }

            public void InstructorAttend(Instructor i)
            {
                inst = i;
            }
            public void InstructorExplain()
            { }


        }

        //Composition
        class Head { }

        class Body
        {
            public Head head;
            public Body()
            {
                head = new Head();
            }

            public void Fun1() { }//Use Head
            public void Fun2() { }//Use Head
            public void Fun3() { }//Use Head
        }

        // Inheritance

        class Creature
        {
            public string name = "";
            public int age = 0;

            public void move() { }
            public Creature(string Name, int Age) { }
        }
        class Human : Creature
        {
            public string job = "";
            public void learn() { }
            public Human(string Name, string Job, int Age) : base(Name, Age)
            {

            }

        }

        static void Main(string[] args)
        {


        }
    }
}
