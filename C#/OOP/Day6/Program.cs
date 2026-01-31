using System;

namespace Day6
{
    
/// <summary>
/// class Object is parent class for all Data Types and DT inherit from object class
/// object class methods
/// Equals compare ref between tow objects
/// ToString return namespace.classname of object
/// GetHashCode return hashcode of object
/// GetType return deep info of object
/// memberwiseclone return object 
/// </summary>
class Program
    {
        class Human
        {
          public  int Id;
          public  string name;
            
         public  static void Fun(object obj) // obj can be any DT a 135 false Objectclass 
            {
                
            }
          public  static void Fun(int n) // obj can be any DT a 135 false Objectclass 
            {
                
            }

        }



      static void Main(string [] args)
        {
            object  Obj=new Human();
            Human  h=new Human();
            h.Fun(h); // 
            h.Fun(56); // 
            h.Fun("llk"); // 
            h.Fun(false ); // this call dynamic padding
            h.Fun2(2 ); // this call static padding
          //h.objectmethods h have object method because it inherit from object

          Human H=new Human();
          H.Equals(h);
          H.GetHashCode();
          H.GetType ();
          H.ToString (); // return Day6.Human
        }

    }

}