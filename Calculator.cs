using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Program";

            float num1;
            float num2;
            string calculationType;

            Console.Write("Hi, this is an calculator.\nWhat would you like to calculate today? ");
            calculationType = Console.ReadLine();
            if(calculationType == "Help")
            {
                Console.WriteLine(" - Multiply/Multiplication\n - Dividing/Division\n - Adding/Addition\n - Subtracting/Subtraction");
                Console.Write("Hi, this is an calculator.\nWhat would you like to calculate today? ");
                calculationType = Console.ReadLine();
            }
            
            Console.Write("Please Input Number 1: ");
            num1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Please Inpit Number 2: ");
            num2 = Convert.ToSingle(Console.ReadLine());

            calculationType = calculationType.ToLower();

            if(calculationType == "multiply" || calculationType == "multiplication")
            {
                float result = num1 * num2;
                Console.Write("The result is " +  result);
            }
            else
            {
                if(calculationType == "adding" || calculationType == "addition")
                {
                    float result = num1 + num2;
                    Console.Write("The result is " +  result);
                }
                else
                {
                    if(calculationType == "subtracting" || calculationType == "subtraction")
                    {
                        float result = num1 - num2;
                        Console.Write("The result is " +  result);
                    }
                    else
                    {
                        if(calculationType == "dividing" || calculationType == "division")
                        {
                            float result = num1 / num2;
                            Console.Write("The result is " + result);
                        }
                        else
                        {
                            Console.Write("The calculation type is wrong. \nTry typing Help to get all avalible calculation types.");
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
