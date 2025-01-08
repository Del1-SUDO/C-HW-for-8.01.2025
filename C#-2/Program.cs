using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter all of your numbers in a row: ");
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int sum = 1;
        foreach(int num in arr){
            sum *= num;
        }

        Console.WriteLine(string.Join("*", arr) + "=" + sum);
    }
}