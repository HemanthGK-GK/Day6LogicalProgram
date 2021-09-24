using System;

namespace Fibbonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 1,num3,i;
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());
            Console.Write(num1 + " " + num2+" ");
            for(i=2;i<num;i++)
            {
                num3 = num1 + num2;
                Console.Write(num3 + " ");
                num1 = num2;
                num2 = num3;
                
            }

        }
    }
}
