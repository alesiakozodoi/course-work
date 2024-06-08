using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_work.Models
{
     public class University
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public double Rating { get; set; }
        public List<Specialty> Specialties { get; set; }
    }
}
