using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Which_Number_is_Greater
{
    class Class1
    {
        public static void Start()
        {
            try
            {
                Console.WriteLine("Type in the first number ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Type in the second number");
                int num2 = Convert.ToInt32(Console.ReadLine());

                if (num1 > num2)
                {
                    Console.WriteLine(num1 + " is greater than " + num2);
                    Console.ReadLine();

                }
                else if (num2 > num1)
                {
                    Console.WriteLine(num2 + " is greater than " + num1);
                    Console.ReadLine();

                }
                else if (num1 == num2)
                {
                    Console.WriteLine("The numbers are equal!!!");
                    Console.ReadLine();

                }
            }
            catch (FormatException)
            {
                Console.WriteLine("INCORRECT FORMAT!!!!  Please try again!!!");
                Console.ReadLine();
                Console.Clear();
                Start();

            }

        }
    }
}
