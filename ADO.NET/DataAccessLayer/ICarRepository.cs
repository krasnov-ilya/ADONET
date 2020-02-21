using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface ICarRepository
    {
        IEnumerable<Detail> GetDetails(int Id);
        IEnumerable<Car> GetCars();
        bool Delete(int id);
        bool Create(Car car);
        bool Update(Car car);

    }
}
