using DataAccessLayer;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic
{
    public class DetailService : IDetailService
    {
        IDetailRepositoy detailRepository = new DetailReposytory();

        public IEnumerable<DetailModel> GetDetails()
        {
            var detailModels = from detail in detailRepository.GetDetails()
                            select new DetailModel() { Id = detail.Id, Name = detail.Name };
            
            return detailModels;
        }
    }
}
