using System;
using System.Collections.Generic;
using System.Text;

namespace CarApp
{
    using System;

    public class Car
    {
        private string _brand; // implementeret attributter
        private string _model;
        private int _year;
        private string _licensePlate;
        private enum _fuelType;
        private int _odometer = 0;
        private bool _isEngineOn = false;
        private double _kmPerLiter;
        private List<Trip> _trips = new List<Trip>();

        public string Brand { get { return _brand; } } // oprettet get (uden set) metoder - gør det muligt at hente og ( set ville opdatere)  bilens oplysninger uden at man kan ændre den direkte

        public string Model { get { return _model; } }

        public int Year { get { return _year; } }

        public string LicensePlate { get { return _licensePlate; } }

        public int Odometer { get { return _odometer; } }

        public bool IsEngineOn { get { return _isEngineOn; } }

        public double KmPerLiter { get { return _kmPerLiter; } }

        public FuelType FuelType { get; private set; }



        public Car(string Brand, string Model, int Year, string LicensePlate, FuelType fuelType, double KmPerLiter) //konstruktør
        {
            _brand = Brand; //hører sammen med konstruktør 
            _model = Model;
            _year = Year;
            _licensePlate = LicensePlate;
            FuelType = fuelType;
            _kmPerLiter = KmPerLiter;
        }
        //metoderne starter her: 

        public void TurnOnEngine()
        {
            if (!_isEngineOn)
            {
                _isEngineOn = true;
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

        //drive metode: 

        public void Drive(Trip newTrip)

        {
            if (newTrip.Car == this)
            {
                _odometer += (int)newTrip.Distance;
                _trips.Add(newTrip);
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

    }
}




