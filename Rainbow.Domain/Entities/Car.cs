using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainbow.Domain.Entities
{
    public class Car
    {
        public int CarId { get;private set; }
        public string CarName { get;private set; }
        public string CarType { get; private set; }
        public string CarPrice { get;private set; }
        public string CarDescription { get;private set; }
        public string CarColor { get;private set; }
    }
}
