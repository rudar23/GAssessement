using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GAssesment.Model
{
    public class InputData
    {
        public string country { get; set; }
        public IList<LineofBusiness>  lineofBusinesses { get; set; }
    }
}
