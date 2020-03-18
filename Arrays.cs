using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_March2020
{
    class Arrays
    {

        public void SimpleArray1()
            {
            int[] n = new int[10];
            int i, j;
            // initialize elements of an array
            for (i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }
            // output each array element's value
            for (j = 0; j < 10; j++)
            {
                Console.WriteLine("Element [{0}] = {1}", j , n[j]);
            }
        }

        #region AccessArray elements using different loops
        public void AccessArrayEl ()
        {
            int[] intArray = new int[5];
            intArray[0] = 10;
            intArray[1] = 20;
            intArray[2] = 30;
            intArray[3] = 40;
            intArray[4] = 50;
            // Accessing the elements using for loop
            Console.WriteLine("Foor loop:");
            for (int i = 0; i < intArray.Length; i++)
                Console.WriteLine(" " +intArray[i]);
            Console.WriteLine("");
            //Using the For-each loop
            Console.WriteLine("For-each loop:");
            foreach (int i in intArray)
            Console.WriteLine(" " + i);
            //Using while loop
            Console.WriteLine("While loop");
            int j = 0;
            while (j < intArray.Length)
            {
                Console.WriteLine(" " + intArray[j]);
                j++;
            }
            Console.WriteLine("Do-while loop");
            int k = 0;
            do
            {
                Console.WriteLine(" " + intArray[k]);
                k++;
            } while (k < intArray.Length);
        }
        #endregion

        #region Weekdays Simple Array
        public void Weekdays()
        {
            string[] weekDays;
            weekDays = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"};
            // Display elements of the array
            foreach (string day in weekDays)
                Console.WriteLine(day);
        }
        #endregion
    }
}
