﻿using System.Collections.Generic;

namespace BusinessLogic
{
    public class CarModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<DetailModel> Details { get; set; }
    }
}
