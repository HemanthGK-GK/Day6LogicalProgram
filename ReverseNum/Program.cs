using System;

namespace ReverseNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int remainder = 0;
            int reverse = 0;
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());
            while (num != 0)
            { 
            
            remainder = num % 10;
            reverse = reverse * 10 + remainder;
            num = num / 10;
            }
            Console.WriteLine("Reverse Number is :"+reverse);


        }
    }
}
