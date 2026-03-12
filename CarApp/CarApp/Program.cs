
using Microsoft.VisualBasic.FileIO;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CarApp

{
    class Program
    {
        static void Main(string[] args)
        {

            Car myCar = new Car("Toyota", "Corolla", 2020, "AB12345", FuelType.Benzin, 22.5);
            Car myCar2 = new Car("Mazda", "626", 2000, "AB12346", FuelType.Benzin, 12.5);

            myCar.TurnOnEngine();



            List<Trip> trips = new List<Trip>

			{

				new Trip(myCar, 50,  DateTime.Now, DateTime.Now.AddHours(1)),

				new Trip(myCar, 30,  DateTime.Now, DateTime.Now.AddMinutes(30)),

				new Trip(myCar, 100, DateTime.Now, DateTime.Now.AddHours(2)),

				new Trip(myCar2, 100, DateTime.Now, DateTime.Now.AddHours(2))

            };

			foreach (var trip in trips) 
			{ 
				myCar.Drive(trip); 
			}

			List<Trip> carTrips = new List<Trip>();

			DateTime date = DateTime.Now;

			myCar.GetTripsByDate(DateOnly.FromDateTime(date));



            carTrips = myCar.GetTrips();
            foreach (var trip in carTrips) {
				Console.WriteLine("Bilen har kørt " + trip.Distance +" km. Turen varede " + trip.CalculateDuration().Hours + " timer og " + trip.CalculateDuration().Minutes + " minutter");
				Console.WriteLine("Brændstofforbruget for turen var " + trip.CalculateFuelUsed() + " liter, og turen kostede " + trip.CalculateTripCost(13.49) + " kr.\n");
            }



            /*
						Console.WriteLine("Indtast dit bilmærke:");
						string brand = Console.ReadLine();
						Console.WriteLine("Indtast Bilmodel:");
						string model = Console.ReadLine();
						Console.WriteLine("Indtast årgang:");
						int year = Convert.ToInt32(Console.ReadLine());
						Console.WriteLine("Indtast geartype - A for automatikgear M for manuel gear");
						char gearType = Console.ReadLine()[0];
						Console.WriteLine("Hvem ejer bilen");
						string ejer = Console.ReadLine();

						Console.WriteLine("Bilmærke:" + brand);
						Console.WriteLine("Model:" + model);
						Console.WriteLine("Årgang:" + year);
						Console.WriteLine("GearType" + gearType);
						Console.WriteLine("Ejer:" + ejer);

						Console.WriteLine($" Vi når altså frem til at: \n {brand} {model} fra {year} har gear {gearType} og ejes af {ejer}");

						Console.WriteLine("Indtast brændstoftype: D for diesel, B for benzin: ");
						char carFuelType = Console.ReadLine()[0];
						Console.WriteLine("Indtast antal km pr liter brændstof: ");
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

						Console.WriteLine($"\nDin bil kører {carKmL} km på en liter {carFuelType}"); // String interpolation = slip for "" + "" + "", laver det hele i én)
						Console.WriteLine($"Oprindelig kilometerstand: {carMileage}");
						carMileage += (int)distanceTraveled; // Opdater kilometerstanden: (int) Laver double(decimaltal) om til int for at kunne lægge det til en int(heltal)
						Console.WriteLine($"Ny kilometerstand: {carMileage}");
						Console.WriteLine(string.Format("Brændstofudgifterne for {0} km er {1:C}", distanceTraveled, tripCost)); // String format. {1:C} formaterer tripCost som valuta

						//Sætter oplysningerne i skema:

						Console.WriteLine($"\n{"Bilmærke".PadRight(15)}|{"Model".PadRight(15)}|{"Årgang".PadRight(7)}|{"Kilometertal".PadLeft(12)}"); //
						Console.WriteLine("".PadRight(52, '-')); // 52 bindestreger
						Console.WriteLine($"{brand.PadRight(15)}|{model,-15}|{(year.ToString()).PadRight(7)}|{(carMileage.ToString()).PadLeft(7)} km");
						//Stringpadding på forskellige måder. Et negativt tal betyder venstrestillet

						
			string carBrand = "";
			string carModel = "";
			int year = 0;
			int kmTal = 0;



			bool isRunning = true; //så længe det er true og der vælges mellem 1-6 kører vi, vælges der 7 eller derover "Afslut program"

			while (isRunning)
			{

				Console.WriteLine("Vælg funktion");
				Console.WriteLine("1. Indtast biloplysninger");
				Console.WriteLine("2. Er motoren tændt?");
				Console.WriteLine("3. Beregn turens pris");
				Console.WriteLine("4. Er kilometerstanden et palindrom?");
				Console.WriteLine("5. Udskriv biloplysninger");
				Console.WriteLine("6. Udskriv alle Team 9's biler");
				Console.WriteLine("7. Afslut program");
				
								string userInput = Console.ReadLine();

								if (userInput == "1") 
								{
									ReadCarDetails(); //Her kaldes metoden (som ALTID ligger efter if/else)  - hvis bruger trykker 1 hentes der info fra ReadCarDetails
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
								//	IsPalindrome();
								}
								else if (userInput == "5")
								{
								//	PrintCarDetails();
								}
								else if (userInput == "6")
								{
									//PrintAllTeamCars();
								}
								else
								{
									Console.WriteLine("Programmet lukkes");
									isRunning = false; //Alle ifs kan også laves som switch for overskuelighedens skyld 
								}
							}

						}
								*/
        }
    }
}