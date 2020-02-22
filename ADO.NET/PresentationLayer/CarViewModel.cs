using System.Collections.Generic;

namespace PresentationLayer
{
    public class CarViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<DetailViewModel> Details { get; set; }
    }
}
