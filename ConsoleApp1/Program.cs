using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.Write(" Hello Soumojit.");
            Console.WriteLine("I love C#");
            Console.WriteLine(" This is my First C# code.");
            int a = 23;
            Console.WriteLine("My age is "+a+" years.");
            float fl = 23.023f;
            int typecast = (int) fl;// explicit casting
            Console.WriteLine("Float Typecasted to int " + typecast);
            Console.WriteLine("Enter your name: ");
            //String name = "";
            //Console.ReadLine();
            char d = 's';
            Console.WriteLine("the character is " + d);
            //char to int to long to float to double
            //char can be promoted to int , int to long and so on 
            long l = d;
            Console.WriteLine(d);
            int b = 56;
            int ans = func1(a, b);
            Console.WriteLine("this is the ans of sum of two numbers trough a function "+ans);
            Console.ReadLine();
        }
        public static int func1(int a, int b)
        {
            int sum = 0;
            sum = a + b;
            return sum;
        }
    }
}
