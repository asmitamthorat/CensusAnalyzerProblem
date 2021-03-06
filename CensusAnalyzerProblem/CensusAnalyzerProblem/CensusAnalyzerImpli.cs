﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CensusAnalyzerProblem
{
    public class CensusAnalyzerImpli
    {

        static private List<IndiaStateCode> IndiaStateCodeCsvList = new List<IndiaStateCode>();
        public List<IndiaStateCode> loadingStateCensusCSV(String path) {
            using (var file = new System.IO.StreamReader( path))
            {
                IndiaStateCodeCsvList = new CsvHelper.CsvReader(file, System.Globalization.CultureInfo.InvariantCulture)
                    .GetRecords<IndiaStateCode>().ToList();
            }
            return IndiaStateCodeCsvList;
        }



        public List<IndiaStateCode> sortByStateCode(String Path) {
            List<IndiaStateCode> ListOfStateCode = loadingStateCensusCSV(Path);
            ListOfStateCode.Sort(delegate (IndiaStateCode c1, IndiaStateCode c2) { return c1.StateCode.CompareTo(c2.StateCode); });
            return ListOfStateCode;



        }
    }
}
