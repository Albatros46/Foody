using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.Entities.Concrete
{
    public class Feature
    {
        public int featureId { get; set; }
        public string TItle { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; } = true;
    }
}
