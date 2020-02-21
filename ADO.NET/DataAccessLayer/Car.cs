using System.Collections.Generic;

namespace DataAccessLayer
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<object> Details { get; set; }
    }
}
