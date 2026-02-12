using System.Reflection;

namespace CarApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.Write("Indtast bilmærke: ");
            string brand = Console.ReadLine();
            Console.Write("Indtast bilmodel: ");
            string model = Console.ReadLine();
            Console.Write("Indtast årgang: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Indtast geartype (A for automatisk, M for manuel: ");
            char gearType = Console.ReadLine()[0];

            Console.WriteLine("Bilmærke: " + brand);
            Console.WriteLine("Bilmodel: " + model);
            Console.WriteLine("Årgang: " + year);
            Console.WriteLine("Gear: " + gearType);
            Console.WriteLine($"\n{brand} {model} fra {year} har gear {gearType}."); */
            
            Console.Write("Indtast brændstoftype (D for diesel, B for benzin: ");
            char fuelType = Console.ReadLine()[0];
            Console.Write("Indtast Km/l: ");
            int kml = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kilometerstand: ");
            double mileage = double.Parse(Console.ReadLine());
            double gasPrice = 13.49; // Eksempel på benzinpris pr. liter
            double dieselPrice = 12.29; // Eksempel på dieselpris pr. liter
            Console.Write("Indtast distance: ");
            double distance = double.Parse(Console.ReadLine());
            double fuelNeeded = distance / kml; // Beregn brændstofbehovet
            double totalCost = 0;
            if (fuelType == 'B' || fuelType == 'b')
            {
                totalCost = fuelNeeded * gasPrice;
            }
            else
            {
                totalCost = fuelNeeded * dieselPrice;
            }
            Console.WriteLine($"Brændstoforbrug for {distance} km: {fuelNeeded} liter");
            Console.WriteLine("Brændstoftype: " + fuelType);
            Console.WriteLine("Km/l: " + kml);
            Console.WriteLine("Oprindelig kilometerstand: " + (int)mileage);
            mileage += distance; // Opdater kilometerstanden
            Console.WriteLine("Ny kilometerstand: " + (int)mileage);
            Console.WriteLine($"Brændstofomkostninger {totalCost:C}");
        }
    }
}
