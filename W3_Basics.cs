using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Linq;

namespace Practice_March2020
{
    class W3_Basics
    {
        List<int> ls = new List<int>();
        Dictionary<int, int> dict = new Dictionary<int, int>();
        //5
        public static void Swap2Numbers(int n1, int n2)
        {
            int temp = n1;
            n1 = n2;
            n2 = temp;
            Console.WriteLine("The numbers are now {0},{1}", n1,n2);
        }
        //6
        public static int Multiply3num ()
        {
            int n1, n2, n3;
            Console.WriteLine("Enter 1st num:");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd num:");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 3rd num:");
            n3 = Convert.ToInt32(Console.ReadLine());

            return n1 * n2 * n3;
            
        }
        //20
        public int AbsDifference(int n1, int n2)
        {
            if (n1 > n2)
            {
                return (n1 - n2) * 2;
            }
            else
            {
                return n1 - n2;
            }
        }
        //31
        public void MultiplyCorespElemOfArray()
        {
            int[] n1 = {1,2,3,4};
            int[] n2 = { 6, 7, 8, 9 };

            Console.WriteLine("\nArray1: [{0}]", string.Join(", ", n1));
            Console.WriteLine("\nArray1: [{0}]", string.Join(", ", n2));

            for (int i = 0; i < n1.Length; i++)
            {
                Console.WriteLine(n1[i]*n2[i]+" ");
            }
            Console.WriteLine("\n");
        }
        //42
        public void LowerUpperCase(string s)
        {
            if (s.Length < 4)
            {
                Console.WriteLine(s.ToUpper());
            }
            else
            {
                Console.WriteLine(s.ToLower());
            }
            
        }
        //53
        public bool CheckForOdd(int[] arr)
        {
            foreach (var n in arr)
            {
                if (n%2 != 0)
                {
                    Console.WriteLine(true);
                }
            }
            return false;
        }
        //62
        public string ReverseStr(string s)
        {
            int lid = s.LastIndexOf("(");
            if (lid == -1)
            {
                return s;
            }
            else
            {
                int rid = s.IndexOf(")", lid);

                return ReverseStr(s.Substring(0, lid)
                    + new string(s.Substring(lid + 1, rid - lid - 1).Reverse().ToArray())
                    + s.Substring(rid + 1)
                    );
            }
        }
        //For Loop 3
        public void NaturalNAndSumN(int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i);
                sum += i;
            }
            Console.WriteLine("The sum of Natural numbers up to {0} is {1}", n, sum);
        }

        #region CollectionChallenge TrainingSparta
        public int ArrayIntoDictionaryGetTotal(int a, int b, int c, int d, int e)
        {

            a += 5;
            b += 5;
            c += 5;
            d += 5;
            e += 5;
            int[] arr = { a, b, c, d, e };
            for (int i = 0; i < arr.Length; i++)
            {
                var item = arr[i] * arr[i];
                ls.Add(item);
            }
            for (int i = 0; i < ls.Count; i++)
            {
                var item2 = ls[i] - 10;
                dict.Add(i, item2);
            }
            return dict.Values.Sum();
        }
        #endregion

        #region FibonacciNumbers
        public int GetFibonacciRec(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return GetFibonacciRec(n - 1) + GetFibonacciRec(n - 2);
            }
        }
        #endregion

        #region GetFactorial WhileLoop
        // Get factorial using while loop
        public int GetFactorial(int n)
        {
            int result = 1;
            while (n != 1)
            {
                result = result * n;
                n -= 1;
            }
            return result;
        }
        #endregion

        #region FizzBuzz
        public void FizzBuzz(int n)
        {
 
            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i %3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                {
                    Console.WriteLine("No Fizz Buzz");
                }
            }
        }
        #endregion

        #region Console ReadKey ex
        //1
        public void ReadKey1 ()
        {
            int c = 0;
            Console.WriteLine("the series is: ");
            for (int i = 0; i < 10; i++)
            {
                c = c + i;
                Console.WriteLine(c+"");
            }
            Console.WriteLine("\npress any key now..");
            //basic use of Console.ReadKey method
            Console.ReadKey();
        }

        //2
        public void ReadKey2 ()
        {
            int c = 0;
            Console.WriteLine("The series is: ");
            for (int i = 0; i<0; i++)
            {
                c = c + i;
                Console.WriteLine(c + " ");
            }
            Console.WriteLine("\nPress 'Enter' to exit please..");
            // another use of Console.ReadKey method
            // here it asks to press the enter key to exit
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {

            }
        }

        //3
        public void ReadKey3 ()
        {
            DateTime d = DateTime.Now;
            // Print the System date and time
            Console.WriteLine("System date: {0:d}\n" + "System time: {0:t}", d);
            Console.WriteLine("Press E to exit the process...");
            // here we ask to press "E" to exit
            while (Console.ReadKey().Key != ConsoleKey.E)
            {

            }
        }
        #endregion

        //14
        public void TemperatureConvertor(int celsius)
        {
            double kelvin, fahrenheit;
            kelvin = celsius + 273.15;
            fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"{celsius} Celsius degrees equals {kelvin} Kelvin degrees");
            Console.WriteLine($"{celsius} Celsius degrees equals {fahrenheit} Fahrenheit degrees");
        }

        //15
        public string RemoveSpecifiedChar()
        {
            Console.WriteLine("Please Enter a string: ");
            string strInput = Console.ReadLine();
            if (strInput != "remus")
            {
                Console.WriteLine("Enter the character number to be removed: ");
                int n = Convert.ToInt32(Console.ReadLine());
                string strOutput = strInput.Remove(n, 1);
                return strOutput;
            }
            else
            {
                return "Empty ! Please enter some string";
            }
            
        }

        #region Sum of the first 500 prime_numbers
        public void SumOf500PrimeNo()
        {
            Console.WriteLine("\nSum of the first 500 prime numbers: ");
            long sum = 0;
            int ctr = 0;
            int n = 2;
            while (ctr < 500)
            {
                if (isPrime(n))
                {
                    sum += n;
                    ctr++;
                }
                n++;
            }
            Console.WriteLine(sum.ToString());
        }
        public static bool isPrime (int n)
        {
            int x = (int)Math.Floor(Math.Sqrt(n));
            if (n == 1) return false;
            if (n == 2) return true;

            for (int i = 2; i <= x; ++i)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        #endregion
    }
}
