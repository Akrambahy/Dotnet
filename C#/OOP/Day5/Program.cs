using System;

namespace Day4
{

    class Program
    {

        class Math
        {
            // static members creating when class code loading on memory
            public static double Pi = 22.0 / 7D; // static member is sherd member for class and follow for class not object 
            public static void Sqrt(int Number) { }// static function is function to express a general function for all methods or object

        }
        /// <summary>
        ///  Operator overloading we use to create new way of using operators and add for it new feature
        /// operator overloading is function must be static
        /// </summary>
        class Complex
        {
            int real;
            int img;

            public Complex(int real, int img)
            {
                this.real = real;
                this.img = img;

            }

            public static Complex operator +(Complex C1, Complex C2)
            {
                Complex Result = new Complex(0, 0);
                Result.Real = C1.real + C2.real;
                Result.Real = C1.img + C2.img;
                return Result;
            }
            public static Complex operator +(Complex C1, int X)
            {
                Complex Result = new Complex(0, 0);
                Result.Real = C1.real + x;
                return Result;
            }

            public static bool operator ==(Complex C1, Complex C2)
            {
                return C1.real == C2.real && C1.img == C2.img;

            }
            public static bool operator !=(Complex C1, Complex C2)
            {
                return C1.real == C2.real && C1.img == C2.img;

            }
            // if we do == we must do !=

            public static explicit operator Complex(int n)
            {
                Complex Result = new Complex(0, 0);
                Result.Real = n;
                return Result;
            }
            public static explicit operator int(Complex C1)
            {

                return C1.real;
            }

        }

        static void Main(string[] args)
        {
            // we call statics using className.stMember;
            Math.Pi;
            Math.Sqrt(3);
            Complex C1 = new Complex(0, 0);
            Complex C2 = new Complex(0, 0);
            Complex C3 = C1 + C2; // C3=operator+(C1,C2)
            Complex C4 = C1 + 4; // C3=operator+(C1,4)
            bool E = C1 == C2; // E=operator==(C1,C2)
            Complex C5 = (Complex)7; //explicit operator Complex(7) C5= C5.real==7,img=0
            int I = (int)C1; //explicit operator Complex(C1) I=C1.real==0

        }


    }

}