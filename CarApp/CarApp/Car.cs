using System;
using System.Collections.Generic;
using System.Text;

namespace CarApp
{
    using System;

    abstract public class Car
    {
        /*private string _brand; // implementeret attributter
        private string _model;
        private int _year;
        private string _licensePlate;
        private enum _fuelType;
        private int _odometer = 0;
        private bool _isEngineOn = false;
        // private double _kmPerLiter;*/
        private List<Trip> _trips = new List<Trip>();

        public string Brand { get; private set; }

        public string Model { get; private set; }

        public int Year { get; private set; }

        public string LicensePlate { get; private set; }

        public string RegistrationNumber { get; private set; }

        public int Odometer { get; protected set; }

        private bool IsEngineOn = false;
        public double Price { get; private set; }







        public Car(string brand, string model, int year, string licensePlate, double price)
        {
            Brand = brand;
            Model = model;
            Year = year;
            LicensePlate = licensePlate;
            RegistrationNumber = licensePlate;
            Price = price;
        }

        public void TurnOnEngine()
        {
            if (!IsEngineOn)
            {
                IsEngineOn = true;
                Console.WriteLine("Motoren er startet.");
            }
            else
            {
                Console.WriteLine("Motoren er allerede i gang.");
            }
        }
        public List<Trip> GetTrips()
        {
            return _trips;
        }

        public void Drive(Trip trip)

        {
            if (trip.Car == this)
            {
                Odometer += (int)trip.Distance;
                UpdateEnergyLevel(trip.Distance);
                _trips.Add(trip);
            }
            else
            {
                Console.WriteLine("Fejl: Denne tur tilhører ikke denne bil.");
            }
        }

        public List<Trip> GetTripsByDate(DateOnly date)
        {
            DateTime dateAsDateTime = new DateTime(date, new TimeOnly(0,0));
            
            List<Trip> dateList = new List<Trip>();
            foreach (Trip trip in _trips)
            {
                if (trip.TripDate.Date == dateAsDateTime.Date)
                {
                    dateList.Add(trip);
                } 
            }
            return dateList;

        }

        public string GetCarDetails() {
            return ($"{Year} {Brand} {Model} [{LicensePlate}]");
        }

        public abstract void UpdateEnergyLevel(double km);

    }
}




