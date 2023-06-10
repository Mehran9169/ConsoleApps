using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApps
{
    internal class Program
    {

        public static void ShowTxt(string text)
        {
            Console.WriteLine(text);
        }

        //static void Main(string[] args) //Exercise 1
        //{
        //    ShowTxt("Hello");

        //    ShowTxt("Please Enter Your First Name");

        //    string firstname = Console.ReadLine();

        //    ShowTxt("Please Enter Your Last Name");

        //    string lastname = Console.ReadLine();

        //    ShowTxt("Welcome " + firstname + " " + lastname);

        //    ShowTxt("Enter Your First Number ");

        //    int number1 = int.Parse(Console.ReadLine());

        //    ShowTxt("Enter Your Next Number ");

        //    int number2 = int.Parse(Console.ReadLine());

        //    ShowTxt("Your Adding Two Numbers Is : " + (number1 + number2));

        //    ShowTxt("Please Enter Number Between 10 and 20");

        //    number1 = 0; number2 = 0;

        //    number1 = int.Parse(Console.ReadLine());

        //    if (number1 >= 10 && number1 <= 20)
        //        ShowTxt("Good Job!");
        //    else
        //        ShowTxt("Your Number Is Not in Between 10 and 20");

        //    ShowTxt("Do You Like Your Job? yes/no/maybe");

        //    string input = Console.ReadLine();


        //    switch (input.ToLower())
        //    {
        //        case "yes":
        //            ShowTxt("Good");
        //            break;
        //        case "no":
        //            ShowTxt("Bad :(");
        //            break;
        //        case "maybe":
        //            ShowTxt("Ey Baba :|");
        //            break;
        //        default:
        //            ShowTxt("Chand Chandi ?!");
        //            break;
        //    }

        //    ShowTxt("Please Enter a Number For CountDown");
        //    number1 = int.Parse(Console.ReadLine());

        //    while (number1 >= 0)
        //    {
        //        Console.WriteLine(number1);
        //        number1 = number1 - 1;
        //    }
        //    //number1 = 1;
        //    Console.WriteLine("Next Loop");
        //    do
        //    {
        //        number1 = number1 + 1;
        //        Console.WriteLine(number1);
        //    } while (number1 <= 100);

        //    Console.WriteLine("Next Loop");

        //    for (int i = 0; i < 50; i++)
        //    {
        //        Console.WriteLine(number1);
        //        number1 = number1 + 1;
        //    }

        //    int[] numbers = { 10,25,66,88,1,2,3,0,5 };

        //    Array.Sort(numbers);

        //    foreach (int i in numbers)
        //        Console.WriteLine(i);

        //    Console.ReadLine();

        //} //Ex

        static void Main(string[] args) //Exercise 2
        {
            ShowTxt("Hello");
            Console.WriteLine("Please Enter Your Radius");
            Circle circle = new Circle();
            circle.r = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Your Diameter");
            circle.d = decimal.Parse(Console.ReadLine());
            double p = System.Math.PI;
            Console.WriteLine("Area Is : " + Decimal.ToDouble(circle.r) * Decimal.ToDouble(circle.r) * p);
            Console.ReadLine();

        }

    }

}
