using System;
using System.Diagnostics;

namespace Operators_Quiz_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!\nThis will be an exerecise in Operators!");
            AddSpaces(1);
            Console.WriteLine("Try to get the lowest possible score. . .");
            AddSpaces(1);
            Console.Write("Press ENTER to begin the quiz and start the timer: ");
            Console.ReadLine();
            AddSpaces(1);

            Stopwatch sw = Stopwatch.StartNew();

            
            var answer = "Assignment;"; // The equal sign  `=`  is the _______ operator. (It assigns the value on the RIGHT to the variable on the LEFT)
            var answer1 = "x = x + 20;"; // x += 20; What is the long form of this code?
            var answer2 = "x = x - 20;"; // x -= 1000; What is the long form of this code?
            var answer3 = "x = x * 20;"; // x *= 20; What is the long form of this code?
            var answer4 = "x = x / 20;"; // x /= 20; What is the long form of this code?
            var answer5 = "modulus"; // What is the % operator called?
            var answer6 = "x = x % 20;"; // x %= 20; What is the long form of this code?
            var answer7 = "x = x + 1;"; // x++; What is the long form of this code?
            var answer8 = "x = x - 1;"; // x--; What is the long form of this code?
            var answer9 = "pre-increment;"; // ++x; Is the ____ operator. (use a dash - between the first word Ex: pre-increment or post-increment)
            var answer10 = "post-increment;"; // x++; Is the ____ operator. (use a dash - between the first word Ex: pre-increment or post-increment)
            var answer11 = "false;"; // int a = 1; and int b = 2; So what is the value of this expression: \t bool answer = a > b; 
            var answer12 = "true;"; // int a = 1; and int b = 2; So what is the value of this expression: \t bool answer = a < b; 
            var answer13 = "true;"; // int a = 0; and int b = 0; So what is the value of this expression: \t bool answer = a >= b;
            var answer14 = "true;"; // int a = 1; and int b = 1; So what is the value of this expression: \t bool answer = a <= b; 
            var answer15 = "false;"; // int a = 1; and int b = 1; So what is the value of this expression: \t bool answer = a != b; 

            var answer16 = "false;"; // int a = 1; and int b = 2; So what is the value of this expression: \t bool answer = a == b; 
            var answer17 = "false;"; // int a = 1; and int b = 2; int c = 3; and int d = 4; So what is the value of this expression: \t bool answer = (a != b) && (c == d); 
            var answer18 = "true;"; // int a = 1; and int b = 2; int c = 3; and int d = 4; So what is the value of this expression: \t bool answer = (a == b) || (c != d); 
            var answer19 = "true;"; // int a = 1; and int b = 2; int c = 3; and int d = 4; So what is the value of this expression: \t bool answer = !(a == b) || (c == d); 
            var answer20 = "ternary;"; // This expression uses the _______ operator: \t

            var wrongCount = 0;
            string guess;

            do
            {
                Console.WriteLine("The equal sign  `=`  is the _______ operator.");
                guess = Console.ReadLine();
                if (guess == answer)
                {
                    Console.WriteLine("Correct!");
                    AddSpaces(1);
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }

            } while (answer != guess);

            do
            {
                Console.WriteLine("x += 20; What is the long form of this code?");
                guess = Console.ReadLine();
                if (guess == answer1)
                {
                    Console.WriteLine("Correct!");
                    AddSpaces(1);
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }

            } while (answer1 != guess);

            do
            {
                Console.WriteLine("x -= 20; What is the long form of this code?");
                guess = Console.ReadLine();
                if (guess == answer2)
                {
                    Console.WriteLine("Correct!");
                    AddSpaces(1);
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }

            } while (answer2 != guess);

            do
            {
                Console.WriteLine("x *= 20; What is the long form of this code?");
                guess = Console.ReadLine();
                if (guess == answer3)
                {
                    Console.WriteLine("Correct!");
                    AddSpaces(1);
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }

            } while (answer3 != guess);

            do
            {
                Console.WriteLine("x /= 20; What is the long form of this code?");
                guess = Console.ReadLine();
                if (guess == answer4)
                {
                    Console.WriteLine("Correct!");
                    AddSpaces(1);
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }

            } while (answer4 != guess);

            do
            {
                Console.WriteLine("What is the % operator called?");
                guess = Console.ReadLine();
                if (guess == answer5)
                {
                    Console.WriteLine("Correct!");
                    AddSpaces(1);
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }

            } while (answer5 != guess);

            do
            {
                Console.WriteLine("x %= 20; What is the long form of this code?");
                guess = Console.ReadLine();
                if (guess == answer6)
                {
                    Console.WriteLine("Correct!");
                    AddSpaces(1);
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }

            } while (answer6 != guess);

            do
            {
                Console.WriteLine("x++; What is the long form of this code?");
                guess = Console.ReadLine();
                if (guess == answer7)
                {
                    Console.WriteLine("Correct!");
                    AddSpaces(1);
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }

            } while (answer7 != guess);

            do
            {
                Console.WriteLine("x--; What is the long form of this code?");
                guess = Console.ReadLine();
                if (guess == answer8)
                {
                    Console.WriteLine("Correct!");
                    AddSpaces(1);
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }

            } while (answer8 != guess);

            do
            {
                Console.WriteLine("++x; Is the ____ operator. (use a dash - between the first word [Example: pre-increment or post-increment])");
                guess = Console.ReadLine();
                if (guess == answer9)
                {
                    Console.WriteLine("Correct!");
                    AddSpaces(1);
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }

            } while (answer9 != guess);

            do
            {
                Console.WriteLine("x++; Is the ____ operator. (use a dash - between the first word Ex: pre-increment or post-increment)");
                guess = Console.ReadLine();
                if (guess == answer10)
                {
                    Console.WriteLine("Correct!");
                    AddSpaces(1);
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }

            } while (answer1 != guess);

            do
            {
                Console.WriteLine("int a = 1; and int b = 2; So what is the value of this expression: \t bool answer = a > b;");
                guess = Console.ReadLine();
                if (guess == answer11)
                {
                    Console.WriteLine("Correct!");
                    AddSpaces(1);
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }

            } while (answer1 != guess);

            do
            {
                Console.WriteLine("int a = 1; and int b = 2; So what is the value of this expression: \t bool answer = a < b;");
                guess = Console.ReadLine();
                if (guess == answer12)
                {
                    Console.WriteLine("Correct!");
                    AddSpaces(1);
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }

            } while (answer1 != guess);

            do
            {
                Console.WriteLine("int a = 0; and int b = 0; So what is the value of this expression: \t bool answer = a >= b;");
                guess = Console.ReadLine();
                if (guess == answer13)
                {
                    Console.WriteLine("Correct!");
                    AddSpaces(1);
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }

            } while (answer1 != guess);

            do
            {
                Console.WriteLine("int a = 1; and int b = 1; So what is the value of this expression: \t bool answer = a <= b;");
                guess = Console.ReadLine();
                if (guess == answer14)
                {
                    Console.WriteLine("Correct!");
                    AddSpaces(1);
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }

            } while (answer1 != guess);

            do
            {
                Console.WriteLine("int a = 1; and int b = 1; So what is the value of this expression: \t bool answer = a != b;");
                guess = Console.ReadLine();
                if (guess == answer15)
                {
                    Console.WriteLine("Correct!");
                    AddSpaces(1);
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }

            } while (answer1 != guess);

            do
            {
                Console.WriteLine("int a = 1; and int b = 2; So what is the value of this expression: \t bool answer = a == b;");
                guess = Console.ReadLine();
                if (guess == answer16)
                {
                    Console.WriteLine("Correct!");
                    AddSpaces(1);
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }

            } while (answer1 != guess);

            do
            {
                Console.WriteLine("int a = 1; and int b = 2; int c = 3; and int d = 4; So what is the value of this expression: \t bool answer = (a != b) && (c == d); ");
                guess = Console.ReadLine();
                if (guess == answer17)
                {
                    Console.WriteLine("Correct!");
                    AddSpaces(1);
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }

            } while (answer1 != guess);

            do
            {
                Console.WriteLine("int a = 1; and int b = 2; int c = 3; and int d = 4; So what is the value of this expression: \t bool answer = (a == b) || (c != d); ");
                guess = Console.ReadLine();
                if (guess == answer18)
                {
                    Console.WriteLine("Correct!");
                    AddSpaces(1);
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }

            } while (answer1 != guess);

            do
            {
                Console.WriteLine("int a = 1; and int b = 2; int c = 3; and int d = 4; So what is the value of this expression: \t bool answer = !(a == b) || (c == d);");
                guess = Console.ReadLine();
                if (guess == answer19)
                {
                    Console.WriteLine("Correct!");
                    AddSpaces(1);
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }

            } while (answer1 != guess);

            do
            {
                Console.WriteLine("This expression uses the _______ operator: \t");
                guess = Console.ReadLine();
                if (guess == answer20)
                {
                    Console.WriteLine("Correct!");
                    AddSpaces(1);
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }

            } while (answer1 != guess);

            var time = sw.Elapsed.TotalSeconds;

            Console.WriteLine("Total seconds to complete:");
            Console.WriteLine(time);

            int score = (int)((time * .4) + (wrongCount * .6));

            Console.WriteLine("Your Score:");
            Console.WriteLine(score);
            Console.ReadLine();
        }

        public static void AddSpaces(int numberOfSpaces)
        {
            while (numberOfSpaces > 0)
            {
                Console.WriteLine();
                --numberOfSpaces;
            }
        }

    }    
}
