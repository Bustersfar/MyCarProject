using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CarApp
{
    internal class ElectricCar : Car, ISellable, IInsurable
    {
        private double BatteryCapacity;
        private double KmPerKwh;
        public double BatteryLevel { get; private set; }
      


        public ElectricCar(string brand, string model, int year, string licensePlate, double batteryCapacity, double kmPerKwh, double price) : base(brand, model, year, licensePlate, price)
        {
            BatteryCapacity = batteryCapacity;
            KmPerKwh = kmPerKwh;
            BatteryLevel = batteryCapacity;
            
        }
        public override void UpdateEnergyLevel(double km)
        {
            BatteryLevel -= km / KmPerKwh;
        }
        public void Charge(double kwh)
        {
            BatteryLevel += kwh;
        }

        public string GetSalesSummary()
        {
            return GetCarDetails() + $" - {Price} kr";
        }
        public double GetInsuranceRate()
        {
            return 3.5;
        }
    }
}
