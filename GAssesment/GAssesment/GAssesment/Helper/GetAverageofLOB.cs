using GAssesment.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace GAssesment.Helper
{
    public class GetAverageofLOB : IGetAverageofLOB
    {
        public   Dictionary<string, double> Average(List<GwpByCountry> result)
        {
            var avgofLOB = new Dictionary<string, double>();
            //convert List to Datatable
            DataTable table = ListtoDataTableConverter.ToDataTable(result);

            foreach (DataRow row in table.Rows)
            {
                Double sum = 0;
                int count = 0;
                double d;
                foreach (var item in row.ItemArray)
                {
                    if (Double.TryParse((string)item, out d))
                    {
                        sum = sum + Convert.ToDouble(item);
                        count++;
                    }

                }
                avgofLOB.Add(row["LOB"].ToString(), sum / count);
            }

            return avgofLOB;
        }

    }
}
