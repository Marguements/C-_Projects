using System;
using System.Linq;
using System.Text;
namespace Project7
{

    class Program
    {
        static void Main(string[] args)
        {
            const int COUNT = 15;
            // Holds a collection defined by a class further below
            DataList<int> myListOfInts = new DataList<int>(COUNT);

            // Load the collection with values based on the loop's counter
            string commaString = string.Empty;  // Used to control the comma being displayed
            Console.WriteLine("Populate the Collection");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.Write("Values inserted:  ");
            for (int x = 1; x <= COUNT; x++)
            {
                myListOfInts.Insert(COUNT - x + 1);
                Console.Write(commaString + (COUNT - x + 1));
                commaString = ", ";
            }

            // Display the values as the collection, but notice that the collection is being
            // iterated through using foreach (only ascending order)
            commaString = string.Empty;
            Console.WriteLine("\n\n\nIterate through the Collection");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.Write("Values retrieved: ");
            foreach (int item in myListOfInts)
            {
                Console.Write(commaString + item);
                commaString = ", ";
            }

            // This second example shows using the generic with a different type
            DataList<string> myListOfStrings = new DataList<string>(11);

            Console.WriteLine("\n\n\nUsing a Different Type");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Strings inserted:  I love .NET class but Dr. Geary's quizzes not so much");
            myListOfStrings.Insert("I");
            myListOfStrings.Insert("love");
            myListOfStrings.Insert(".NET");
            myListOfStrings.Insert("class");
            myListOfStrings.Insert("but");
            myListOfStrings.Insert("Dr.");
            myListOfStrings.Insert("Geary's");
            myListOfStrings.Insert("quizzes");
            myListOfStrings.Insert("not");
            myListOfStrings.Insert("so");
            myListOfStrings.Insert("much");

            Console.Write("Strings retrieved: ");
            foreach (string item in myListOfStrings)
                Console.Write(item + " ");

            Console.WriteLine("\n");
        }
    }
}


