using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.Entities.Concrete
{
    public class Review
    {
        public int reviewId { get; set; }
        public string CustomerName { get; set; }
        public string Titel { get; set; }
        public string Comment { get; set; }
        public string ImageUrl { get; set; }
    }
}
