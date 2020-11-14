using NUnit.Framework;
using CensusAnalyzerProblem;
using System;
using System.Collections.Generic;

namespace CensusAnalyzerTest
{

    

    public class Tests
    {

        String IndiaStateCodeCensusFilePath = @"C:\\Users\\com\\Desktop\\csv\\IndiaStateCode.csv";
        String IndiaCensusDataFilePath = @"C:\\Users\\com\\Desktop\\csv\\IndiaStateCensusData.csv";
      //  String IndiaCensusDataWithDelimiter = @"C:\\Users\\com\\Desktop\\csv\\DelimiterIndiaStateCensusData.csv";

        [Test]
        public void givenIndiaStateCodecsvFile_ifHasCorrectNumberOFRecord_ShouldReturnTrue() {

            CensusAnalyzerImpli censusAnalyzer = new CensusAnalyzerImpli();
            List<IndiaStateCode> list =censusAnalyzer.loadingStateCensusCSV(IndiaStateCodeCensusFilePath);
            int count = list.Count;
            Assert.AreEqual(37,count);
        }

        [Test]
        public void givenStateCensusData_ifHasCorrectNumberOfRecord_ShouldReturnTrue() {

            StateCensusAnalyser stateCensusAnalyser = new StateCensusAnalyser();
            List < StateCensusData >  list= stateCensusAnalyser.loadStateCensusData(IndiaCensusDataFilePath);
            int count = list.Count;
            Console.WriteLine(count);
            Assert.AreEqual(29, count);
        }

       


    }
}