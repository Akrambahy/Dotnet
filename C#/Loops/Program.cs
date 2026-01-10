// For  Loop
/*
for(initialization;Condition;iterator){
body of for loop
}
*/
// Example 

for (int i = 0; i <= 10; i++)// take i and do body and increment i after check condition while condition is true do body
{
    Console.WriteLine(i);  // Print from 0 to 10    
}
for (int i = 10; i >= 0; i--)// take i and do body and decrement i after check condition while condition is true do body
{
    Console.WriteLine(i);  // Print from 10 to 0    
}


// While And Do While
// while(condition) {body of while}
//do{body of do while} while(condition)
int a = 10;
while (a >= 0)
{
    Console.WriteLine(a * 7); // Print MultiTable of 7 with decrement 
    a--;
}
int b = 0;
do
{
    Console.WriteLine(6 * b);  // Print MultiTable of 7 with  increment 
    b++;
} while (b <= 10);

//Nested Loop 
// Nested Loop Is Loop In Loop
// Example 

for (int i = 1; i <= 10; i++)
{
      Console.WriteLine($"Table {i}");
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");  // Print MultiTable for 1 to 10
    }
}