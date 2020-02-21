using System.Collections.Generic;

namespace BusinessLogic
{
    public interface IDetailService
    {
        IEnumerable<DetailModel> GetDetails();
    }
}
