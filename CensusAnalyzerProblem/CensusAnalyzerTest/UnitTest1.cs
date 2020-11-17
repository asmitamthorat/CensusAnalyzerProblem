using NUnit.Framework;
using CensusAnalyzerProblem;
using System;
using System.Collections.Generic;

namespace CensusAnalyzerTest
{

    

    public class Tests
    {

        String IndiaStateCodeCensusFilePath = @"C:\\Users\\com\\Desktop\\csv\\IndiaStateCode.csv";
      
        String IndiaCensusDataWithDelimiter = @"C:\\Users\\com\\Desktop\\csv\\DelimiterIndiaStateCensusData.csv";
        String IndiaCensusDataWithWrongFile = @"C:\\Users\\com\\Desktop\\csv\\IndiaStateCode.txt";
        String IndiaCensusDataFilePath1= @"C:\\Users\\com\\source\\repos\\CensusAnalyzerProblem\\CensusAnalyzerTest\\utilities\\IndiaStateCensusData.csv";

        String IndiaStateCensusWithoutHeader = @"C:\\Users\\com\\Desktop\\csv\\WrongHeaderIndiaStateCensusData.csv";

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
            List < StateCensusData >  list= stateCensusAnalyser.loadStateCensusData(IndiaCensusDataFilePath1);
            int count = list.Count;
            Console.WriteLine(count);
            Assert.AreEqual(29, count);
        }

        [Test]
        public void givenStateCensusData_ifhasDelimiterIssue_ShouldException() {
            try {
                Delimiter delimiter = new Delimiter();
                List<StateCensusData> list = delimiter.loadData(IndiaCensusDataWithDelimiter);
            }
            catch (CustomException customException) {
                Assert.AreEqual(CustomException.ExceptionType.diliminator_issue,customException.type);

            }   
        }

        [Test]
        public void givenWrongIndiaStateCode_InputFile_ShouldThrowWxception() {
            try {
                WrongFileInput wrongFileInput = new WrongFileInput();
                wrongFileInput.loadFile(IndiaCensusDataWithWrongFile);
            }
            catch (CustomException customException) {
                Assert.AreEqual(CustomException.ExceptionType.Invalid_File, customException.type);
            }      
        }

        [Test]
        public void givenStateCensusAnalyser_WithoutHeader_ShouldThrowException() {
            try
            {
                CSVHeaderCheck csvHeaderCheck = new CSVHeaderCheck();
                csvHeaderCheck.loadFile(IndiaStateCensusWithoutHeader);
            }
            catch (CustomException customException)
            {
                Assert.AreEqual(CustomException.ExceptionType.Invalid_Header, customException.type);
            }
        }


        [Test]
        public void givenStateCensusCsv_sortOntheBasisOfStateName() {
            StateCensusAnalyser stateCensusAnalyser = new StateCensusAnalyser();
           List<StateCensusData> JsonStateCensusData= stateCensusAnalyser.sortByStateName(IndiaCensusDataFilePath1);
            Assert.AreEqual("Andhra Pradesh", JsonStateCensusData[0].State);
        }

        [Test]
        public void givenStateCodeCsvFile_whenSorted_ShouldRetrunSortedList() {
            CensusAnalyzerImpli censusAnalyzerImpli = new CensusAnalyzerImpli();
            List<IndiaStateCode> sortedIndiaStateCodelist=censusAnalyzerImpli.sortByStateCode(IndiaStateCodeCensusFilePath);
            Assert.AreEqual("AD", sortedIndiaStateCodelist[0].StateCode);

        
        
        }


    }
}