using BusinessLogic;
using System.Collections.Generic;
using System.Linq;

namespace PresentationLayer
{
    public class DetailController : IDetailController
    {
        IDetailService detailService = new DetailService();
        public IEnumerable<DetailViewModel> GetDetails()
        {
            var details = from detail in detailService.GetDetails()
                          select new DetailViewModel() { Id = detail.Id, Name = detail.Name };

            return details;
        }
    }
}
