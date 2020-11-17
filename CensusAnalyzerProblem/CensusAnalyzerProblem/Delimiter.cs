using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;




namespace CensusAnalyzerProblem
{
    public class Delimiter
    {
        static private List<StateCensusData> StateCensusAnalyserlist = new List<StateCensusData>();
        public List<StateCensusData> loadData(String path) {
            using (StreamReader reader = new StreamReader(path))
            {

                String data = reader.ReadLine();

                if (!data.Contains(","))
                {

                    throw new CustomException(CustomException.ExceptionType.diliminator_issue, "dilimiter issue");
                }
                return StateCensusAnalyserlist;
            }
        
        }
    }
}
