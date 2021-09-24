using System;

namespace PerfectNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0,i=1;
            Console.WriteLine("Enter The Number to check It is a Perfect num of not");
            num = int.Parse(Console.ReadLine());

            while(i<=num/2)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                }
                i++;
            }
            if(sum==num)
            {
                Console.WriteLine(num + " Is a Perfect Number");
            }
            else
                Console.WriteLine(num + " Is Not a Perfect Number");
        }
    }
}
