using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GAssesment.Model
{
    public class GwpCountryContext : DbContext
    {
        public DbSet<GwpByCountry> gwpcountry  { get; set; }

        public GwpCountryContext(DbContextOptions<GwpCountryContext> options) : base(options)
        {
            LoadDefaultData();
        }      

        private void LoadDefaultData()
        {
            GwpByCountry gwpByCountries = new GwpByCountry() { country = "ae", LOB = "transport", variableID = "gwp", VariablName = "Direct Premiums", Y2008 = 268744928.7 };
            gwpcountry.Add(gwpByCountries);

            GwpByCountry gwpByCountries2 = new GwpByCountry() { country = "ao", LOB = "transport", variableID = "gwp", VariablName = "Direct Premiums", Y2008 = 268744928.7 };
            gwpcountry.Add(gwpByCountries2);

            GwpByCountry gwpByCountries3 = new GwpByCountry() { country = "ae", LOB = "property", variableID = "gwp", VariablName = "Direct Premiums", Y2008 = 268744928.7 };
            gwpcountry.Add(gwpByCountries3);

        }
        public async Task<List<GwpByCountry>> GetAll()
        {
            //List<GwpByCountry> gwpByCountries = new List<GwpByCountry>();
            //await Task.Run(() => {
            //    gwpByCountries= gwpcountry.Local.ToList<GwpByCountry>();
            //});
            return gwpcountry.Local.ToList<GwpByCountry>(); ;
        }
        public async Task<List<GwpByCountry>> GetAvgGross(GwpByCountry gwpByCountry)
        {
            List<GwpByCountry> gwpByCountries = new List<GwpByCountry>();
          await  Task.Run(() => {
                gwpByCountries = gwpcountry.Local.Where(x => x.country == gwpByCountry.country && x.LOB == gwpByCountry.LOB).ToList();
            });

            return  gwpByCountries;
        }
    }
}
