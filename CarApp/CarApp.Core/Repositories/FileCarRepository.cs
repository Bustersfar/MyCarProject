// FileCarRepository.cs

using CarApp.Core.Models;


namespace CarApp.Core.Repositories;



public class FileCarRepository : ICarRepository

{

    public string FilePath { get; set; }


    public FileCarRepository(string filePath)

    {

        FilePath = filePath;

        if (!File.Exists(FilePath))

            File.WriteAllText(FilePath, string.Empty);

    }


    public IEnumerable<Car> GetAll()

    {

        List<Car> cars = new List<Car>();

        using (StreamReader sr = new StreamReader(FilePath))

        {

            string line;

            while ((line = sr.ReadLine()) != null)

            {

                if (string.IsNullOrEmpty(line)) continue;

                string type = line.Split(',')[0];

                if (type == "FuelCar")

                    cars.Add(FuelCar.FromString(line));

                else if (type == "ElectricCar")

                    cars.Add(ElectricCar.FromString(line));

            }

        }

        return cars;

    }


    public Car GetByLicensePlate(string licensePlate)

    {

        return GetAll().FirstOrDefault(

        c => c.LicensePlate == licensePlate);

    }


    public void Add(Car car)

    {

        using (StreamWriter sw = new StreamWriter(FilePath, append: true))

        {

            sw.WriteLine(car.ToString());

        }

    }


    public void Update(Car car)

    {

        List<Car> cars = GetAll().ToList();

        int index = cars.FindIndex(

        c => c.LicensePlate == car.LicensePlate);

        if (index != -1)

        {

            cars[index] = car;

            RewriteFile(cars);

        }

    }


    public void Delete(string licensePlate)

    {

        List<Car> cars = GetAll().ToList();

        cars.RemoveAll(c => c.LicensePlate == licensePlate);

        RewriteFile(cars);

    }


    private void RewriteFile(List<Car> cars)

    {

        using (StreamWriter sw = new StreamWriter(FilePath))

        {

            foreach (Car car in cars)

                sw.WriteLine(car.ToString());

        }

    }

}
