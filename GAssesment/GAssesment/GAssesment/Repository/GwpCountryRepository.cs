using GAssesment.Helper;
using GAssesment.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace GAssesment.Repository
{
    public class GwpCountryRepository : IGwpCountryRepository
    {
        private readonly GwpCountryContext _gwpCountryContext;
        private readonly IGetAverageofLOB _getaverageofLOB;
        public GwpCountryRepository(GwpCountryContext gwpCountryContext, IGetAverageofLOB getAverageofLOB)
        {
            _gwpCountryContext = gwpCountryContext;
            _getaverageofLOB = getAverageofLOB;
        }

        public async Task<Dictionary<string, double>> GetAvgGrossbyLob(InputData input)
        {
            //Load all the data. This will fetch the inmemory data
            var countrydata = await _gwpCountryContext.GetAll();
            //find the data for the specific country
            countrydata = countrydata.Where(x => x.country == input.country).ToList();
            //find the LOB w.r.t input data.
            var result = countrydata.Where(x => input.lineofBusinesses.Any(y => y.lob.Equals(x.lineOfBusiness))).ToList();
            //send the above genererated list to the get the avergae
            var avgofLOB = _getaverageofLOB.Average(result);

            return avgofLOB;
        }


    }
}
