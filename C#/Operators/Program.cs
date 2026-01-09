//Arithmetic Operator
int result=0;
int num1=9,num2=7;

result = num1+num2;
Console.WriteLine($"Add : {result}"); // Print 16


result = num1-num2;
Console.WriteLine($"Sub : {result}"); // Print 2


result = num1*num2;
Console.WriteLine($"Mul : {result}"); // Print 63


result = num1/num2;
Console.WriteLine($"Div : {result}"); // Print 1


result = num1%num2;
Console.WriteLine($"Reminder : {result}");// Print  2 

//Postfix Increment Operator
Console.WriteLine(num1++); // Print 9
num1--;
//Postfix decrement Operator
Console.WriteLine(num1--); //Print 9'
num1++;
//Prefix Increment Operator
Console.WriteLine(++num1); //Print 10
num1--;
//Prefix decrement Operator
Console.WriteLine(--num1); //Print 8


//Comparison Operator 

/*
== Equal to
> greater than
< less than 
>= greater than or equal
<= less than or equal
!= not equal
*/

int number1=6,number2=6;
bool res;

res=number1==number2;
Console.WriteLine($"{number1} Equal {number2} Is : {res}"); // Print true

res=number1>number2;
Console.WriteLine($"{number1} Greater {number2} Is : {res}"); // print false

res=number1<number2;
Console.WriteLine($"{number1} Less {number2} Is : {res}"); // print false

res=number1>=number2;
Console.WriteLine($"{number1} Greater Or Equal {number2} Is : {res}"); // print true

res=number1<=number2;
Console.WriteLine($"{number1} Less Equal {number2} Is : {res}"); // print true

res=number1!=number2;
Console.WriteLine($"{number1} NOt Equal {number2} Is : {res}"); // print false


// Logical Operator
/*
&& And Operator All Conditions Must Be True
|| Or Operator at least one Condition is true
! exclamation Operator reverse Condition
*/
bool username=true;
bool email=false;
bool password=true;

if(username&&password)Console.WriteLine("Login Accepted. "); //username =true and password =true
else if((username||email)&&email)Console.WriteLine("Login Accepted. , but username is wrong"); //username =false and email=true password =true
else if(username||password)Console.WriteLine("Just One is True , try again "); //username =true or password =true but not both
else Console.WriteLine("you Are Band , Nothing True "); // all is false


// Ternary Operator 
   //(condition) ? if true do: if false do;
int x=5,y=6;
var maxResult=(x>y) ? x:y;  // max Result equal to y
bool successful=true;
(successful==true) ?Console.WriteLine("pass"): Console.WriteLine("failed"); //print pass
//"??"Null coalescing Operator
//DT name= var ?? if Null do;
int n=12;
var newVar=n ?? 0;//if n not null assign n value for new Var if Null assign 0