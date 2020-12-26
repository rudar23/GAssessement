using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GAssesment.Model
{
    public class GwpByCountry
    {
        [Key]
        public Guid Id { get; set; }
        public string country { get; set; }
        public string variableID { get; set; }

        public string VariablName { get; set; }
        public string LOB { get; set; }
        public double Y2008 { get; set; }
        public double Y2009 { get; set; }
        public double Y2010 { get; set; }
        public double Y2011 { get; set; }
        public double Y2012 { get; set; }
        public double Y2013 { get; set; }
        public double Y2014 { get; set; }
        public double Y2015 { get; set; }

    }

}
