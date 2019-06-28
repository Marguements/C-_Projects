using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project7
{
    class GenericCollection : IEnumerable<TItem>
    {
        public class DataList<TItem> : IEnumerable<TItem>
        {
            private TItem[] enumData = null;       // Holds the items used for this example
            private int currentCount;                   // Used for inserting values
            private int enumSize;                       // Size of the array
            private bool firstPass = true;          // Handles only going through the list twice

            // Constructor
            public DataList(int size)
            {
                enumData = new TItem[size];
                currentCount = 0;
                enumSize = size;
            }

            // Used to add a value to the collection up to the specified size
            public void Insert(TItem item)
            {
                if (currentCount < enumSize)
                {
                    enumData[currentCount++] = item;
                }
                else
                    throw new IndexOutOfRangeException("Collection Limit Reached");
            }

            // Method implementation for the generic version; uses an iterator to 
            // 'make life simpler'
            IEnumerator<TItem> IEnumerable<TItem>.GetEnumerator()
            {
                for (int currentIndex = 0; currentIndex < currentCount || firstPass; currentIndex += 2)
                {
                    // If the end of the array is reached on the first pass, 'reset' the 
                    // index to start the second pass
                    if (currentIndex >= currentCount && firstPass)
                    {
                        firstPass = false;
                        currentIndex = 1;
                    }

                    yield return enumData[currentIndex];
                }
            }

            #region Required Non-Generic Method for Interface
            // This generalized item is required, even though it is not used
            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }
            #endregion
        }
    }
}
