using System;
using System.Collections.Generic;
using System.Text;

namespace CarApp
{
    public class Trip
    {
        private double _distance;
        private DateTime _tripDate;
        private DateTime _startTime;
        private DateTime _endTime;
        private Car _car;
        public double Distance { get { return _distance; } }
        public DateTime TripDate { get { return _tripDate; } }
        public DateTime StartTime { get { return _startTime; } }
        public DateTime EndTime { get { return _endTime; } }
        public Car Car { get { return _car; }
    }

    public Trip(Car car, double distance, DateTime startTime, DateTime endTime)
        {
            _distance = distance;
            _tripDate = startTime;
            _startTime = startTime;
            _endTime = endTime;
            _car = car;
        }
        public TimeSpan CalculateDuration() {
            TimeSpan duration = _endTime - _startTime;
            return duration;
        }
            public double CalculateFuelUsed() {
                double fuelUsed = _distance / _car.KmPerLiter;
                return fuelUsed;
            }
    
            public double CalculateTripCost(double literPrice) {
                double fuelUsed = CalculateFuelUsed();
                double tripCost = fuelUsed * literPrice;
                return tripCost;
        }
    }
    
}
