using System;

namespace LabFour__Table_of_Powers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display title of program
            Console.WriteLine("Learn your squares and cubes!");

            //Declare option variable for while loop
            string option = "Y";
            while (option == "Y")
                
            {
                //Ask for user input and assign to a variable
                Console.WriteLine();
                Console.WriteLine("Enter an integer:");
                string NumberS = Console.ReadLine();

                //Validate the input using the tryparse method
                int NumberParse;
                bool NumberBool = int.TryParse(NumberS, out NumberParse);

                //Use if statement to determine what to do if the input is a number or not
                if (NumberBool == true)
                {
                    //Display heading to data outputs
                    Console.WriteLine();
                    Console.WriteLine("Number \t\t Squared \t Cubed");
                    Console.WriteLine("======= \t ======= \t =======");

                    //Use for loop to do mathmatic equasion from 1 to Input value
                    for (int i = 1; i <= NumberParse; i++)
                    {
                        Console.WriteLine((i) + "\t\t" + (i*i) + "\t\t" + (i*i*i));
                    }

                    //Ask if user would like to continue and convert their response to upper
                    Console.WriteLine();
                    Console.WriteLine("Would you like to continue? (y/n)");
                    option = Console.ReadLine().ToUpper();

                }
                else
                {
                    //If the input was not an integer, ask user to if they would like to try again
                    Console.WriteLine();
                    Console.WriteLine("You did not enter an integer");
                    Console.WriteLine();
                    Console.WriteLine("Would you like to continue? (y/n)");
                    option = Console.ReadLine();

                }
            }
        }
    }
}
