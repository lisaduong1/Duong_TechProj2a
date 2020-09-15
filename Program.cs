using System;
using System.ComponentModel.Design.Serialization;
/*
* Author: Lisa Duong
* Class: ISM4300.001
* Assignment: Tech Project #2a
* Description: This assignment is a C# console program that demonstrates the use of iterative statements.
* Date: 9/15/2020
*/

namespace Duong_TechProj2a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer value between 1 and 25");
            // asking user to enter a number between 1 and 25

            // using try catch to execute program correctly so program will not fail
            try
            {
                string input = Console.ReadLine();
                // read user input
                int valueInput = int.Parse(input);
                // takes input and turns it into integer

                if ((valueInput > 0) && valueInput <= 25)
                    // if input is between 0-25, the for loop will execute
                {
                    int x = 0;
                    for (int i = 0; i < valueInput; i++)
                    {
                        x = x + 1;
                        // increase x number by 1, so instead of starting with 0.. it will start with 1
                        Console.WriteLine("You have entered " + valueInput.ToString() + ". " +
                            "This is the current integer value in the loop: " + x.ToString());
                        // display output
                    }
                    Console.WriteLine("Press any key to exit the program.");
                    // tells user to press any key to exit
                }
                else
                {
                    // if input is not integer between 1-25, this runs
                    Console.WriteLine("Please enter an integer value and try again...");
                    Console.WriteLine("Press any key to exit program.");

                }

            }
            catch
            {
                // this will run if it is not a integer between 1-25
                Console.WriteLine("Please enter an integer value and try again...");
                Console.WriteLine("Press any key to exit program.");
                // end of catch
            }
        }
    }
}
