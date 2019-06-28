using System;
using System.Collections.Generic;
using System.Collections;
namespace Project7
{
    /// <summary>
    /// This customized collection 'returns' items by passing through the original 
    /// collection two times: first the 'even' numbered index values are used, then the 
    /// 'odd' number index values.
    /// This collection implements the generic IEnumerable interface, which mandates the 
    /// GetEnumerator() method; an iterator is used to enable functionality with a 
    /// foreach loop.
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
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
            for (int currentIndex = 3; currentIndex < currentCount || firstPass; currentIndex += 2)
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


