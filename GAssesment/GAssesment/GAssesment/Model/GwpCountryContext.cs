using LumenWorks.Framework.IO.Csv;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GAssesment.Model
{
    public class GwpCountryContext : DbContext
    {
        public DbSet<GwpByCountry> gwpcountry { get; set; }

        public GwpCountryContext(DbContextOptions<GwpCountryContext> options) : base(options)
        {
            LoadDefaultData();
        }

        private void LoadDefaultData()
        {
            DataTable tblcsv = new DataTable();
            var csvTable = new DataTable();
            using (var csvReader = new CsvReader(new StreamReader(System.IO.File.OpenRead(Path.GetFullPath("CSV/gwpByCountry.csv"))), true))
            {
                csvTable.Load(csvReader);
            }
            for (int i = 0; i < csvTable.Rows.Count; i++)
            {
                gwpcountry.Add(new GwpByCountry
                {
                    country = csvTable.Rows[i][0].ToString(),
                    variableId = csvTable.Rows[i][1].ToString(),
                    variableName = csvTable.Rows[i][2].ToString(),
                    lineOfBusiness = csvTable.Rows[i][3].ToString(),
                    Y2000 = csvTable.Rows[i][4] == DBNull.Value ? 0 : Convert.ToDouble(csvTable.Rows[i][4]),
                    Y2001 = csvTable.Rows[i][5] == DBNull.Value ? 0 : Convert.ToDouble(csvTable.Rows[i][5]),
                    Y2002 = csvTable.Rows[i][6] == DBNull.Value ? 0 : Convert.ToDouble(csvTable.Rows[i][6]),
                    Y2003 = csvTable.Rows[i][7] == DBNull.Value ? 0 : Convert.ToDouble(csvTable.Rows[i][7]),
                    Y2004 = csvTable.Rows[i][8] == DBNull.Value ? 0 : Convert.ToDouble(csvTable.Rows[i][8]),
                    Y2005 = csvTable.Rows[i][9] == DBNull.Value ? 0 : Convert.ToDouble(csvTable.Rows[i][9]),
                    Y2006 = csvTable.Rows[i][10] == DBNull.Value ? 0 : Convert.ToDouble(csvTable.Rows[i][10]),
                    Y2007 = csvTable.Rows[i][11] == DBNull.Value ? 0 : Convert.ToDouble(csvTable.Rows[i][11]),
                    Y2008 = csvTable.Rows[i][12] == DBNull.Value ? 0 : Convert.ToDouble(csvTable.Rows[i][12]),
                    Y2009 = csvTable.Rows[i][13] == DBNull.Value ? 0 : Convert.ToDouble(csvTable.Rows[i][13]),
                    Y2010 = csvTable.Rows[i][14] == DBNull.Value ? 0 : Convert.ToDouble(csvTable.Rows[i][14]),
                    Y2011 = csvTable.Rows[i][15] == DBNull.Value ? 0 : Convert.ToDouble(csvTable.Rows[i][15]),
                    Y2012 = csvTable.Rows[i][16] == DBNull.Value ? 0 : Convert.ToDouble(csvTable.Rows[i][16]),
                    Y2013 = csvTable.Rows[i][17] == DBNull.Value ? 0 : Convert.ToDouble(csvTable.Rows[i][17]),
                    Y2014 = csvTable.Rows[i][18] == DBNull.Value ? 0 : Convert.ToDouble(csvTable.Rows[i][18]),
                    Y2015 = csvTable.Rows[i][19] == DBNull.Value ? 0 : Convert.ToDouble(csvTable.Rows[i][19])

                });
            }


        }
        public async Task<List<GwpByCountry>> GetAll()
        {

            return gwpcountry.Local.ToList<GwpByCountry>(); ;
        }
        public async Task<List<GwpByCountry>> GetAvgGross(GwpByCountry gwpByCountry)
        {
            List<GwpByCountry> gwpByCountries = new List<GwpByCountry>();
            await Task.Run(() =>
            {
                gwpByCountries = gwpcountry.Local.Where(x => x.country == gwpByCountry.country && x.lineOfBusiness == gwpByCountry.lineOfBusiness).ToList();
            });

            return gwpByCountries;
        }
    }
}
