using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_March2020
{
    class DataTypes
    {
        //1
        public void DisplayLettersInReverse()
        {
            Console.WriteLine("Please enter first letter: ");
            char first = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Please enter second letter: ");
            char second = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Please enter third letter: ");
            char third = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"{third}{second}{first}");
        }

        //2
        public void DisplayNumberWidth()
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            int height = width;
            for (int row = 0; row < height; row++)
            {
                for (int column = 0; column < width; column++)
                {
                    Console.Write(n);
                }
                Console.WriteLine();
                width--;
            }
        }

        //3
        public void Login()
        {
            string userID, password;
            int counter = 0, dd = 0;
            do
            {
                Console.WriteLine("Input a username: ");
                userID = Console.ReadLine();

                Console.WriteLine("Input a password: ");
                password = Console.ReadLine();
                if (userID == "username" && password == "password")
                {
                    dd = 1; counter = 3;
                }
                else
                {
                    dd = 0; counter++;
                }
            } while ((userID != "username" || password != "password") && counter != 3);
            if (dd == 0)
            {
                Console.WriteLine("\nLogin attempt more than three times.");
            }
            else if (dd == 1)
            {
                Console.WriteLine("\nPassword entered successfull!\n\n");
            }

        }

        //4
        public static float Calculator()
        {

            float result = 0;
            char operation;
            Console.WriteLine("Enter the first number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the operation : \n+ \n- \n* \n/ \nx");
            operation = Convert.ToChar(Console.ReadLine());
            if (operation == '+')
            {
                return result = n1 + n2;
            }
            else if (operation == '-')
            {
                return result = n1 - n2;
            }
            else if (operation == '*')
            {
                return result = n1 * n2;
            }
            else if (operation == '/')
            {
                return result = (float)n1 / (float)n2;
            }
            else if (operation == 'x')
            {
                return result = n1 * n1;
            }
            else
            {
                return result = float.Parse("Nada");
            }

        }

        //5
        public void CalculateAreaPerimeter()
        {
            Console.WriteLine("Please enter the radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());
            const double PI = 3.14;
            double area = PI * radius * radius;
            double perimeter = 2 * PI * radius;
            Console.WriteLine($"Area of the circle is: {Math.Round(area)}");
            Console.WriteLine("Perimeter of the circle is: {0} ", perimeter);
        }

        //6
        public void Ecuation()
        {
            int x, y;
            for (y = -5; y <= 5; y++)
            {
                x = y * y - 2 * y + 1;
                Console.WriteLine("For y = {0}, x = {1}", y, x);
            }

        }

        //7
        public void DistanceAndTime()
        {
            Console.WriteLine("Please enter the distance (meters): ");
            float distance = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Please enter time (hour): ");
            float hour = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Please enter time (minutes): ");
            float minute = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Please enter time (seconds): ");
            float second = Convert.ToSingle(Console.ReadLine());

            float timeSec = (hour * 3600) + (minute * 60) + second;
            float mps = distance / timeSec;
            float kph = (distance / 1000) / (timeSec / 3600);
            float mph = kph / 1.609f;

            Console.WriteLine($"Your speed in meters/sec is: {mps}");
            Console.WriteLine("Your speed in km/h is {0}", kph);
            Console.WriteLine($"Your speed in miles/h is {mph}");
        }

        //8
        public void VolumeAndArea()
        {
            float radius;
            const float PI = 3.1415926535f;

            Console.Write("Please enter the radius of the sphere: ");
            radius = Convert.ToSingle(Console.ReadLine());

            float volume = 4f / 3f * PI * ((float)Math.Pow(radius, 3));
            float area = 4 * PI * radius * radius;
            Console.WriteLine($"The volume of the sphere is: {volume}");
            Console.WriteLine($"The surface of the sphere is: {area}");
        }

        //9
        public void CheckVowelDigitSymbol()
        {
            Console.WriteLine("Please enter a character: ");
            char guessWho = Convert.ToChar(Console.ReadLine());
            if (guessWho == 'a' || guessWho == 'e' || 
                guessWho == 'i' || guessWho == 'o' || guessWho == 'u')
            {
                Console.WriteLine("The char enetered is a vowel");
            }
            else if ((guessWho >= '0') && (guessWho <= '9'))
            {
                Console.WriteLine("The char entered is a digit");
            }
            else
            {
                Console.WriteLine("It's another symbol");
            }
        }

        //10
        public bool EvenOrOdd()
        {
            Console.WriteLine("Enter the first number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 % 2 == 0 && n2 % 2 == 0)
            {
                return true;
            }
            else if (n1 % 2 != 0 && n2 % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //11
        public void ConvertToBinary()
        {
            string answer, result;

            Console.WriteLine("Input a number: ");
            answer = Console.ReadLine();

            int num = Convert.ToInt32(answer);
            result = "";
            while (num > 1)
            {
                int remainder = num % 2;
                result = Convert.ToString(remainder) + result;
                num /= 2;
            }
            result = Convert.ToString(num) + result;
            Console.WriteLine("Binary: {0}", result);
        }
    }
}
