// Задача 47
/*
double[,] CreateArray(int size1, int size2)
 {
     double[,] randomArray = new double[size1, size2];
     for (int i = 0; i < randomArray.GetLength(0); i++)
     {
        for (int j = 0; j < randomArray.GetLength(1); j++)
         {
             randomArray[i, j] = new Random().NextDouble();
         }
     }
     return randomArray;
 }
 void PrintArray(double[,] arr)
 {
     for (int i = 0; i < arr.GetLength(0); i++)
     {
         for (int j = 0; j < arr.GetLength(1); j++)
         {
             Console.Write(Math.Round(arr[i, j], 2) + " ");
         }
         Console.WriteLine();
     }
 }
 Console.Write($"Iput m number: ");
 int m = Convert.ToInt32(Console.ReadLine());
 Console.Write($"Iput n number: ");
 int n = Convert.ToInt32(Console.ReadLine());
 PrintArray(CreateArray(m, n));
 */

 // Задача 52
/*
 int[,] CreateArr()
{
    int[,] arr = new int[new Random().Next(5, 11), new Random().Next(5, 11)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 101);
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    return arr;
}
double[] MAS(int[,] ar)
{
    double sum = 0;
    int size = ar.GetLength(0);
    double[] average = new double[ar.GetLength(1)];
    int x = 0;
    for (int i = 0; i < average.Length; i++)
    {
        for (int j = 0; j < ar.GetLength(0); j++)
        {
            sum += ar[j, x];
            for (int g = 0; g < ar.GetLength(1); g++)
            {
                average[i] = sum / size;
            }
        }
        x++;
        sum = 0;
    }
    return average;
}
void PrintMAS(double[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.Write(Math.Round(a[i], 2) + " ");
    }
    Console.WriteLine();
}
PrintMAS(MAS(CreateArr()));
*/

// Задача 50

Console.WriteLine("Input number1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[3,4];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        matrix[i,j] = new Random().Next(1,10);
        Console.Write(matrix[i,j]+ " ");
    }
    Console.WriteLine();
}
if (num1 < 0 || num1 > 3 && num2<0 || num2 > 4)
    Console.WriteLine("The number does not belong to the array");
else
    Console.WriteLine($"belongs to the array: {matrix[num1,num2]} ");
