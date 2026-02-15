using System.Reflection;

namespace CarApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast bilmærke: ");
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
            Console.WriteLine($"{carBrand.PadRight(15)}|{carModel,-15}|{(carManufactoredYear.ToString()).PadRight(7)}|{(carMileage.ToString()).PadLeft(7)} km");
            //Stringpadding på forskellige måder. Et negativt tal betyder venstrestillet
        }
    }
}
