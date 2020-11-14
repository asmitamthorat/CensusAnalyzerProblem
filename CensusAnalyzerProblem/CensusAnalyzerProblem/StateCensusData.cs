using System;
using System.Collections.Generic;
using System.Text;

namespace CensusAnalyzerProblem
{
   public class StateCensusData
    {
        public String State { get; set; }
        public int  Population { get; set; }
        public String AreaInSqKm { get; set; }
        public String DensityPerSqKm { get; set; }


        public override string ToString()
        {
            return $"State {State}: Population: {Population},AreaInSqKm: {AreaInSqKm}, DensityPerSqKm: {DensityPerSqKm}";
        }
    }
}
