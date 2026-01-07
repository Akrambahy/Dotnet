//Data Types In C#
//Integers
sbyte sbNumber; // -128 to 127
byte bNumber; // 0 to 255
int intNumber; // -2,147,483,648 to 2,147,483,647
short sNumber; // -32,768 to 32,767
ushort usNumber; //	0 to 65,535


Console.WriteLine("Number : " + Number);


/*
sbyte 	-128 to 127 	Signed 8-bit integer 	System.SByte
byte 	0 to 255 	Unsigned 8-bit integer 	System.Byte
short 	-32,768 to 32,767 	Signed 16-bit integer 	System.Int16
ushort 	0 to 65,535 	Unsigned 16-bit integer 	System.UInt16
int 	-2,147,483,648 to 2,147,483,647 	Signed 32-bit integer 	System.Int32
uint 	0 to 4,294,967,295 	Unsigned 32-bit integer 	System.UInt32
long 	-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 	Signed 64-bit integer 	System.Int64
ulong 	0 to 18,446,744,073,709,551,615 	Unsigned 64-bit integer 	System.UInt64
nint 	Depends on platform (computed at runtime) 	Signed 32-bit or 64-bit integer 	System.IntPtr
nuint 	Depends on platform (computed at runtime) 	Unsigned 32-bit or 64-bit integer 	System.UIntPtr
*/
//Strings 
string firstName = "Akram";
Console.WriteLine("Hello, " + firstName);
//floating Numeric 
float fNumber = 2.2F; // We must put type after Number
decimal deNumber = 86.2M;
double duNumber = 2.2D; // default is D as a Double

Console.WriteLine("Float Number : " + fNumber);
Console.WriteLine("Decimal Number : " + deNumber);
Console.WriteLine("Double Number : " + duNumber);
//boolean  
bool IsWork = false;
Console.WriteLine(IsWork);

// Var 
var Variable = 5;// assign integer Value auto 
