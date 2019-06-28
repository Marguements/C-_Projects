using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace EnumeratingWithIterator {
	/// <summary>
	/// The program and class creates a collection that will enumerate through
	/// the even numbered items, and then the odd numbered items
	/// Specifically, it demonstrates the use of an enumerator
	/// </summary>
	class Program {
		static void Main(string[] args) {
			const int COUNT = 15;
			// Holds a collection defined by a class further below
			DataList<int> myListOfInts = new DataList<int>(COUNT);

			// Load the collection with values based on the loop's counter
			string commaString = string.Empty;  // Used to control the comma being displayed
			Console.WriteLine("Populate the Collection");
			Console.WriteLine("--------------------------------------------------------------------");
			Console.Write("Values inserted:  ");
			for (int x = 1; x <= COUNT; x++) {
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
			foreach (int item in myListOfInts) {
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

	/// <summary>
	/// This customized collection 'returns' items by passing through the original 
	/// collection two times: first the 'even' numbered index values are used, then the 
	/// 'odd' number index values.
	/// This collection implements the generic IEnumerable interface, which mandates the 
	/// GetEnumerator() method; an iterator is used to enable functionality with a 
	/// foreach loop.
	/// </summary>
	/// <typeparam name="TItem"></typeparam>
	public class DataList<TItem> : IEnumerable<TItem> {
		private TItem[] enumData = null;       // Holds the items used for this example
		private int currentCount;					// Used for inserting values
		private int enumSize;						// Size of the array
		private bool firstPass = true;			// Handles only going through the list twice

		// Constructor
		public DataList(int size) {
			enumData = new TItem[size];
			currentCount = 0;
			enumSize = size;
		}

		// Used to add a value to the collection up to the specified size
		public void Insert(TItem item) {
			if (currentCount < enumSize) {
				enumData[currentCount++] = item;
			}
			else
				throw new IndexOutOfRangeException("Collection Limit Reached");
		}

		// Method implementation for the generic version; uses an iterator to 
		// 'make life simpler'
		IEnumerator<TItem> IEnumerable<TItem>.GetEnumerator() {
			for (int currentIndex = 0; currentIndex < currentCount || firstPass; currentIndex += 2) {
				// If the end of the array is reached on the first pass, 'reset' the 
				// index to start the second pass
				if (currentIndex >= currentCount && firstPass) {
					firstPass = false;
					currentIndex = 1;
				}

				yield return enumData[currentIndex];
			}
		}

		#region Required Non-Generic Method for Interface
		// This generalized item is required, even though it is not used
		IEnumerator IEnumerable.GetEnumerator() {
			throw new NotImplementedException();
		}
		#endregion
	}
}
