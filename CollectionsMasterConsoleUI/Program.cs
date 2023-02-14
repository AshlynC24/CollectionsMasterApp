using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            var number = new int[50];// you can put the amount of numbers inside the []

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(number);//populate is when you put numbers into your array 

            //TODO: Print the first number of the array
            Console.WriteLine("First number in array: ");
            Console.WriteLine(number[0]);
            //TODO: Print the last number of the array
            Console.WriteLine("Last number in array");
            Console.WriteLine(number[number.Length - 1]);//this takes you to the last number if dont know or do know how many are in the array
            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(number);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");
            Array.Reverse(number);
            NumberPrinter(number);

            Console.WriteLine("---------REVERSE CUSTOM------------");
            ReverseArray(number);

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            //% of 3 = 0 then for loop then if (int % 3 == 0) {numbers [1] =0} no else with if statement 
            Three(number);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");

            Array.Sort(number);
            NumberPrinter(number);
            

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            var numList = new List<int>();
            NumberPrinter(numList);

            //TODO: Print the capacity of the list to the console
            Console.WriteLine(numList.Capacity);

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(numList);
 
            //TODO: Print the new capacity
            Console.WriteLine($"New Capacity:{numList.Capacity}");

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            bool isAnswer = int.TryParse(Console.ReadLine(), out int numberToLookFor);
            NumberChecker(numList,numberToLookFor);
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(numList);
            NumberPrinter(numList);

            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            numList.Sort();

            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            numList.ToArray();


            //TODO: Clear the list
            

            #endregion
        }

        private static void Three(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] % 3 == 0)//call the array and index at any variable to do the math to solve for division by three 
                {
                    numbers[i] = 0;//if it is zero change the variable to zero 
                }
            }
            NumberPrinter(numbers);
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = numberList.Count; i >=0; i--)
            {
                if (numberList[i] % 2 != 0)
                {
                    numberList.Remove(numberList[i]);
                }
            }
            
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            string message = "Your number is not in the list";

            for(int i = 0; i <numberList.Count;i++)
            {
                if (numberList[i] == searchNumber)
                {
                    message = "Your Number is in the list";
                }  
            }
            Console.WriteLine(message);
            
        }

        private static void Populater(List<int> numberList)
        {
            while(numberList.Count < 51)
            {
                Random rng = new Random();
                var number = rng.Next(0, 51);

                numberList.Add(number);

            }

            
        }

        private static void Populater(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)//we are running the for loop as many times as there are index spots (50 in this case)
            {
                Random rng = new Random();//Random is another class
                numbers[i] = rng.Next(0, 51); 
            }
            

        }        

        private static void ReverseArray(int[] array)
        {
            Array.Reverse(array);

            NumberPrinter(array);
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
