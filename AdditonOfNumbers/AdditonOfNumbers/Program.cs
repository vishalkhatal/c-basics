using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditonOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number1=0, number2=0;
                bool IsNumber1Valid = false, IsNumber2Valid = false;

                while (!(IsNumber1Valid || IsNumber2Valid))
                {

                    if (!IsNumber1Valid)
                    {
                        Console.WriteLine("Enter first number");
                        try
                        {
                            number1 = Convert.ToInt32(Console.ReadLine());
                            IsNumber1Valid = true;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("You have entered wrong input");
                            continue;
                        }
                    }

                    if (!IsNumber2Valid)
                    {
                        try
                        {
                            Console.WriteLine("Enter Second number");
                            number2 = Convert.ToInt32(Console.ReadLine());
                            IsNumber2Valid = true;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("You have entered wrong input");
                            continue;
                        }
                    }

                    Console.WriteLine($"Addition is {number1 + number2} ");

                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                // We will show messge invalid input !!!
            }

        }
    }
}
