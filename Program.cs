using System;

namespace project
{
    class Program
    {
        static void Main()
        {
            // Console.Write("awd");
            // Console.WriteLine("awd");
            // Console.Write("awddddd\n awd \n awdwwww");
            // Console.Read();
            // Console.GetCursorPosition();
            // Console.Beep();
            // int number = 8769968;
            // int test;
            // test = 123;
            // Console.WriteLine("Result " + number);
            // Console.WriteLine(test);


            // uint num1 = 112; // без - не можна -10 а тільтки 10
            // byte num2 = 123; // 0 - 255
            // short num3 = -30001;
            // long num4 = 1232222222;

            // // Число з крапкою 
            // float num5 = 0.2322222224f;
            // double num6 = 0.222222222222222222222222222222222222222222222222222222222222222;
            // Console.WriteLine(num5);


            // string word = "awdawdas";
            // char num7 = 'a';
            // bool what = true;
            // Console.WriteLine(what);




            // int user1, user2;
            // user1 = Convert.ToInt32(Console.ReadLine());
            // user2 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine(user1 + user2);


            int user_input, user_inputTwo;
            Console.WriteLine("Enter number1: ");
            // Console.WriteLine("Enter number2: ");
            user_input = Convert.ToInt32(Console.ReadLine());
            user_inputTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("resutl " + user_input);
            Console.WriteLine("resutl " + (user_input / user_inputTwo));
            Console.WriteLine(Math.PI);
            Console.WriteLine(Math.Round(12.123133f)); // округлює число
        }
    }
}

// Func((e) => {Console.WriteLine(e)});
