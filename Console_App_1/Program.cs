//using System;
//public delegate void deli(int funName);
//public class BaseClass
//{
//    public virtual void Print()
//    {
//        Console.WriteLine("Base Class Print Method");
//    }
//}

//public class DerivedClass : BaseClass
//{
//    public override void Print()
//    {
//        Console.WriteLine("Child Class Print Method");
//    }
//}

//namespace Console_App_1
//{
//    internal class Program
//    {
//        public static void Func(int i)
//        {
//            Console.WriteLine(i);
//            //i = 999;
//            //Console.ReadKey();
//        }
//        static void Main(string[] args)
//        {
//            deli del = new deli(Func);
//            del(5);
//            //int i = 5;
//            //Func(ref i);
//            //Console.WriteLine(i);
//            //BaseClass B = new DerivedClass();
//            //B.Print();

//        }
//    }
//}


using System;
using System.Collections.Generic;

namespace Console_App_1
{
    delegate bool IspromotedEmp(emp e);

    class emp
    {
        public int _id { get; set; }
        public string _name { get; set; }
        public int _exp { get; set; }
        public int _sal { get; set; }
        public int _rate { get; set; }

        public static void PromoteEmp(List<emp> emps, IspromotedEmp func)
        {
            foreach (emp e in emps)
            {
                if (func(e))
                {
                    Console.WriteLine("{1} with id : {0} got promoted!", e._id, e._name);
                }
            }
        }
    }

    internal class Deligates
    {
        public static bool IsPromoted(emp e)
        {
            if (e._exp >= 5)
            {
                return true;
            }
            return false;
        }

        public static void Main(string[] args)
        {
            List<emp> emps = new List<emp>();

            emps.Add(new emp() { _id = 101, _name = "John", _exp = 3, _sal = 50000, _rate = 5 });
            emps.Add(new emp() { _id = 102, _name = "Jane", _exp = 6, _sal = 60000, _rate = 6 });
            emps.Add(new emp() { _id = 103, _name = "Doe", _exp = 4, _sal = 55000, _rate = 5 });
            emps.Add(new emp() { _id = 104, _name = "Smith", _exp = 7, _sal = 70000, _rate = 7 });

            IspromotedEmp obj = new IspromotedEmp(IsPromoted);
            emp.PromoteEmp(emps, obj);
        }
    }
}