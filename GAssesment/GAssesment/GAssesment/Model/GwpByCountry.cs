﻿using System;
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
        public string variableId { get; set; }
        public string variableName { get; set; }
        public string lineOfBusiness { get; set; }
        public double Y2000 { get; set; }
        public double Y2001 { get; set; }
        public double Y2002 { get; set; }
        public double Y2003 { get; set; }
        public double Y2004 { get; set; }
        public double Y2005 { get; set; }
        public double Y2006 { get; set; }
        public double Y2007 { get; set; }
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
