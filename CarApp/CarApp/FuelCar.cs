using System;
using System.Collections.Generic;
using System.Text;

namespace CarApp
{
    internal class FuelCar : Car, ISellable, IInsurable
    {
        public double TankCapacity {  get; private set; }
        public double KmPerLiter { get; private set; }
        public double FuelLevel { get; private set; }
        





        public FuelCar(string brand, string model, int year, string licensePlate, double tankCapacity, double kmPerLiter, double price) : base(brand, model, year, licensePlate, price) 
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

        public string GetSalesSummary()
        {
            return GetCarDetails() + $" - {Price} kr"; ;
        }
        public double GetInsuranceRate()
        {
            return 2.5;
        }
    }
}
