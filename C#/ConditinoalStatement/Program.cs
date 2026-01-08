//IF Statement

int x=3,y=7;

if(x>y) Console.WriteLine("X  Greater Than Y");
else if(x<y) Console.WriteLine("X  Less Than Y");
else Console.WriteLine("X  Equal  Y");

// Nested IF

if(x>y) Console.WriteLine("X  Greater Than Y");
else {
    if(x<y)Console.WriteLine("X  Less Than Y");
    else Console.WriteLine("X  Equal  Y");
  };
