using System;

namespace L1_Program1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Exercise 1
            // Calculate the area of a triangle using Heron's formula
            // Area = SquareRoot(s * (s-a) * (s-b) * (s-c)) where s=(a+b+c)/2 and a,b,c are the sides of the triangle
            // Eg. a=3, b=4, c=5. Area = 6

            //Write your code here
            double s;
            double area;
            double d;

            Console.WriteLine("please enter side1");
            string side1 = Console.ReadLine();
            double a = double.Parse(side1);

            Console.WriteLine("please enter side2");
            string side2 = Console.ReadLine();
            double b = double.Parse(side2);

            Console.WriteLine("please enter side3");
            string side3 = Console.ReadLine();
            double c = double.Parse(side3);

            s = (a + b + c) / 2;
            d = (s * (s - a) * (s - b) * (s - c));
            Console.WriteLine("area of triangle is:" + Math.Sqrt(d));
            
            // Exercise 2
            // Input a number (n) from the user and check if it is even or odd.

            Console.WriteLine("please enter any number n");
            string number = Console.ReadLine();
            double n = int.Parse(number);
            if (n / 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
                    }

            // Exercise 3
            // Input 3 numbers from the user (x,y,z) and find the greatest of them.

            if (a > b)
            {
                if (a > c)
                { Console.WriteLine("a is gretest"); }
                else
                {
                    Console.WriteLine("b is gretest");
                }
            }
            else if (b > c)

            { Console.WriteLine("b is gretest"); }
            else
            { Console.WriteLine("c is gretest"); }











            Console.ReadKey(true);

        }
    }
}
           // Area = SquareRoot(s * (s - a) * (s - b) * (s - c);


              
