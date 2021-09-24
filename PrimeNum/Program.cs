using System;

namespace PrimeNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int flag = 0;
            Console.WriteLine("Enter A Number to Check Prime or Not");
            int num = int.Parse(Console.ReadLine());
            int m = num / 2;
            for (i = 2; i <= m; i++)
            {
                if (num % i == 0)
                {
                    flag = 1;
                    break;
                }
            }
                if(flag==0)
                    Console.WriteLine(num +" is Prime number");
                  else
                    Console.WriteLine(num + " is Not Prime number");
            
        }
    }
}
