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
            Console.WriteLine("My age is " + a + " years.");
            float fl = 23.023f;
            int typecast = (int)fl;// explicit casting
            Console.WriteLine("Float Typecasted to int " + typecast);

            char d = 's';
            Console.WriteLine("the character is " + d);
            //char to int to long to float to double
            //char can be promoted to int , int to long and so on 

            int l = d;
            Console.WriteLine("Char implicitly typecasted to int " + l);
            Console.WriteLine("Enter number 1: ");
            string num1 = Console.ReadLine();
            int c = Convert.ToInt32(num1);
            Console.WriteLine("Enter number 2: ");
            string num2 = Console.ReadLine();
            int b = Convert.ToInt32(num2);
            int ans = func1(c, b);
            Console.WriteLine($"this is the ans of sum of two numbers through a function is {c} + {b} = " + ans); // works as a format specifier 
            // typecast using builtin methods 
            int x = Convert.ToInt32(3.55);
            Console.WriteLine(x + " Typecasted using built in function from double to integer:");
            // other builtin functions include Convert.ToDouble();
            // Convert.ToString();
            String str = userinput();
            int len = str.Length; // returns the length of the string
            Console.WriteLine("My name is " + str);
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.ToLower());
            Console.WriteLine("Enter the number of cars you want :");
            string car = Console.ReadLine();
            Console.WriteLine("You will get 2 more cars XD. That is - " + (Convert.ToInt32(car) + 2));
            // Math.Max (a,b); to find the maximum of the two
            // Math.Min (a,b); to find the minimum of the two
            // double ans = Math.Sqrt (a); to find the square root of a that must be stored as double
            /* String Methods 
              1. str.IndexOf(" ")
              2. str.Substring(n) n is starting index value from which the string is trimmed and returns a new string 
              3. Escape sequence characters : /n(new line) , /" (to give a " between a string , /t to insert a tab space 
             */
            Console.WriteLine($"Please enter your age {str} ");
            string str_age = Console.ReadLine();
            int age = Convert.ToInt32(str_age);

            // Conditional statements
            if (age < 3)
            {
                Console.WriteLine("Ride a toy car");
            }
            else if (age < 12)
            {
                Console.WriteLine("Drive a car in your PC");

            }
            else if (age < 18)
            {
                Console.WriteLine("Turn 18 to start Driving ");
            }
            else if (age < 75)
            {
                Console.WriteLine("Drive safely");
            }
            else
            {
                Console.WriteLine("You cannot Drive a vehicle. Try something else :) ");
            }

            // switch case 
            switch(age)
            {
                case 18:
                    Console.WriteLine("You are now eligible to get your license to drive");
                    break;

                default:
                    Console.WriteLine("Drive safely. ");
                    break;

            }

            // Loops 
            int i = 1;
            while (i <= 10) // while loop 
            {
                Console.WriteLine(i); // Prints all natural numbers from 1 to 10.
                i++; // increments by 1 
            }

            do   // do-while loop
            {
                Console.WriteLine("Will execute atleast once. here i's 1st value will be printed " + i);
                i++;
            } while (i < 2);

            // for loop 
            for(int j = 0; j < 10; j++) 
            {
                Console.WriteLine(j+1); // will print from 1 to 10 , but i will run from 0 to 9.
            }
            // break - break the loop forever 
            // continue - break this loop for only once
            float res = Average(2, 6, 7);
            Console.WriteLine("The average of the 3 numbers = "+res);

            // OOPs - object and classes

            Player Ronnie = new Player();
            Console.WriteLine(Ronnie.name);
            //Console.WriteLine(Ronnie.health);
            Ronnie.setHealth(87);
            Console.WriteLine(Ronnie.getHealth());

            Console.ReadLine();
        }
        public static int func1(int a, int b) // Method 1
        {
            int sum = 0;
            sum = a + b;
            return sum;
        }
        public static String userinput()  // method 2 
        {
            Console.WriteLine("Enter your name :");
            String name = Console.ReadLine();
            return name;
        }
        public static float Average(int a , int b, int c)
        {
            //int sum = 0;
            //sum = a + b + c;
            //float avg = sum / 3;
            return (a+b+c)/3;
        } 
    }
}
