using System;
using System.Collections.Generic;
using System.Text;

namespace CensusAnalyzerProblem
{
   public class CustomException:Exception
    {
        public enum ExceptionType { 
        
        emplty_fileException,diliminator_issue,Invalid_File,Invalid_Header
        }

        public readonly ExceptionType type;

        public CustomException(ExceptionType type, string messge) : base(messge) {

            this.type = type;
        }
    }
}
