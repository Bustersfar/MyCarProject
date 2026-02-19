using System.Reflection;

namespace CarApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Indtast bilmærke: ");
            string carBrand = Console.ReadLine();
            Console.Write("Indtast bilmodel: ");
            string carModel = Console.ReadLine();
            Console.Write("Indtast bilens årgang: ");
            int carManufactoredYear = int.Parse(Console.ReadLine());
            Console.Write("Indtast bilens geartype (A for automatisk, M for manuel): ");
            char carGearType = Console.ReadLine()[0];
            Console.Write("Indtast hvilken type brændstof bilen bruger (D for diesel, B for benzin): ");
            char carFuelType = Console.ReadLine()[0];
            Console.Write("Indtast hvor mange km bilen kører på en liter: ");
            double carKmL = double.Parse(Console.ReadLine());
            Console.Write("Indtast bilens kilometerstand: ");
            int carMileage = int.Parse(Console.ReadLine());
            Console.Write("Indtast turens længde i km.: ");
            double distanceTraveled = double.Parse(Console.ReadLine());
            double gasPrice = 13.49;
            double dieselPrice = 12.29;
            double fuelUsed = distanceTraveled / carKmL;
            double tripCost = 0;
            // Her er en linie lavet i "Testing-branching
            if (carFuelType == 'B' || carFuelType == 'b')
            {
                tripCost = fuelUsed * gasPrice;
            }
            else
            {
                tripCost = fuelUsed * dieselPrice;
            }
            Console.WriteLine($"\nDin bil kører {carKmL} km på en liter {carFuelType}"); // String interpolation
            Console.WriteLine($"Oprindelig kilometerstand: {carMileage}");
            carMileage += (int)distanceTraveled; // Opdater kilometerstanden: Lav double om til int for at kunne lægge det til en int
            Console.WriteLine($"Ny kilometerstand: {carMileage}");
            Console.WriteLine(string.Format("Brændstofudgifterne for {0} km er {1:C}", distanceTraveled, tripCost)); // String format. {1:C} formaterer tripCost som valuta

            Console.WriteLine($"\n{"Bilmærke".PadRight(15)}|{"Model".PadRight(15)}|{"Årgang".PadRight(7)}|{"Kilometertal".PadLeft(12)}");
            Console.WriteLine("".PadRight(52, '-')); // 52 bindestreger
            Console.WriteLine($"{carBrand.PadRight(15)}|{carModel,-15}|{(carManufactoredYear.ToString()).PadRight(7)}|{(carMileage.ToString()).PadLeft(7)} km");*/
            //Stringpadding på forskellige måder. Et negativt tal betyder venstrestillet

            // Menu

            bool isRunning = true;

            while (isRunning)
            {

                Console.WriteLine("Vælg funktion");
                Console.WriteLine("1. Indtast biloplysninger");
                Console.WriteLine("2. Kør bilen");
                Console.WriteLine("3. Beregn turens pris");
                Console.WriteLine("4. Er kilometerstanden et palindrom?");
                Console.WriteLine("5. Udskriv biloplysninger");
                Console.WriteLine("6. Udskriv alle Team 9's biler");
                Console.WriteLine("7. Afslut program");

                string userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    ReadCarDetails();
                }
                else if (userInput == "2")
                {
                    Drive();
                }
                else if (userInput == "3")
                {
                    CalculateTripPrice();
                }
                else if (userInput == "4")
                {
                    IsPalindrome();
                }
                /* else if (userInput == "5")
                {
                    PrintCarDetails();
                }
                else if (userInput == "6")
                {
                    PrintAllTeamCars();
                } */
                else
                {
                    Console.WriteLine("Programmet lukkes");
                    isRunning = false;
                }
            }

            static void ReadCarDetails()
            {
                Console.WriteLine("Metode 1 ligger her");
            }
            static void Drive()
            {
                Console.WriteLine("Metode 2 ligger her");
            }
            static void CalculateTripPrice()
            {
                Console.WriteLine("Metode 3 ligger her");
            }
            static void IsPalindrome()
            {
                Console.WriteLine("Metode 4 ligger her");
            }

        }
    }
}
