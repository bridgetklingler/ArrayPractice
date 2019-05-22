using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeArrayTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating an array
            int[] arrayOne = new int[5];
            int[] arrayTwo = { 1, 2, 3, 4 };

            arrayOne[0] = 44;

            for (int i = 0; i < arrayOne.Length; i++)
            {
                Console.WriteLine("Please enter a number: ");
                arrayOne[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(arrayOne[i]);
            }

            int sum = 0;
            foreach(int number in arrayOne)
            {
                sum = sum + number;
            }

            Console.WriteLine("The sum of your numbers is: " + sum);
            Console.ReadLine();

            //putting numbers in a new array

            int[] arrayThree = new int[7];

            for (int i = 0; i < arrayOne.Length; i++)
            {
                arrayThree[i] = arrayOne[i];
            }

            //or putting numbers into a list if the amount of input varies, so you don't have to create a new array every time the amount of input changes

            List<int> numberList = new List<int>();

            foreach(int number in arrayOne)
            {
                numberList.Add(number);
                Console.WriteLine(number);
            }

            Console.ReadLine();

            //List Practice

            List<int> numberListTwo = new List<int>();
            Console.WriteLine("Enter a number to add to the list:");
            int listItem = Convert.ToInt32(Console.ReadLine());
            numberListTwo.Add(listItem);
            Console.WriteLine($"This is the number in my list: { numberListTwo[0]}");
            numberListTwo.Add(5);
            numberListTwo.Add(89);
            numberListTwo.Count();

            foreach (int number in numberListTwo)
            {
                Console.WriteLine(number);
            }




            //Shelter Practice 
            Shelter shelter = new Shelter("Happy Place");

            List<Shelter> listOfShelters = new List<Shelter>() { shelter }; //{shelter} is another way to add it all in one line;
            listOfShelters.Add(shelter);

            shelter = new Shelter("Someplace Nice");
            listOfShelters.Add(shelter);

            foreach(Shelter element in listOfShelters)
            {
                Console.WriteLine($"{element.Name} {element.SomeProperty}");
            }

            Console.ReadLine();


        }
    }
}
