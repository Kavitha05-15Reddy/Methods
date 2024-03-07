using System;
using System.Diagnostics;

namespace Methods
{
    class Program
    {
        //without return
        static void MyMethod(string name="kavi",int age=22)
        {
            Console.WriteLine("Hello " + name + " your age is " + age);
        }
        static void Name(string child1,string child2,string child3)
        {
            Console.WriteLine("Your youngest child is: " + child3);
        }
        //with return
        static int Sum(int x,int y)
        {
            return x + y;
        }
        //Method-overloading
        static int add(int x,int y)
        { 
            return x + y;
        }
        static double add(double x,double y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            //without return
            MyMethod("anji",28);
            MyMethod("vijji",26);
            MyMethod("vasu",24);
            MyMethod();

            Name(child3:"jhon",child1:"lime",child2:"vim");

            //with return
            Console.WriteLine(Sum(5, 4));
            //Method-overloading
            Console.WriteLine(add(5, 6));
            Console.WriteLine(add(5.6, 6.5));

        }
    }
}
