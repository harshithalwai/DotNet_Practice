using System;

public class BaseClass
{
    public virtual void Print()
    {
        Console.WriteLine("Base Class Print Method");
    }
}

public class DerivedClass : BaseClass
{
    public override void Print()
    {
        Console.WriteLine("Child Class Print Method");
    }
}

namespace Console_App_1
{
    internal class Program
    {
        //public static void Func(ref int i)
        //{
        //    Console.WriteLine(i);
        //    i = 999;
        //    Console.ReadKey();
        //}
        static void Main(string[] args)
        {
            //int i = 5;
            //Func(ref i);
            //Console.WriteLine(i);
            BaseClass B = new DerivedClass();
            B.Print();

        }
    }
}


