using System;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StreamReader file = new StreamReader(@"D:\Website\DotNet_Practice\ConsoleApp2\data.txt");
            ////Console.WriteLine(file.ReadToEnd());
            //Console.WriteLine(file.Read());
            //file.Close();

            int[] values = (int[])Enum.GetValues(typeof(Gender));
            string[] names = Enum.GetNames(typeof(Gender));
            foreach (int val in values)
            {
                Console.WriteLine(val);
            }

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

        }
    }

    public enum Gender
    {
        Unknown,
        Male,
        Female
    }
}
