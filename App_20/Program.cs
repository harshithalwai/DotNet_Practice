using System;

namespace App_20
{
    internal class Program
    {
        public bool IsPrime(int num)
        {
            if (num < 2) return false;
            if (num % 2 == 0) return num == 2;
            if (num % 3 == 0) return num == 3;
            for (int i = 5; i * i <= num; i += 6)
            {
                if (num % i == 0 || num % (i + 2) == 0)
                    return false;
            }

            return true;
        }
        public bool IsArmstrong(int num)
        {
            int sum = 0;
            int temp = num;
            int digits = num.ToString().Length;
            while (temp > 0)
            {
                int digit = temp % 10;
                sum += (int)Math.Pow(digit, digits);
                temp /= 10;
            }
            return sum == num;
        }
        static void Main(string[] args)
        {
            //Program program = new Program();
            //Console.Write("Enter a number to check if it's prime:");
            //int number = Convert.ToInt32(Console.ReadLine());
            //bool result = program.IsPrime(number);
            //if (result)
            //{
            //    Console.WriteLine($"{number} is a prime number.");
            //}
            //else
            //{
            //    Console.WriteLine($"{number} is not a prime number.");
            //}
            int a = 0;
            a++;
            Console.WriteLine(a++);
            Console.WriteLine(++a);
            a++;
            ++a;
            Console.WriteLine(a++);
            ++a;



        }
    }
}
