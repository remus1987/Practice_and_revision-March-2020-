using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_March2020
{
    class For_Loop
    {
        //3
        public void DisplayNTermsAndSum(int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += i; 
                Console.Write(" {0}", i);
            }
            Console.WriteLine("\nThe sum of {0} is {1}", n, sum);
        }

        //4
        public void Input10NumFindSumAndAvg()
        {
            int n;
            int sum = 0;
            int avg = 0;
            Console.WriteLine("Please input 10 numbers: ");

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Input {0} number: ", i);
                n = Convert.ToInt32(Console.ReadLine());

                sum += n;
                avg = sum / i;
            }
            Console.WriteLine("The sum of the above 10 numbers is: {0}", sum);
            Console.WriteLine("The average of the 10 munbers is: {0}", avg);
        }

        //5
        public void DisplayCubeUpToInput()
        {
            int n;
            double cube = 0;
            Console.WriteLine("Input a number: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                cube = Math.Pow(i, 3);
                
                Console.Write("Number is: {0}" +
                    " and cube of the {1} is {2}\n", i,i, cube);
            }
            Console.ReadLine();
        }

        //6
        public void MultiplicationTable()
        {
            int n;
            int result;
            Console.WriteLine("Input a number");
            Console.WriteLine("---------------");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                result = n * i;
                Console.Write("{0} x {1} = {2}\n", n, i, result);
            }
        }

        //7
        public void Multiplication1ToN()
        {
            int n, result;
            Console.WriteLine("Input a number: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    result = j * i;
                    Console.Write("{0} x {1} = {2}, ", j, i, result);
                }
                Console.WriteLine("\n");
            }
        }

        //9
        public static void RightAngleStars(int n)
        {
            char star = '*';
            for (int i = 1; i <= n; i++)
            { 
                for (int j = 1; j <= i; j++)
                    Console.Write(star);
                Console.Write("\n");
            }

        }

        //10
        public static void RightAngleNumber()
        {
            int n;
            Console.WriteLine("Input a number");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------");
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.Write("\n");
            }
        }

        //13 ?
        public static void PyramidNumbers()
        {
            int n, spc, t=1;
            Console.WriteLine("Input a number: ");
            n = int.Parse(Console.ReadLine());
            spc = n + n - 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = spc; j >= 1; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("{0} ", t++);
                }
                Console.Write("\n");
                spc--;
            }
        }

        //15
        public static void Factorial()
        {
            int n, factor = 1;
            Console.WriteLine("Input a number: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                factor *= i;
            }
            Console.WriteLine("The factorial of {0} is: {1}", n, factor);
        }

        //18
        public static void SumOfSeries()
        {
            int numberOfTerms;
            double xValue, t, d, sum;
            Console.WriteLine("Input the value of x: ");
            xValue = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input the number of terms: ");
            numberOfTerms = Convert.ToInt32(Console.ReadLine());
            sum = 1; t = 1;

            for (int i = 1; i < numberOfTerms; i++)
            {
                d = (2*i)*(2*i-1);
                t = t * xValue * xValue / d;
                sum = sum + t;
            }
            Console.Write("\nThe sum = {0}\nNumber of terms = {1}\nvalue" +
                " of x = {2}\n", sum, numberOfTerms, xValue);
        }

        //20
        public static void PyramidAsterix()
        {
            int n;
            Console.WriteLine("Please enter the number of asterix at the base: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2*i-1; k++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }

        //22 
        public static void FloydTriangle()
        {
            int n, p, q;
            Console.WriteLine("Input number of rows: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------");

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    p = 1;
                    q = 0;
                }
                else
                {
                    p = 0;
                    q = 1;
                }
                for (int j = 1; j <= i; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write("{0}", p);
                    }
                    else
                    {
                        Console.Write("{0}", q);
                    }
                }
                Console.Write("\n");
            }

        }

        //24
        public void SumOfSeries2()
        {
            double x, sum, ctr, p, term;
            int i, n;

            Console.Write("Input the value of x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input number of terms: ");
            n = Convert.ToInt32(Console.ReadLine());

            term = 1;
            sum = 0;
            for (i = 1, p = 1; i < n+1; i++)
            {
                ctr = Math.Pow(x, p);
                sum = sum + ctr * term;
                term = term * (-1);
                p = p + 2;
            }
            Console.WriteLine("\nThe sum = {0}\nNumber of terms = {1}" +
                "\n The value of x = {2}\n", sum, n, x);
        }

        //27
        public void CheckPerfectNumber()
        {
            int n, sum = 0, i;
            Console.Write("Input a number: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("The positive divisors: ");
            for (i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                    Console.Write("{0}, ", i);
                }
            }
            Console.Write("\nThe sum of the divisor is: {0}. ", sum);
            if (sum == n)
            {
                Console.Write("The number is perfect");
            }
            else
            {
                Console.Write("The number is not perfect");
            }
        }

        //30
        public void Armstrong_Number()
        {
            // the sum of the cube of individual digits is equal to
            //that number
            int n, sum, r, temp;
                int startNo, endNo;
            Console.WriteLine("Input starting number of range: ");
            startNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input ending number of range: ");
            endNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Armstrong number in given range are: ");
            for (n = startNo; n <= endNo; n++)
            {
                temp = n;
                sum = 0;
                while (temp != 0)
                {
                    r = temp % 10;
                    temp = temp / 10;
                    sum = sum + (r * r * r);
                }
                if (sum == n)
                    Console.Write("{0} ", n);
            }
            Console.Write("\n");
        }
    }                          
}
