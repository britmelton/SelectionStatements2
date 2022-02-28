using System;
using System.Collections.Generic;

namespace SelectionStatments2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Class Exercise Instructions
            //In class exercise 
            /*Ask the user for their favorite school subject. 
             * Store their answer in a variable
             * Pass the variable as the expression in a switch statement.
             * Create 5 different cases for different subjects.  
             * Each case will print the subject chosen and a custom message of your choosing.
             * Create a default case to handle any case not handled.*/

            //added a bonus GetDrinkByProfession
            #endregion

            Subject.GetSchoolSubject();
            Drinks.GetDrinkByProfession();


        }
    }
}
