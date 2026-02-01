using System;

namespace Day7
{
    
// Enumeration On C# What And Why
/// <summary>
/// We call Enumeration with Key enum
/// enum is set of const possible values with integers 
/// why use any cases like gender have const possible values Female or male
/// and take integers modifiers like 1 for female 2 for male
/// to make process is easy in integers with 1 and 2 And using bitwise operators like & and | or
/// to make some operation with low time and high performance 
/// if not put number well stated with zero and increment 1
/// </summary>



enum Gender
    {
        Female=1,
        Male =2
    }

class Program
    {
        

// Struct On C# What And Why
/// <summary>
/// Struct is blueprint like class but  Store Value Type
/// we have't inheritance or polymorphism on struct 
/// We Use struct to store like int or complex or fraction 
/// we call struct :
/// structname variblename = new constructorname() ;
///   struct created on stack we using "new constructorname()" to init vars on struct
/// we can not use put init struct vars by hand
/// we must  init struct vars
/// we can using access modifiers public private is defaultprint 0 if var value if ref print nul
/// parameter less constructor not removed always 
/// if we send value on object place compiler boxing it take and create object on heap and put value on it and take ref pass on parameter object this call boxing 
/// </summary>

struct Complex
        {
           public int real;
            int img;

            public void Fun(object obj){}

        }



     static void Main(String [] args)
        {
            Gender gender=Male;
            Console.WriteLine(gender);// print Male
            if(gender==Gender.Male)  Console.WriteLine("is Male.");
            else Console.WriteLine("is Female.");

            Complex c=new Complex();
Console.WriteLine(c.real); // print 0 if var value if ref print null
Console.WriteLine(c.ToString); // struct have object method like class 
Fun(5);// boxing 

        }   
    }

}