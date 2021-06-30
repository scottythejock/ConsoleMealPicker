using System;

namespace ConsoleMealPicker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "M E A L - P I C K E R";

            bool keepGoing = true;

            while (keepGoing)
            {
                string[] myMeal = new string[12];
                myMeal[0] = "Burrito";
                myMeal[1] = "Pizza";
                myMeal[2] = "Burger & Wedges";
                myMeal[3] = "Curry";
                myMeal[4] = "Baked Potato";
                myMeal[5] = "Quasedillas";
                myMeal[6] = "Chilli";
                myMeal[7] = "Kiev or Pastie with Mash & Veg";
                myMeal[8] = "Chicken Satay Noodles";
                myMeal[9] = "Macaroni cheese & garlic bread";
                myMeal[10] = "Takeaway";
                myMeal[11] = "Pasta Bolognese";

                string[] dayOfWeek = new string[7];
                dayOfWeek[0] = "Monday";
                dayOfWeek[1] = "Tuesday";
                dayOfWeek[2] = "Wednesday";
                dayOfWeek[3] = "Thursday";
                dayOfWeek[4] = "Friday";
                dayOfWeek[5] = "Saturday";
                dayOfWeek[6] = "Sunday";

                Random random = new Random();
                int randomNumber = random.Next(0, 11);
                string selectedMeal = myMeal[randomNumber];

                Console.WriteLine("  /--------------------------/");
                Console.WriteLine(" /   M E A L - P I C K E R  /");
                Console.WriteLine("/--------------------------/");
                Console.WriteLine(" ");
                Console.WriteLine("Your suggested meal for today is:");
                Console.WriteLine("--==[ " + selectedMeal + " ]==--");
                Console.WriteLine(" ");
                Console.WriteLine("Your suggested meal plan is as follows :");
                for (int dayCount = 0, randNum = random.Next(0,11),randMeal = randNum; dayCount < dayOfWeek.Length; dayCount++, randNum = random.Next(0, 11), randMeal = randNum)
                    Console.WriteLine(dayOfWeek[dayCount] + " - " + myMeal[randMeal]);
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
