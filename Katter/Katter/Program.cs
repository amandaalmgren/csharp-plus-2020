using System;
using System.Collections.Generic;

namespace Katter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cat> catList = new List<Cat>();
            Cat firstCat = new Cat("Noak", 5, "black and white");
            Cat secondCat = new Cat("Semlan", 16, "grey");
            Cat thirdCat = new Cat("Ichuap", 2, "black and white");
            catList.Add(firstCat);
            catList.Add(secondCat);
            catList.Add(thirdCat);

            int userInput = 0;

            while (userInput != 4)
            {
                Console.Clear();
                Console.WriteLine("Choose an option and press enter: ");
                Console.WriteLine("[1] Create a new cat");
                Console.WriteLine("[2] Show cats");
                Console.WriteLine("[3] Search for a cat");
                Console.WriteLine("[4] End program");
                userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Enter name: ");
                    string inputName = Console.ReadLine();
                    Console.WriteLine("Enter age: ");
                    int inputAge = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter color: ");
                    string inputColor = Console.ReadLine();

                    Cat newCat = new Cat(inputName, inputAge, inputColor);
                    catList.Add(newCat);

                    Console.Clear();
                    Console.WriteLine("Cat added successfully!");
                    Console.WriteLine("");
                    Console.WriteLine("Press enter to go back to the menu.");
                    Console.ReadKey();
                    continue;
                }

                if (userInput == 2)
                {
                    Console.Clear();
                    for (int i = 0; i < catList.Count; i++)
                    {
                        Console.WriteLine($"Cat number {i + 1} is named " + catList[i].Name + ", and is " + catList[i].Age + " years old. The fur is " + catList[i].Color + ".");
                    }

                    Console.WriteLine("");
                    Console.WriteLine("Press enter to go back to the menu.");
                    Console.ReadKey();
                    continue;
                }
            
                if (userInput == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Enter name to search for: ");
                    string searchWord = Console.ReadLine(); 

                    for (int i = 0; i < catList.Count; i++)
                    {
                        if (catList[i].Name == searchWord)
                        {
                            Console.WriteLine("The cat is placed in position " + (i + 1) + ". " + catList[i].Name + " is " + catList[i].Age + " years old. And the fur is " + catList[i].Color + ".");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, that cat does not exist.");
                            break;
                        }
                    }
                }

            }
            
            Console.Clear();
            Console.WriteLine("See you again soon!");
            

            Console.ReadKey();
        }
    }
}
