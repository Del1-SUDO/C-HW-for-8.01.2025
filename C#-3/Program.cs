using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter all of your numbers in a row: ");
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int max=arr[0];
        int index=0;
        for (int i=1; i<arr.Length; i++) {
            if (arr[i] > max) {
                max = arr[i];
                index = i;
            }
        }

        Console.WriteLine(max + " " + index);
    }
}