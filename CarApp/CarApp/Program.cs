
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
            FuelCar fc = new FuelCar("Toyota", "Corolla", 2022, "AB12345", 50, 18, 45000); 
            ElectricCar ec = new ElectricCar("Tesla", "Model 3", 2023, "CD67890", 75, 6.5, 380000);
            House h = new House("Strandvejen 42, 2900 Hellerup", 1965, 4200000, "1234-AB");
            List<ISellable> forSale = new List<ISellable> { fc, ec, h };
            List<IInsurable> insured = new List<IInsurable> { fc, ec, h };


            foreach (ISellable s in forSale) 
            { 
                Console.WriteLine(s.GetSalesSummary());
            }
            // Beregn samlet salgspris
                double total = 0; 
            foreach (ISellable s in forSale) 
                total += s.Price; 
                
            Console.WriteLine($"\nSamlet beholdningsværdi: {total:N0} kr\n");

             
            foreach (IInsurable i in insured) Console.WriteLine($"{i.RegistrationNumber}: {i.GetInsuranceRate():F1}%");
            double mean = 0;
            foreach (IInsurable i in insured) {
                mean += i.GetInsuranceRate();
            }
            mean = mean / insured.Count();

            Console.WriteLine($"\nGennemsnitlig forsikringsrate: {mean:F1}%");

            



            /*FuelCar fuelCar = new FuelCar("Toyota", "Corolla", 2020, "AB12345", 50.0, 18.0); ElectricCar electricCar = new ElectricCar("Tesla", "Model 3", 2022, "EL99999", 75.0, 6.5);

            fuelCar.TurnOnEngine();
            electricCar.TurnOnEngine();
            Trip trip1 = new Trip(fuelCar, 80, DateTime.Now, DateTime.Now.AddHours(1));
            Trip trip2 = new Trip(electricCar, 60, DateTime.Now, DateTime.Now.AddHours(1));
            fuelCar.Drive(trip1);
            electricCar.Drive(trip2);
            Console.WriteLine($"FuelCar odometer: {fuelCar.Odometer} km");
            Console.WriteLine($"Fuel level: {fuelCar.FuelLevel:F1} L");
            Console.WriteLine($"ElectricCar odometer: {electricCar.Odometer} km");
            Console.WriteLine($"Battery level: {electricCar.BatteryLevel:F1} kWh");

            List<Car> cars = new List<Car>();
            cars.Add(new FuelCar("Toyota", "Corolla", 2020, "AB12345", 50.0, 18.0));
            cars.Add(new ElectricCar("Tesla", "Model 3", 2022, "EL99999", 75.0, 6.5));
            foreach (Car car in cars)
            {
                car.TurnOnEngine(); 
                Trip trip = new Trip(car, 60, DateTime.Now, DateTime.Now.AddHours(1)); 
                car.Drive(trip); 
                Console.WriteLine($"{car.Brand} odometer: {car.Odometer} km");
            } */
        }
    }
}