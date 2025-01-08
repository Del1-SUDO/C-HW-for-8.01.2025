using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter your deposit emount: ");
        int deposit = Convert.ToInt32(Console.ReadLine());
        int percente;

        if (deposit <100){
            percente = 5;
        }
        else if (deposit >=100 && deposit<=200){
            percente = 7;
        }
        else {
            percente = 10;
        }

        int total = (percente*deposit)/100+deposit;
        Console.WriteLine("Your total deposit is: " + total);
    }
}