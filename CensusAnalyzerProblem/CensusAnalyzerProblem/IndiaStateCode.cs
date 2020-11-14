using System;
using System.Collections.Generic;
using System.Text;

namespace CensusAnalyzerProblem
{
    public class IndiaStateCode
    {
        public int SrNo { get; set; }
        public String StateName { get; set; }
        public String TIN { get; set; }

        public String StateCode { get; set; }


        public override string ToString()
        {
            return $"SrNo {SrNo},StateName {StateName},TIN {TIN},StateCode {StateCode}";
        }
    }
}
