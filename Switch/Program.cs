using System;

namespace swtich

{
    class Program
    {
        static void Main(string[] args)
        {

            string value;
            do
            {
                Console.Write("Type your first number :");
                double number1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Type your second number :");
                double number2 = Convert.ToInt32(Console.ReadLine());
            Start: Console.Write("Enter symbol |  + ,  - ,   * ,  / :");
                string sign = Console.ReadLine();


                switch (sign)
                {
                    case "+":

                        Console.WriteLine(number1 + number2);
                        break;
                    case "-":
                        Console.WriteLine(number1 - number2);
                        break;
                    case "*":
                        Console.WriteLine(number1 * number2);
                        break;
                    case "/":
                        Console.WriteLine(number1 / number2);
                        break;
                    default:

                        Console.WriteLine("Wrong  ");
                        goto Start;



                }

                Console.Write("do you want to continue(y/n)");
                value = Console.ReadLine();


            }
            while (value == "y" || value == "Y");

            Console.WriteLine("Thanks");

        }

    }
}