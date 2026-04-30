using CarApp.Core.Models;


namespace CarApp.Core.Repositories;


public interface ICarRepository
{

    public IEnumerable<Car> GetAll();
    public Car GetByLicensePlate (string licensePlate);
    public void Add(Car car);
    public void Update(Car car);
    public void Delete(string licensePlate);
}

