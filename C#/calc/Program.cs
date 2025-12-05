using calc;
using System.Text.RegularExpressions;

namespace calc
{
    public class Calculation(double n1, double n2)
    {

        public void add_subtract()
        {
            Console.WriteLine($"Addition: {n1} + {n2} = {n1 + n2}");
            Console.WriteLine($"Subtraction: {n1} - {n2} = {n1 - n2}");
        }
        public void add_multi()
        {
            Console.WriteLine($"Addition: {n1} + {n2} = {n1 + n2}");
            Console.WriteLine($"Multiplication: {n1} * {n2} = {n1 * n2}");
        }
        public void add_division()
        {
            Console.WriteLine($"Addition: {n1} + {n2} = {n1 + n2}");
            Console.WriteLine($"Division: {n1} : {n2} = {n1 / n2}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                 Console.Write("Please enter a number:");
                 try 
                 {
                    double n1 = double.Parse(Console.ReadLine());
                    try 
                    {
                        Console.Write("Please enter a second number:");
                        double n2 = double.Parse(Console.ReadLine());
                        Calculation calc = new Calculation(n1, n2);
                        Console.WriteLine("Select an operation:");
                        Console.WriteLine("1. Addition and Subtraction");
                        Console.WriteLine("2. Addition and Multiplication");
                        Console.WriteLine("3. Addition and Division");
                        ConsoleKeyInfo keyinfo = new ConsoleKeyInfo();
                        keyinfo = Console.ReadKey();
                        if (keyinfo.KeyChar == '1')
                        {
                            calc.add_subtract();
                        }
                        else if (keyinfo.KeyChar == '2')
                        {
                            calc.add_multi();
                        }
                        else if (keyinfo.KeyChar == '3')
                        {
                            calc.add_division();
                        }
                        else
                        {
                            Console.WriteLine("\nInvalid selection. Please choose 1, 2, or 3.");
                        }

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Input was not in a correct format. Please enter a valid number.");
                        continue;
                    }
                }
                 catch(FormatException)
                 {
                    Console.WriteLine("Input was not in a correct format. Please enter a valid number.");
                    continue;
                 }
               

            }
           

        }
    }
}
