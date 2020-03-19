using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_March2020
{
    class Arrays
    {

        #region Simple Array with nested for output
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
                Console.WriteLine("Element [{0}] = {1}", j, n[j]);
            }
        }
        #endregion

        #region AccessArray elements using different loops
        public void AccessArrayEl()
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
                Console.WriteLine(" " + intArray[i]);
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
            weekDays = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            // Display elements of the array
            foreach (string day in weekDays)
                Console.WriteLine(day);
        }
        #endregion

        #region Jagged array (array of arrays)
        public void JaggedArrEx()
        {
            // 2D array - declare the array of two elements
            int[][] arr = new int[2][];
            // Initialize the elements
            arr[0] = new int[5] { 1, 3, 5, 7, 9 };
            arr[1] = new int[4] { 2, 4, 6, 8 };
            // Display the array elements
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Element [" + i + "] Array: ");
                for (int j = 0; j < arr[i].Length; j++)
                    Console.Write(arr[i][j] + " ");
                Console.WriteLine();
            }
        }
        #endregion

        #region Passing Arrays as arguments 1
        public static void Result(int[] arr)
        {
            //Displaying the array elements
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Array Element" + arr[i]);
            }
        }

        //// Main method 
        //public static void Main()
        //{
        //    // declaring an array  
        //    // and initializing it 
        //    int[] arr = { 1, 2, 3, 4, 5 };
        //    // callling the method 
        //    Result(arr);
        //}
        #endregion

        #region Passing Arrays as arguments 2 use GetLength
        //pass 2D array as argument to find and transpose of matrix
        static int temp = 0;
        public static void Transpose(int[, ] arr2)
        {
            for (int i = 0; i<arr2.GetLength(0); i++)
            { 
                for (int j = i; j < arr2.GetLength(1); j++)
                {
                    temp = arr2[i,j];
                    arr2[i, j] = arr2[j, i];
                    arr2[j,i] = temp;
                }
            }
        }

        //to display the transposed matrix
        public static void DisplayResult(int[, ] arr2)
        {
            Console.WriteLine("Matrix after transpose: ");
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    Console.WriteLine(arr2[i,j] + " ");
                    Console.WriteLine();
                }
            }
        }

        //// Main Method 
        //static public void Main()
        //{
        //    // declaration of an 2-d array 
        //    int[,] arr;
        //    // initialzing 2-D array 
        //    // matrix of 4 rows and 4 colums 
        //    arr = new int[4, 4]{ { 1, 2, 3, 4},
        //                     { 5, 6, 7, 8},
        //                     {9, 10, 11, 12},
        //                     {13, 14, 15, 16} };

        //    Console.WriteLine("Matrix Before Transpose: ");
        //    for (int i = 0; i < arr.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < arr.GetLength(1); j++)
        //            Console.Write(arr[i, j] + " ");
        //        Console.WriteLine();
        //    }

        //    Console.WriteLine();
        //    // calling transpose method 
        //    transpose(arr);
        //    // calling displayresult method  
        //    // to display the result 
        //    displayresult(arr);
        //}
        #endregion

        #region Return Array Difference
        public string[] GetTreeNameArray()
        {
            // Put 3 tree names in the array and return it
            string[] arr3 = { "Elm", "Oak", "Palm" };
            return arr3;
        }

        //static void Main()
        //{
        //    // Get tree array, and merge its results into a single string.
        //    string result = string.Join("; ", GetTreeNameArray());
        //    // Write the tree names.
        //    Console.WriteLine("TREES: {0}", result);
        //}
        #endregion

        #region Foreach using string Interpolation to display result
        public void ReturnResult(string[] arr4)
        {
              foreach (string color in arr4)
                {
                Console.WriteLine($"Color = {color}");
                }
              // then initialize the array in Main and call this method
        }
        #endregion

        #region Array.IndexOf
        public void UseIndexOf()
        {
            string[] arr5 = { "cat", "dog", "bird", "fish" };
            //the dog string is at index 1
            int dogIndex = Array.IndexOf(arr5, "dog");
            Console.WriteLine(dogIndex);
            // there is no monkey and IndexOf returns -1
            int monkeyIndex = Array.IndexOf(arr5, "monkey");
            Console.WriteLine(monkeyIndex);
        }
        #endregion

        #region Join and Split
        public void UseJoinSplit()
        {
            string[] elements = { "cat", "dog", "fish"};
            Console.WriteLine(elements[0]);
            //..Join strings into a single string
            string joined = string.Join("|", elements);
            Console.WriteLine(joined);



        }
        #endregion
    }

    #region String Array in Class
    public class ArrayDemo
    {
        string[] _elements = { "one", "two2", "three"};
        public string[] Elements { get { return _elements; } }
        public string this[int index] { get { return _elements[index]; } }

        //static void Main()
        //{
        //    // Create new instance with string array.
        //    Test test = new Test();
        //    // Loop over elements with property.
        //    foreach (string element in test.Elements)
        //    {
        //        System.Console.WriteLine(element);
        //    }
        //    // Get first string element.
        //    System.Console.WriteLine(test[0]);
        //}
    }
    #endregion
}
