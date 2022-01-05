using System;

namespace assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {

            int input = 0;
            string resetAnswer = "Null";
            bool validInput = false;

            bool validInputReset = false;
            bool finalValidInput = false;

            while (validInputReset == false)
            {
                finalValidInput = false;
                while (validInput == false)
                {
                    try
                    {
                        input = int.Parse(Console.ReadLine());
                        if (input > 0 && input < 4)
                        {
                            validInput = true;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid number to choose a function. Thank you!");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a valid number to choose a function. Thank you!");
                    }
                }

                switch (input)
                {

                     

                    case 1:
                        Console.Clear();
                        Console.WriteLine("Please enter a word.");
                        Console.WriteLine(MakeFirstLetterInStringUpperCase(Console.ReadLine()));
                        Console.WriteLine("\nThis is the end of the current Function. Would you like to test another function? Please write Y or N");
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Please enter a sentence.");
                        Console.WriteLine(MakeWordsInSentenceUpperCase(Console.ReadLine()));
                        Console.WriteLine("\nThis is the end of the current Function. Would you like to test another function? Please write Y or N");
                        break;

                    default:
                        break;
                }




                while (finalValidInput == false)
                {
                    resetAnswer = Console.ReadLine();
                    try
                    {
                        if (resetAnswer.Equals("Y"))
                        {
                            finalValidInput = true;
                            validInput = false;
                            Console.Clear();
                            Console.WriteLine("What would you like to test next?\n" +
                                              "1. Takes a word and prints it with its first letter in upper case." + "\n" +
                                              "2. Takes a whole sentence and prints it with each word starting with a capital letter." + "\n");
                        }
                        else if (resetAnswer.Equals("N"))
                        {
                            validInputReset = true;
                            finalValidInput = true;
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("Please enter Y or N. ");
                        }
                    }
                    catch
                    {

                    }
                }
            }
        }

        private static string MakeFirstLetterInStringUpperCase(string input)
        {
            if (input.Length == 0)
            {
                return "An empty input was given.";
            }
            string result = char.ToUpper(input[0]) + input.Substring(1);

            return result;
        }

        private static string MakeWordsInSentenceUpperCase(string input)
        {
            if (input.Length == 0)
            {
                return "Given sentence is empty.";
            }
            string[] arrayOfWords = input.Split(' ');

            for (int i = 0; i < arrayOfWords.Length; i++)
            {
                arrayOfWords[i] = MakeFirstLetterInStringUpperCase(arrayOfWords[i]);
            }

            string result = string.Join(" ", arrayOfWords);

            return result;
        }

    }

}