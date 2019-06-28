using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Project04_FastFoodOrdering
{
    // Enumerated types
    enum Sandwiches { BigMac, LitteBoy, GreasePatty, SpicyChicken, TheSkimper };
    enum Toppings { WiltedLettuce, CrispyOnions, SourPickles, Ketchup, Mayo, Mustard, Ranch, Bacon };

    #region Structures
    struct Sandwich
    {
        Sandwiches sandwich;
        int[] toppings;
        float cost;

        public Sandwich(Sandwiches s, int[] t, float c)
        {
            sandwich = s;
            toppings = null;
            cost = c;
            Array.Copy(t, toppings, t.Length);
        }
    }

#endregion

    public sealed partial class MainPage : Page
    {
        // Define Constants
        public static readonly float[] PRICES = { 5.75f, 4.79f, 3.84f, 2.49f, 6.99f };
        public static readonly string[] SANDWICH_NAMES = { "BigMac", "The LittleBoy", "Grease Patty", "Spicy Chicken", "The Skimper" };


        public MainPage()
        {
            this.InitializeComponent();



        }

       
    }

    
}
