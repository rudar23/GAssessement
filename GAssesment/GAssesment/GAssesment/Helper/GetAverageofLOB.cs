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
                int i;
               
                foreach (DataColumn column in table.Columns)
                {           

                    if(int.TryParse( column.ColumnName.Substring(1) ,out i) && Convert.ToInt32( column.ColumnName.Substring(1))>2007 )
                    {
                        sum = sum + Convert.ToDouble(row[column]);
                             count++;
                    }
                }

                avgofLOB.Add(row["lineOfBusiness"].ToString(), sum / count);
            }

            return avgofLOB;
        }

    }
}
