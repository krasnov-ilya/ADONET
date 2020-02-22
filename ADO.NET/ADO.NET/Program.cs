using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarRepository repository = new CarRepository();

            var cars = repository.GetCars();

            var newCar = new Car { Name = "Igor123" };

            repository.Create(newCar);

            cars = repository.GetCars();

            var lastUserId = cars.Max(x => x.Id);

            newCar.Id = lastUserId;
            newCar.Name = "UpdatedName";

            repository.Update(newCar);

            repository.Delete(lastUserId);
            //Console.WriteLine("Compiled succesfully!");
            Console.ReadKey();
        }
    }
}
