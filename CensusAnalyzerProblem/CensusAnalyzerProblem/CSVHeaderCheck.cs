using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using CsvHelper;

using System.Linq;

namespace CensusAnalyzerProblem
{
   public class CSVHeaderCheck
    {
        public void loadFile(String filePath) {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
            {
                if (!csv.Configuration.HasHeaderRecord) {

                    throw new CustomException(CustomException.ExceptionType.Invalid_Header, "csv file doesn't have header");

                }
               
            }

           

            


            }

    }
}
