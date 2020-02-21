using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IDetailRepositoy
    {
        bool Delete(int id);
        bool Create(Detail detail);
        bool Update(Detail detail);
        IEnumerable<Detail> GetDetails();
    }
}
