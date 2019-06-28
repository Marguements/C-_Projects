// Author: Mathew Argue
// Program 2
// This program converts fahrenheit to celsius.

using System;
using Windows.UI.Xaml.Controls;


namespace TempConverter
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void tempInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Try to parse the user input into a valid number
            bool parseInput = double.TryParse(tempInput.Text, out double convertTemp);

            if (parseInput)
            {
                // Restrict the max temp that can be calculated
                if (convertTemp > -9999999999.0 && convertTemp < 9999999999.0)
                {
                    
                        convertTemp = ConvertToCelsius(convertTemp);
                        tempOutput.Text = convertTemp.ToString("N2") + " °C";
                    
                }
                // Clear the screen if input exceeds the maximum permitted temperature
                else
                    ClearScreen();
            }
            // Clear the screen if input is not a valid number
            else
                ClearScreen();
        }

        // Clear any values in the output and input fields
        private void ClearScreen()
        {
            if (tempInput.Text != "-")
            {
                tempInput.Text = String.Empty;
                tempOutput.Text = "Celsius";
            }
            else
                tempOutput.Text = "Celsius";
        }

        // Calculate the temperature in celsius
        private double ConvertToCelsius(double convertTemp) => (convertTemp - 32d) / 1.8d;
    }
}
