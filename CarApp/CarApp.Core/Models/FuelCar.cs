using System;
using System.Collections.Generic;
using System.Text;

namespace CarApp.Core.Models
{
    public class FuelCar : Car
    {
        public double TankCapacity {  get; set; }
        public double KmPerLiter { get; set; }
        public double FuelLevel { get; set; }



        public FuelCar(string brand, string model, int year, string licensePlate, double price, double tankCapacity, double kmPerLiter) : base(brand, model, year, licensePlate, price) 
        { 
            TankCapacity = tankCapacity; 
            KmPerLiter = kmPerLiter; 
            FuelLevel = tankCapacity;
        }

        public override void UpdateEnergyLevel(double km)
        {
            FuelLevel -= km / KmPerLiter;
        }

        public void Refuel(double liters)
        {
            FuelLevel += liters;
        }

        public override string ToString()
        {
            return $"FuelCar,{Brand},{Model},{Year},{LicensePlate},{Price},{TankCapacity},{KmPerLiter}";
        }
        public static FuelCar FromString(string data)

        {

            string[] parts = data.Split(',');

            // parts[0] = "FuelCar" (typen — bruges ikke her)

            // parts[1] = Brand

            // parts[2] = Model

            // parts[3] = Year

            // parts[4] = LicensePlate

            // parts[5] = TankCapacity

            // parts[6] = KmPerLiter

            return new FuelCar(

            brand: parts[1],

            model: parts[2],

            year: int.Parse(parts[3]),

            licensePlate: parts[4],

            price: double.Parse(parts[5]),

            tankCapacity: double.Parse(parts[6]),

            kmPerLiter: double.Parse(parts[7])
            );
        }

        public string GetSalesSummary()
        {
            return GetCarDetails();
        }
        public double GetInsuranceRate()
        {
            return 2.5;
        }
    }
}
