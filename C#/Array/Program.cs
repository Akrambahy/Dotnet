//Array
// array init => DT[] ArrayName = new DT[sizeOfArray]
// array init with values => DT[] ArrayName = new DT[sizeOfArray]{values}
// Or DT[] arrayName={values}
// var arrayName= new DT{values}
//One Dimensional Array
int[] array1 = new int[3];
array1 = [5, 56, 8];

for (int i = 0; i < array1.Length; i++)
{
    Console.WriteLine(array1[i]);
}
//Tow dimensional array
int[,] array2D = new int[3, 3] { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } };

for (int i = 0; i < array2D.GetLength(0); i++)
{
    for (int k = 0; k < array2D.GetLength(1); k++)
    {
        Console.WriteLine(array2D[i, k]);
    }
}

//jagged array is array of arrays
// dec jagged array
// int [][] jaggedArray=new int[ number of arrays][];
//dec jaggedArray[number of array]=new int [number of values]{values};
int[][] jaggedArray = new int[3][];
jaggedArray[0] = new int[2] { 1, 2 };
jaggedArray[1] = new int[1] { 1 };
jaggedArray[2] = new int[3] { 1, 7, 8 };

Console.WriteLine(jaggedArray[0][1]); //print value of element 2 in array 2
                                      // Anther Definition
int[][] jaggedArray2 =
{
new int[]{1,2},
new int[]{1,2},
new int[]{1,2},
};

for (int i = 0; i < jaggedArray.Length; i++)
{
    for (int k = 0; k < jaggedArray[i].Length; k++)
    {
        Console.Write($"{jaggedArray[i][k]} ");
    }
    Console.WriteLine();
}

int[][,] TowDimArray = new int[2][,]
{
new int [,]{{1,2},{1,2}} ,
new int [,]{{1,5},{7,4}}
};

int[][,] TDimJagged2 =
{
 new int [,]{{1,2},{1,5}},
 new int [,]{{1,2},{1,5}},
 new int [,]{{1,2},{1,5}}

};


