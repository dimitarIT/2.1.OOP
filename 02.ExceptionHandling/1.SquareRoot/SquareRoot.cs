using System;

namespace _1.SquareRoot
{
    internal class SquareRoot
    {
        private static void Main()
        {
            try
            {
                Console.Write("Please enter an integer number: ");
                uint number = uint.Parse(Console.ReadLine());
                double sqrt = Math.Sqrt(number);
                Console.WriteLine(sqrt);
            }
            catch
                (FormatException)
            {
                Console.Error.WriteLine("Invalid number");
            }
            catch (OverflowException)
            {
                Console.Error.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good Bye");
            }
        }
    }
}