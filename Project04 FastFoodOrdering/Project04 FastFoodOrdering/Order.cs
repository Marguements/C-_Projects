using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project04_FastFoodOrdering
{
    class Order
    {
        Sandwich[] sandwiches;
        int fries;
        int drinks;

        public Order ()
        {
            SetSandwiches(null);
            SetFries(new Int32());
            SetDrinks(new Int32());
        }

        public Order(Sandwich[] pSandwiches, int pFries, int pDrinks)
        {
            Array.Copy(pSandwiches, GetSandwiches(), pSandwiches.Length);
            SetFries(pFries);
            SetDrinks(pDrinks);
        }


    #region Getters and Setters
        public int GetFries()
        {
            return fries;
        }

        public void SetFries(int value)
        {
            fries = value;
        }

        public int GetDrinks()
        {
            return drinks;
        }

        public void SetDrinks(int value)
        {
            drinks = value;
        }

        public Sandwich[] GetSandwiches()
        {
            return sandwiches;
        }

        public void SetSandwiches(Sandwich[] value)
        {
            sandwiches = value;
        }

        public Sandwich[] sandwich()
        {
            return GetSandwiches();
        }
    #endregion


    }
}
