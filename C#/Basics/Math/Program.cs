// Math built In Function 
// Ceiling to convert Number... + any fraction return Number +1
// flooring to convert Number... + any fraction return only Number 
// Round  minimize to  Number 
// Abs to return a positive  Number always
// BigMul(X,H) return X*H 
// Max(x,y) Return Grater 
// Mix(x,y) Return Less
//Sqrt(x) return square root of x
// Pow(x,y) return x power y
// PI return PI value => 3.14
// DivRem return (MaxDivisor,Remainder)
// sin(x), cos(x), tan(x) ,log(x) , ln(x) Math Return all this Value

int x = -3, y = 9;
double z = 3.56;
Console.WriteLine($"Ceiling  : {Math.Ceiling(z)}"); // print 4
Console.WriteLine($"Flooring : {Math.Floor(z)}"); // print 3
Console.WriteLine($"Rounding : {Math.Round(z, 1)}"); // print 3.6
Console.WriteLine($"Abs Value: {Math.Abs(x)}"); // print 3
Console.WriteLine($"Multi    : {Math.BigMul(x, y)}"); // print 18
Console.WriteLine($"Max Number : {Math.Max(x, y)}"); // print 9
Console.WriteLine($"Min Number : {Math.Min(x, y)}"); // print -3
Console.WriteLine($"Square Root : {Math.Sqrt(y)}"); // print 3
Console.WriteLine($"{x} Power {y} : {Math.Pow(x, y)}"); // print -19683

Random Rand = new Random();
int dice = Rand.Next(1, 6);
Console.WriteLine($"Dice Now : {dice}"); // Print Random Value From 1 To 6