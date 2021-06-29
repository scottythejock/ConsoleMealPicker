using System;

namespace ConsoleMealPicker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "M E A L - P I C K E R";

            Console.WriteLine("_________________________");
            Console.WriteLine("|                       |");
            Console.WriteLine("| M E A L - P I C K E R |");
            Console.WriteLine("_________________________");

            bool keepGoing = true;

            while (keepGoing)
            {
                string[] myMeal = new string[10];
                myMeal[0] = "Burrito";
                myMeal[1] = "Pizza";
                myMeal[2] = "Burger";
                myMeal[3] = "Curry";
                myMeal[4] = "Baked Potato";
                myMeal[5] = "Quasedillas";
                myMeal[6] = "Chilli";
                myMeal[7] = "Kiev / Pastie";
                myMeal[8] = "Satay";
                myMeal[9] = "Macaroni";

                Random random = new Random();
                int randomNumber = random.Next(0, 9);

                string selectedMeal = myMeal[randomNumber];

                Console.WriteLine("Press any key to generate a meal suggestion: ");
                Console.WriteLine(" ");
                Console.ReadKey();
                Console.WriteLine("Your suggested meal is :");
                Console.WriteLine("--==[ " + selectedMeal + " ]==--");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Continue? Press any key to continue, N or n to exit:");
                var userWantsToContinue = Console.ReadLine();
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                keepGoing = userWantsToContinue?.ToUpper() != "N";
            }
            

        }
    }
}
