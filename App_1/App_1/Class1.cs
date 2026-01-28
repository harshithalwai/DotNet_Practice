using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace App_1
//{
//    internal class Class1
//    {
//    }
//}

public class Emp
{
    public int Id { get; set; }
    public string Name { get; set; }
     
    public void display()
    {
        Console.WriteLine("Id: " + Id);
        Console.WriteLine("Name: " + Name);
    }
}
