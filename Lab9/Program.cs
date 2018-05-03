using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Names = new ArrayList();
            Names.Add("Adam");
            Names.Add("Bryan");
            Names.Add("Chris");
            Names.Add("Danny");
            Names.Add("Emily");

            ArrayList Town = new ArrayList();
            Town.Add("Albington");
            Town.Add("Brenton");
            Town.Add("Creshire");
            Town.Add("Denton");
            Town.Add("Elcot");

            ArrayList Food = new ArrayList();
            Food.Add("apple");
            Food.Add("banana");
            Food.Add("cashew");
            Food.Add("danish cookies");
            Food.Add("empanada");

            ArrayList Color = new ArrayList();
            Color.Add("aqua");
            Color.Add("brown");
            Color.Add("cyan");
            Color.Add("dark blue");
            Color.Add("emerald green");

            Console.WriteLine("Welcome to our C# class.");

            bool RunProgram = true;
            while (RunProgram)
            {
                Console.WriteLine($"Which student would you like to learn more about? (Write a number between 1-{Names.Count})");
                string Input = Console.ReadLine();
                int StudentNumber = 0;
                int.TryParse(Input, out StudentNumber);
                StudentNumber--;

                if (StudentNumber < 0 || StudentNumber > Names.Count)
                {
                    Console.WriteLine("That wasn't a valid student number");
                    continue;
                }
                else
                {
                    Console.WriteLine($"Student {Input} is {Names[StudentNumber]}. Would you like to know more about {Names[StudentNumber]} or add new student? (Yes/No/Add)");
                }

                string Input2 = Console.ReadLine();

                if (Input2.ToUpper() != "YES" && Input2.ToUpper() != "NO" && Input2.ToUpper() != "ADD")
                {
                    Console.WriteLine("Invalid entry. Please type \"Yes,\" \"No,\" or \"Add\"");
                }
                else if (Input2.ToUpper() == "YES")
                {
                    Console.WriteLine($"What would you like to know about { Names[StudentNumber]}?");

                    bool GetToKnow = true;
                    while (GetToKnow)
                    {
                        Console.WriteLine("(Enter \"Hometown,\" \"Favorite Food,\" or \"Favorite Color\")");
                        string KnowMore = Console.ReadLine();

                        if (KnowMore.ToUpper() != "HOMETOWN" && KnowMore.ToUpper() != "FAVORITE FOOD" && KnowMore.ToUpper() != "FAVORITE COLOR")
                        {
                            Console.WriteLine("Invalid entry.");
                            continue;
                        }
                        else if (KnowMore.ToUpper() == "HOMETOWN")
                        {
                            Console.WriteLine($"{Names[StudentNumber]} is from {Town[StudentNumber]}");
                        }
                        else if (KnowMore.ToUpper() == "FAVORITE FOOD")
                        {
                            Console.WriteLine($"{Names[StudentNumber]}'s favorite food is {Food[StudentNumber]}");
                            //continue;
                        }
                        else if (KnowMore.ToUpper() == "FAVORITE COLOR")
                        {
                            Console.WriteLine($"{Names[StudentNumber]}'s favorite color is {Color[StudentNumber]}");
                            //continue;
                        }
                        GetToKnow = false;
                    }
                }
                else if (Input2.ToUpper() == "NO")
                {
                    Console.WriteLine("Thanks!");
                    return;
                }
                else if (Input2.ToUpper() == "ADD")
                {
                    bool AddingName = true;
                    while (AddingName)
                    {
                        Console.WriteLine("Enter student name: ");
                        string NewName = Console.ReadLine();
                        bool numberIn = NewName.Any(char.IsDigit);

                        if (string.IsNullOrEmpty(NewName) || numberIn == true)
                        {
                            Console.WriteLine("Invalid name. Please try again");
                            continue;
                        }
                        Names.Add(NewName);
                        AddingName = false;
                    }
                    bool AddingHometown = true;
                    while (AddingHometown)
                    {
                        Console.WriteLine("Enter student's hometown: ");
                        string NewHometown = Console.ReadLine();
                        bool numberIn = NewHometown.Any(char.IsDigit);

                        if (string.IsNullOrEmpty(NewHometown) || numberIn == true)
                        {
                            Console.WriteLine("Invalid hometown. Please try again");
                            continue;
                        }
                        Town.Add(NewHometown);
                        AddingHometown = false;
                    }
                    bool AddingFavFood = true;
                    while (AddingFavFood)
                    {
                        Console.WriteLine("Enter student's favorite food: ");
                        string NewFavFood = Console.ReadLine();
                        bool numberIn = NewFavFood.Any(char.IsDigit);

                        if (string.IsNullOrEmpty(NewFavFood) || numberIn == true)
                        {
                            Console.WriteLine("Invalid food name. Please try again");
                            continue;
                        }
                        Food.Add(NewFavFood);
                        AddingFavFood = false;
                    }
                    bool AddingFavColor = true;
                    while (AddingFavColor)
                    {
                        Console.WriteLine("Enter student's favorite color: ");
                        string NewFavColor = Console.ReadLine();

                        if (string.IsNullOrEmpty(NewFavColor))
                        {
                            Console.WriteLine("Invalid color name. Please try again");
                            continue;
                        }
                        Color.Add(NewFavColor);
                        AddingFavColor = false;
                    }
                    bool SeeNewList = true;
                    while (SeeNewList)
                    {
                        Console.WriteLine("Thanks for adding the student's information.");
                        Console.WriteLine("Would you like to see the full list of students now? (Yes/No/Exit)");
                        string Input3 = Console.ReadLine();

                        if (Input3.ToUpper() != "YES" && Input3.ToUpper() != "NO" && Input3.ToUpper() != "EXIT")
                        {
                            Console.WriteLine("That's not a valid response");
                            continue;
                        }
                        else if (Input3.ToUpper() == "NO" || Input3.ToUpper() == "EXIT")
                        {
                            break;
                        }
                        else if (Input3.ToUpper() == "YES")
                        {
                            for (int i = 0; i < Names.Count; i++)
                            {
                                Console.WriteLine(Names[i]);
                            }
                            SeeNewList = false;
                        }
                    }
                }
            }
        }
    }
}
