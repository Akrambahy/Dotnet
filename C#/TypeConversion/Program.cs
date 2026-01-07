 // Type Conversion
    int intVar=5;
    double doubleVar=13.6;
     Console.WriteLine("Integer Number : "+intVar);
     Console.WriteLine("Double Number : "+doubleVar);
   //Implicit Conversion
     Console.WriteLine("After Conversion");
  //   doubleVar=intVar;
     Console.WriteLine("Integer Number : "+intVar);
     Console.WriteLine("Double Number : "+doubleVar);

   //Explicit Conversion  

  Console.WriteLine("After Conversion");
     intVar=(int)doubleVar; //without numericPart
     Console.WriteLine("Integer Number : "+intVar);
     Console.WriteLine("Double Number : "+doubleVar);
    // Conversion String
     string age="19";
     int intAge=int.Parse(age);