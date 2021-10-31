using System;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("**Welcome!**  \n\nPS.)" + "\n\n\n" +
                "Please type the coresponding number of the function you want to test:" + "\n\n" +
                "1. Temperature conversion from Fahrenheit to Celsius." + "\n" +
                "2. Temperature conversion from Celsius to Fahrenheit." + "\n" +
                "3. Temperature comparison between Fahrenheit and Celsius." + "\n" +
                "4. Fuel conversion from  Miles per Gallon to Litres per 100 Km." + "\n" +
                "5. Fuel conversion from Litres per 100 Km to Miles per Gallon. \n");

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
                    NewMethod(ref input, ref validInput);
                }

                switch (input)
                {

                    case 1:
                        temperatureFtoC();
                        Console.WriteLine("\nThis is the end of the current Function. Would you like to test another function? Please write YES or NO");
                        break;
                    case 2:
                        temperatureCtoF();
                        Console.WriteLine("\nThis is the end of the current Function. Would you like to test another function? Please write YES or NO");
                        break;
                    case 3:
                        compareTemp();
                        Console.WriteLine("\nThis is the end of the current Function. Would you like to test another function? Please write YES or NO");
                        break;
                    case 4:
                        fuelConsumptionMpGtoEU();
                        Console.WriteLine("\nThis is the end of the current Function. Would you like to test another function? Please write YES or NO");
                        break;
                    case 5:
                        fuelConsumptionEUtoMpG();
                        Console.WriteLine("\nThis is the end of the current Function. Would you like to test another function? Please write YES or NO");
                        break;

                    default:
                        break;
                }




                while (finalValidInput == false)
                {
                    resetAnswer = Console.ReadLine();
                    try
                    {
                        if (resetAnswer.Equals("YES"))
                        {
                            finalValidInput = true;
                            validInput = false;
                            Console.WriteLine("What would you like to test next?");
                        }
                        else if (resetAnswer.Equals("NO"))
                        {
                            validInputReset = true;
                            finalValidInput = true;

                            Console.WriteLine("**Thank you !**");
                        }
                        else
                        {
                            Console.WriteLine("Please enter YES or NO. The answer is case-sensitive! Thank you!");
                        }
                    }
                    catch
                    {

                    }
                }
            }
        }

        private static void NewMethod(ref int input, ref bool validInput)
        {
            try
            {
                input = int.Parse(Console.ReadLine());
                if (input > 0 && input < 6)
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

        private static void temperatureFtoC()
        {
            bool validInput = false;
            double temp = 0;
            Console.WriteLine("Please enter temperature in Fahrenheit:");
            while (validInput == false)
            {
                try
                {

                    temp = double.Parse(Console.ReadLine());

                    Console.WriteLine("Temperature in Celsius would be: {0:0.00} C.", (temp - 32) * 0.5556);
                    validInput = true;
                }
                catch
                {

                    Console.WriteLine("Please enter a valid temperature in Fahrenheit! (example: 70,70)");

                }
            }
        }

        private static void temperatureCtoF()
        {
            bool validInput = false;
            double temp = 0;
            Console.WriteLine("Please enter temperature in Celsius:");
            while (validInput == false)
            {
                try
                {
                    temp = double.Parse(Console.ReadLine());
                    Console.WriteLine("Temperature in Fahrenheit would be: {0:0.00} F.", (temp * 1.8 + 32));
                    validInput = true;
                }
                catch
                {

                    Console.WriteLine("Please enter a valid temperature in Celsius! (example: 70,70)");

                }
            }

        }


        private static void compareTemp()
        {
            bool validInputF = false;
            bool validInputC = false;

            double tempC = 0;
            double tempF = 0;

            Console.WriteLine("Please enter temperature in Fahrenheit:");
            while (validInputF == false)
            {
                try
                {
                    tempF = double.Parse(Console.ReadLine());
                    validInputF = true;
                }
                catch
                {
                    Console.WriteLine("Please enter a valid temperature in Fahrenheit!");
                }
            }
            Console.WriteLine("Please enter temperature in Celsius:");

            while (validInputC == false)
            {
                try
                {
                    tempC = double.Parse(Console.ReadLine());
                    validInputC = true;
                }
                catch
                {
                    Console.WriteLine("Please enter a valid temperature in Celsius!");
                }
            }
            double tempToCompare = tempC * 1.8 + 32;

            double tempFtoC = (tempF - 32) * 0.5556;
            double tempCtoF = (tempC * 1.8 + 32);

            if (tempF < tempToCompare)
            {
                Console.WriteLine("Temperature in Celsius is bigger.");
                Console.WriteLine($"Temperature difference in Celsius is: {tempC - tempFtoC:0.00}");
                Console.WriteLine($"Temperature difference in Fahrenheit is: {tempCtoF - tempF:0.00}");
            }
            else if (tempToCompare < tempF)
            {
                Console.WriteLine("Temperature in Fahrenheit is bigger.");
                Console.WriteLine($"Temperature difference in Celsius is: {tempFtoC - tempC:0.00}");
                Console.WriteLine($"Temperature difference in Fahrenheit is: {tempF - tempCtoF:0.00}");
            }
            else
            {
                Console.WriteLine("Both temperatures are equal.");
            }
        }


        private static void fuelConsumptionMpGtoEU() //Miles per Gallons
        {
            double consumptionMpG = 0;

            bool validInput = false;
            Console.WriteLine("Please enter Miles per Gallon consumption:");
            while (validInput == false)
            {
                try
                {
                    consumptionMpG = double.Parse(Console.ReadLine());

                    validInput = true;
                }
                catch
                {

                    Console.WriteLine("Please enter a valid consumption!");

                }
            }

            if (consumptionMpG <= 0)
            {
                Console.WriteLine("Not a valid answer!");
                return;
            }

            //double kmPer1Mile = 1.609;                                                                 
            //double litresPer1Gallon = 3.78;
            //double hundredKMPer1Mile = kmPer1Mile / 100;
            //double finalEquation = hundredKMPer1Mile * litresPer1Gallon;

            double result = 235.214583 / consumptionMpG;
            Console.WriteLine(" The consumption of {0} MpG is  {1:0.0000} L/100Km.", consumptionMpG, result);

        }

        private static void fuelConsumptionEUtoMpG()                             //litres per 100 km
        {
            double consumptionEU = 0;
            bool validInput = false;
            Console.WriteLine("Please enter Litre per 100 Km consumption:");
            while (validInput == false)
            {
                try
                {
                    consumptionEU = double.Parse(Console.ReadLine());

                    validInput = true;
                }
                catch
                {

                    Console.WriteLine("Please enter a valid consumption!");

                }
            }

            if (consumptionEU <= 0)
            {
                Console.WriteLine("Not a valid answer!");
                return;
            }

            double milesPer1KM = 0.621371192;                                   // There are 0.621371192 miles per kilometer and 0.264172052 U.S. Gallons per liter.
                                                                                // We need L/100km, therefore we can multiply 0.621371192 by 100 and then divide the product by 0.264172052 to get the L/100km
            double gallonsPer1Litre = 0.264172052;

            double milesPer100KM = milesPer1KM * 100;

            double finalEquation = milesPer100KM / gallonsPer1Litre;

            double result = finalEquation / consumptionEU;


            Console.WriteLine(" The consumption of {0} L/100Km is {1:0.0000} MpG.", consumptionEU, result);

        }
    }
}