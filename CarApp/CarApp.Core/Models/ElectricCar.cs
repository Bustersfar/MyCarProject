using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CarApp.Core.Models
{
    public class ElectricCar : Car
    {
        public double BatteryCapacity { get; set; }
        public double KmPerKwh { get; set; }
        public double BatteryLevel { get; set; }

        public ElectricCar(string brand, string model, int year, string licensePlate, double price, double batteryCapacity, double kmPerKwh) : base(brand, model, year, licensePlate, price)
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

        public override string ToString()

        {
            return $"ElectricCar,{Brand},{Model},{Year},{LicensePlate},{Price},{BatteryCapacity},{KmPerKwh}";
        }
        public static ElectricCar FromString(string data)

        {

            string[] parts = data.Split(',');

            return new ElectricCar(

            brand: parts[1],

            model: parts[2],

            year: int.Parse(parts[3]),

            licensePlate: parts[4],

            price: double.Parse(parts[5]),

            batteryCapacity: double.Parse(parts[6]),

            kmPerKwh: double.Parse(parts[7])
            );
        }

        public string GetSalesSummary()
        {
            return GetCarDetails();
        }
        public double GetInsuranceRate()
        {
            return 3.5;
        }
    }
}
