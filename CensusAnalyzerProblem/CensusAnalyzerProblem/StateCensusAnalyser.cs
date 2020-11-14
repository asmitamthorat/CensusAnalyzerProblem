using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CensusAnalyzerProblem
{
    public class StateCensusAnalyser
    {
        static private List<StateCensusData> StateCensusAnalyserlist = new List<StateCensusData>();
        public List<StateCensusData> loadStateCensusData(String path) {

            var file = new System.IO.StreamReader(path);
            StateCensusAnalyserlist = new CsvHelper.CsvReader(file, System.Globalization.CultureInfo.InvariantCulture)
                    .GetRecords<StateCensusData>().ToList();
        
            return StateCensusAnalyserlist;
        }

    }
}
