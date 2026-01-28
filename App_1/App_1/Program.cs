using System;

namespace App_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Emp obj=new Emp();
            obj.Id=101;
            obj.Name="John";
            obj.display();
            Console.WriteLine("Hello !");
            Console.ReadKey();
        }
    }

}

