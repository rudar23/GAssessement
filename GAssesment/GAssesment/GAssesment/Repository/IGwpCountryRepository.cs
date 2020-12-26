using GAssesment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GAssesment.Repository
{
   public interface IGwpCountryRepository 
    {
        //   public IEnumerable<GwpByCountry> GetAlldata();
        public Task<Dictionary<string, double>> GetAvgGrossbyLob(InputData input);
    }
}
