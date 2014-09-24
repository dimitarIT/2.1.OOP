using System;

namespace _2.EnterNumbers
{
    internal class CheckNumbersInRange
    {
        private static void Main()
        {
            int startNum = 1;
            int endNum = 100;
            int[] nums = new int[10];
            for (int i = 0; i < 10; i++)
            {
                startNum = ReadNumber(startNum, endNum);
                nums[i] = ReadNumber(startNum, endNum);
            }
            Console.WriteLine("Your numbers is: ");
            foreach (var num in nums)
            {
                Console.Write(num + " ");
            }
        }

        public static int ReadNumber(int startNum, int endNum)
        {
            int currentNum = startNum;
            while (currentNum == startNum)
            {
                try
                {
                    Console.Write("Enter a number between {0} and {1}: ", startNum, endNum);
                    currentNum = int.Parse(Console.ReadLine());
                    while (currentNum <= startNum || currentNum >= endNum)
                    {
                        Console.WriteLine("Invalid input! Your number must be between {0} and {1}!", startNum, endNum);
                        Console.WriteLine("Enter a number between {0} and {1}: ", startNum, endNum);
                        currentNum = int.Parse(Console.ReadLine());
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Number!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Invalid number! The number is too big to fit in int32!");
                }
            }

            return currentNum;
        }
    }
}