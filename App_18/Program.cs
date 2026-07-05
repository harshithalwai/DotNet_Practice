//using System;

//class Program
//{
//    unsafe static void Swap(int* a, int* b)
//    {
//        int temp = *a;
//        *a = *b;
//        *b = temp;
//    }

//    unsafe static void Main()
//    {
//        int x = 5;
//        int y = 1;

//        Swap(&x, &y);

//        Console.WriteLine(x);
//        Console.WriteLine(y);
//    }
//}

//using System;

//namespace App_18
//{
//    internal class Program
//    {
//        /*This code will not swap the values without ref keywords */
//        //public static void Swap(ref int a, ref int b)
//        //{
//        //    int temp = a;
//        //    a = b;
//        //    b = temp;
//        //}

//        static void Main(string[] args)
//        {
//            int a = 5;
//            int b = 1;

//            Console.WriteLine("Before swapping:");
//            Console.WriteLine("a = {0}, b = {1}", a, b);

//            Swap(ref a, ref b);

//            Console.WriteLine("After swapping:");
//            Console.WriteLine("a = {0}, b = {1}", a, b);
//        }
//    }
//}


//using System;

//namespace App_18
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int choice;

//            do
//            {
//                Console.Write("Enter a character: ");
//                char ch = Console.ReadKey().KeyChar;
//                Console.WriteLine();

//                if (ch >= 'a' && ch <= 'z')
//                {
//                    Console.WriteLine("Lowercase letter");
//                }
//                else if (ch >= 'A' && ch <= 'Z')
//                {
//                    Console.WriteLine("Uppercase letter");
//                }
//                else
//                {
//                    Console.WriteLine("Not an alphabet");
//                }

//                Console.Write("\nEnter 0 to Exit or 1 to Continue: ");

//                while (!int.TryParse(Console.ReadLine(), out choice))
//                {
//                    Console.Write("Invalid input. Enter 0 or 1: ");
//                }

//                Console.WriteLine();

//            } while (choice != 0);
//        }
//    }
//}

//using System;

//namespace App_18
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int inp = int.Parse(Console.ReadLine());
//            //Console.WriteLine(inp & 1);
//            //if (inp % 2 == 0)
//            //if ((inp & 1) == 0)
//            //{
//            //    Console.WriteLine("The number is even.");
//            //}
//            //else
//            //{
//            //    Console.WriteLine("The number is odd.");
//            //}

//            Console.WriteLine((inp * (inp + 1)) / 2);
//        }
//    }
//}


using System;

namespace App_18
{
    internal class Program
    {
        //static int fib(int n)
        //{
        //    if (n == 0 || n == 1)
        //    {
        //        return n;
        //    }
        //    return fib(n - 1) + fib(n - 2);
        //}
        static void Main(string[] args)
        {
            int inp = int.Parse(Console.ReadLine());
            //int ans = 0;
            //while (inp != 0)
            //{
            //    ans = ans * 10 + inp % 10;
            //    inp /= 10;
            //}
            var (x, y) = (10, 20);

            Console.WriteLine(x+java  y);
        }
    }
}