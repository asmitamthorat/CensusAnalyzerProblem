using System;
using System.Collections.Generic;
using System.Text;

namespace CensusAnalyzerProblem
{
    class CustomException:Exception
    {
        public enum ExceptionType { 
        
        emplty_fileException
        }

        public readonly ExceptionType type;

        public CustomException(ExceptionType type, string messge) : base(messge) {

            this.type = type;
        }
    }
}
