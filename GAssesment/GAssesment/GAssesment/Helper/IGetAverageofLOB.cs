using GAssesment.Model;
using System.Collections.Generic;

namespace GAssesment.Helper
{
    public interface IGetAverageofLOB
    {
        Dictionary<string, double> Average(List<GwpByCountry> result);
            }
}
