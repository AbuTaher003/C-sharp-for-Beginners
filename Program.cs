using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 // Namespace is a way to organize code in C#. Basically, it is a container for classes.
{
    class player
    {
        public string name;
        public int health = 50;
        public void healths(int h)
        {
            health = h;
        }
        public int gethealth()
        {
            return health;
        }
    }
    internal class Program
    {

        // static void Greet(string name)
        // {
        //     Console.WriteLine("Hello, Good Morning "+ name);
        // }
        static void Main(string[] args)
        {

            // int age = 25;
            // Console.WriteLine("Hello World!");
            // Console.WriteLine("Hello I'm Taher");
            // Console.Write("I love c sharp"); // Sudhu wirte likhle sekhane new line create hoyna. 
            // Console.WriteLine(" and I love programming and my age is "+ age);

            // Console.ReadLine(); // This line is used to keep the console window open until the user presses a key.
            // string name = Console.ReadLine();
            // Console.WriteLine(name);

            // int a = 10;
            // float b = 20.12f;
            // double c = 56.45;
            // bool isgreat = true;

            // Console.WriteLine("The value of a, b and c is " + a + " , " + b + " and " + c);
            // Console.WriteLine(isgreat);

            // Type casting
            // There are two types of type casting in C#:
            // 1. Implicit type casting
            // 2. Explicit type casting
            // char to int to long to float to double
            // Implicit type casting is done automatically by the compiler when converting a smaller data type to a larger data type.
            // Explicit type casting is done manually by the programmer when converting a larger data type to a smaller data type.
            // Implicit type casting
            // int a = 10;
            // long b = a; // Implicit type casting from int to long
            // float c = b; // Implicit type casting from long to float
            // double d = c; // Implicit type casting from float to double
            // float varr = Convert.ToInt32(9.555);
            // Convert.ToDouble
            // Convert.ToString
            // Convert.ToBoolean

            // // int x = (int)3.5;
            // // Console.WriteLine(x);
            // // Console.WriteLine(b);
            // Console.WriteLine(varr);

            // Console.WriteLine("Enter your name: ");
            // string name = Console.ReadLine();
            // Console.WriteLine("your name is " + name);
            // Console.WriteLine("How many candies do you want?");
            // string can = Console.ReadLine();
            // Console.WriteLine("you will get four more candies " + (Convert.ToInt32(can) + 4));



            // Operators in C#
            // There are several types of operators in C#:
            // 1. Arithmetic operators
            // 2. Relational operators
            // 3. Logical operators
            // 4. Assignment operators
            // 5. Bitwise operators
            // 6. Unary operators
            // 7. Ternary operators

            // int a = 4;
            // int b = 2;

            // Console.WriteLine("The value of a + b is: " + (a + b));
            // Console.WriteLine("The value of a - b is: " + (a - b));
            // Console.WriteLine("The value of a * b is: " + (a * b));
            // Console.WriteLine("The value of a / b is: " + (a / b));


            // Logical Operators

            // Console.WriteLine(true && true);
            // Console.WriteLine(true && false);
            // Console.WriteLine(false && false);


            // Console.WriteLine(true || true);
            // Console.WriteLine(true || false);
            // Console.WriteLine(false || false);

            // comparison operators

            // Console.WriteLine(5 > 3);
            // Console.WriteLine(5 < 3);
            // Console.WriteLine(5 >= 3);
            // Console.WriteLine(5 <= 3);
            // Console.WriteLine(5 == 3);

            // int a = Math.Max(5, 10);
            // Console.WriteLine(a);
            // int b = Math.Min(5, 10);
            // Console.WriteLine(b);


            // string hello = "Hey bro , how are you doing?";
            // // Console.WriteLine(hello.Length);
            // // Console.WriteLine(hello.ToUpper());
            // // Console.WriteLine(hello.ToLower());


            // // string name = Console.ReadLine();
            // // string candies = Console.ReadLine();

            // // Console.WriteLine($"your name is {name} and you will get {candies} candies.");

            // Console.WriteLine(hello.IndexOf("are"));


            // Loops in C#
            // while loop

            // int i = 0;
            // while (i < 5)
            // {
            //     Console.WriteLine(i);
            //     i++;
            // }

            // do while loop 

            // int i = 0;
            // do
            // {
            //     Console.WriteLine(i);
            //     i++;
            // } while (i < 5);


            //for loop

            // for (int i = 0; i < 5; i++)
            // {
            //     Console.WriteLine(i);
            // }

            // Console.WriteLine("Enter your name: ");
            // string name = Console.ReadLine();
            // Greet(name);

            player Taher = new player();
            Taher.name = "Taher";
            Console.WriteLine(Taher.name);
            Console.WriteLine(Taher.health);
            Taher.healths(69);
            Console.WriteLine(Taher.health);
            Console.WriteLine(Taher.gethealth());


            Console.ReadLine();
        }
    }
}