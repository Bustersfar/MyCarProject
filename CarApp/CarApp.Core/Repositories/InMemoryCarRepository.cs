
using CarApp.Core.Models;


namespace CarApp.Core.Repositories;



public class InMemoryCarRepository : ICarRepository
    {
        private readonly List<Car> _cars = new List<Car>();


        public IEnumerable<Car> GetAll()

        {

            return _cars;

        }


        public Car GetByLicensePlate(string licensePlate)

        {

            return _cars.FirstOrDefault(c => c.LicensePlate == licensePlate);

        }


        public void Add(Car car)

        {

            _cars.Add(car);

        }


        public void Update(Car car)

        {

            var existingCar = _cars.FirstOrDefault(c => c.LicensePlate == car.LicensePlate);
            if (existingCar != null)
            {
                for (int i = 0; i < _cars.Count; i++) // i starter på 0 (første bil), og kører til vi har været igennem alle biler i listen
                {
                    if (_cars[i].LicensePlate == existingCar.LicensePlate)
                    {
                        _cars[i] = existingCar;
                        return; // Stop loopet når bilen er fundet og opdateret
                    }
                }
            }

        }


        public void Delete(string licensePlate)

        {

            _cars.RemoveAll(c => c.LicensePlate == licensePlate);
        }

    }
