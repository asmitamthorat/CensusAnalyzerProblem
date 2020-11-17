using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Newtonsoft.Json;


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


        public List<StateCensusData> sortByStateName(String path) {
           List<StateCensusData> list= loadStateCensusData(path);
            //sorting using delegate
            list.Sort(delegate (StateCensusData c1, StateCensusData c2) { return c1.State.CompareTo(c2.State); });
           // String JsonSortedStateCensusData = JsonConvert.SerializeObject(list);
            return list;



        }

    }
}
