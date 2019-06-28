using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project6
{
    public partial class StoryMaker : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGenerate_Click(object sender, EventArgs e)
        {

            Regex alpha = new Regex(@"[^a-zA-Z]+$");
            string[] userInput = new string[8];
            bool[] isValid = new bool[8];

            userInput[0] = Noun1.Text;
            userInput[1] = Noun2.Text;
            userInput[2] = Verb1.Text;
            userInput[3] = Verb2.Text;
            userInput[4] = Adjective1.Text;
            userInput[5] = Adjective2.Text;
            userInput[6] = Adverb1.Text;
            userInput[7] = Adverb2.Text;


            // Validate the input
            for (int i = 0; i < userInput.Length; i++)
            {
                if (alpha.IsMatch(userInput[i]) && userInput[i] != String.Empty)
                    isValid[i] = true;
                else
                    isValid[i] = false;
            }

            // Error messages
            for (int i = 0; i < userInput.Length; i++)
            {
                if (isValid[i])
                {
                    if (i == 0)
                    {
                        errN1.Text = "a-z,A-Z only";
                    }
                    else if (i == 1)
                    {
                        errN2.Text = "a-z,A-Z only";
                    }
                    else if (i == 2)
                    {
                        errV1.Text = "a-z,A-Z only";
                    }
                    else if (i == 3)
                    {
                        errV2.Text = "a-z,A-Z only";
                    }
                    else if (i == 4)
                    {
                        errAdj1.Text = "a-z,A-Z only";
                    }
                    else if (i == 5)
                    {
                        errAdj2.Text = "a-z,A-Z only";
                    }
                    else if (i == 6)
                    {
                        errAdv1.Text = "a-z,A-Z only";
                    }
                    else
                    {
                        errAdv2.Text = "a-z,A-Z only";
                    }
                }
                else
                {
                    errN1.Text = String.Empty;
                    errN2.Text = String.Empty;
                    errV1.Text = String.Empty;
                    errV2.Text = String.Empty;
                    errAdj1.Text = String.Empty;
                    errAdj2.Text = String.Empty;
                    errAdv1.Text = String.Empty;
                    errAdv2.Text = String.Empty;
                    Noun1.Text = String.Empty;
                    Noun2.Text = String.Empty;
                    Verb1.Text = String.Empty;
                    Verb2.Text = String.Empty;
                    Adjective1.Text = String.Empty;
                    Adjective2.Text = String.Empty;
                    Adverb1.Text = String.Empty;
                    Adverb2.Text = String.Empty;
                }
            }

            Story.InnerText = userInput[0] + " " + userInput[6] + " " + userInput[2] + " elitist, and perhaps that's what " + userInput[0] +
                " needs. " + userInput[0] + " " + userInput[2] + " elitist. When " + userInput[1] + " says aspire. That's a " +
                userInput[4] + " word. Let people work " + userInput[6] + " and aspire to some day be able to play " + userInput[6] + " golf";

            //It may be elitist, and perhaps that's what golf needs. Let golf be elitist. When i say 'aspire. 
            //That's a positive word. Let people work hard and aspire to some day be able to play golf - Donald Trump
        }
    }
}