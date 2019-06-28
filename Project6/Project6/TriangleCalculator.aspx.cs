using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project6
{
    public partial class TriangleCalculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            double tSideA = 0;
            double tSideB = 0;

            // Try converting side A to a positive number
            try
            {
                if (SideA.Text != string.Empty)
                {
                    tSideA = Double.Parse(SideA.Text);
                    if(tSideA <= 0)
                    {
                        err1.Text = "The number must be greater than zero";
                    }
                    else
                    {
                        err1.Text = String.Empty;
                    }

                }
                else
                {
                    err1.Text = "Cannot be empty";
                }
            }
            catch(FormatException ex)
            {
                err1.Text = "Only Positive Numbers Allowed";
            }

            // Try converting side B to a positive number
            try
            {
                if (SideB.Text != string.Empty)
                {
                    tSideB = Double.Parse(SideB.Text);
                    if (tSideB <= 0)
                    {
                        err2.Text = "The number must be greater than zero";
                    }
                    else
                    {
                        err2.Text = String.Empty;
                    }
                }
                else
                {
                    err2.Text = "Cannot be empty";
                }
            }
            catch (FormatException ex)
            {
                err2.Text = "Only Positive Numbers Allowed";
            }

            //Set the results
            if (tSideA > 0 && tSideB > 0)
            {
                SideC.Text = "Hypotenuse: ≈ " +  CalculateHypotenuse(tSideA, tSideB).ToString("0.##");
                Perimeter.Text = "Perimeter: ≈ " + CalculatePerimeter(tSideA, tSideB).ToString("0.##");
                Area.Text = "Area: = " + CalculateArea(tSideA, tSideB).ToString("0.##");
                tSideA = 0;
                tSideB = 0;
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            SideA.Text = String.Empty;
            SideB.Text = String.Empty;
            err1.Text = String.Empty;
            err2.Text = String.Empty;
            SideC.Text = "Hypotenuse:";
            Perimeter.Text = "Perimeter:";
            Area.Text = "Area:";
        }

        private double CalculateHypotenuse(double sideA, double sideB)
        {
            return Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
        }

        private double CalculatePerimeter(double sideA, double sideB)
        {
            return sideA + sideB + CalculateHypotenuse(sideA, sideB);
        }

        private double CalculateArea(double sideA, double sideB)
        {
            return sideA * sideB * .5;
        }
    }
}