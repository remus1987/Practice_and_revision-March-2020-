using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice_March2020
{
    class W3_BasicAlgorithms
    {
        //3
        public bool Check2Integers()
        {
            Console.WriteLine("Enter 1st integer");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd integer");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 == 30 || num2 == 30 || num1 + num2 == 30)
            {
                if (num1 == 30)
                {
                    Console.WriteLine("1st number equals 30");
                }
                else if (num2 == 30)
                {
                    Console.WriteLine("2nd number equals 30");
                }
                else
                {
                    Console.WriteLine($"The sum of both numbers is {num1 + num2}");
                }
                return true;
            }
            return false;
        }

        //4 
        public bool CheckIntRange(int num)
        {
            // Check if the value within 10 closest of 100 or 200
            if (Math.Abs(num - 100) <= 10 || Math.Abs(num - 200) <= 10)
            {
                return true;
            }
            return false;
        }

        //6
        public string RemCharAtPosition(string str, int n)
        {
            return str.Remove(n, 1);
        }

        //8
        public string Str4Copies(string str)
        {
            // shorter version with ternary conditional operator
            //return str.Length < 2 ? str : str.Substring(0, 2) + str.Substring(0, 2) + str.Substring(0, 2) + str.Substring(0, 2);

            if (str.Length < 2)
            {
                return str;
            }
            return str.Substring(0, 2) + str.Substring(0, 2) + str.Substring(0, 2) + str.Substring(0, 2);
        }

        //9
        public string CreateNewString1(string str)
        {
            return str.Length < 1 ? str : str.Substring(0, 1) + str + str.Substring(str.Length - 1, 1);
            //or
            //var s = str.Substring(str.Length - 1, 1);
            //return s + str + s;
        }

        //14
        public static bool Check2IntRange(int num1, int num2)
        {
            // shorter version
            // return (num1 >= 100 && num1 <= 200) || (num2 >= 100 && num2  <= 200);
            if (num1 >= 100 & num1 <= 200 || num2 >= 100 & num2 <= 200)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //15
        public bool Check3IntRange(int num1, int num2, int num3)
        {
            return (num1 >= 20 && num1 <= 50) || (num2 >= 20 && num2 <= 50)
                 || (num3 >= 20 && num3 <= 50);
        }

        //18
        public int CheckLargestInteger(int n1, int n2, int n3)
        {
            // shorter version using Math.Max
            var max = Math.Max(n1, Math.Max(n2, n3));
            return max;

            //if (n1 > n2 && n1 > n3)
            //{
            //    return 1;
            //}
            //else if (n2 > n1 && n2 > n3)
            //{
            //    return 2;
            //}
            //else if (n3 > n2 && n3 > n2)
            //{
            //    return 3;
            //}
            //else
            //{
            //    return 0;
            //}
        }

        //19
        public int NearestIntegerToValue(int n1, int n2)
        {
            const int n = 100;
            var absN1 = Math.Abs(n1 - n);
            var absN2 = Math.Abs(n2 - n);
            if (absN1 < absN2)
            {
                return n1;
            }
            return n2;
        }

        //22
        public static bool CheckStringZ(string str)
        {
            int ctr = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'z')
                {
                    ctr++;
                }
            }
            return ctr > 1 && ctr < 4;
        }

        //23
        public bool CheckIntLastDigit(int n1, int n2)
        {
            return Math.Abs(n1 % 10) == Math.Abs(n2 % 10);
        }

        //24
        public string Convert2UpperStr(string str)
        {
            string substr1 = str.Substring(str.Length - 3, 3);
            string last3Upper = substr1.ToUpper();
            string substr2 = str.Remove(str.Length - 3, 3) + last3Upper;
            return substr2;
        }

        //25
        public string NCopiesOfAString(string str, int n)
        {
            string result = String.Empty;
            for (int i = 0; i < n; i++)
            {
                result += str;
            }
            return result;
        }

        //27
        #region count the string "aa" in a given string and assume "aaa" contains two "aa"
        public int CountStringChars(string s)
        {
            int counter_aa = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s.Substring(i, 2) == "aa")
                {
                    counter_aa++;
                }
            }
            return counter_aa;
        }
        #endregion

        //28
        public bool IfConsecutiveChars(string s)
        {
            var counter = 0;
            for (int i = 0; i < s.Length-1; i++)
            {
                if (s[i].Equals('a')) counter++;
                if (s.Substring(i, 2).Equals("aa") && counter < 2)
                    return true;
            }
            return false;
        }

        //29
        public string StringManipulation2(string s)
        {
            var result = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 == 0)
                {
                    result += s[i];
                }
            }
            return result;
        }

        //30
        public string NewStringPattern(string s)
        {
            var result = string.Empty;
            for (var i = 0; i < s.Length; i++)
            {
                result += s.Substring(0, i + 1);
            }
            return result;
        }
    }
}
