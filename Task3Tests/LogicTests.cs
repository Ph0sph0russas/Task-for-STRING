using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void clearSameSymbolsFromWordTestFromBeginning()
        {
            string word = "Иииииииинформация";
            word = Logic.clearSameSymbolsFromWord(word);
            string result = "Информаця";
            Assert.AreEqual(word, result);
        }

        [TestMethod()]
        public void clearSameSymbolsFromWordTestFromEnding()
        {
            string word = "Информацияяяяяяяяяяяя";
            word = Logic.clearSameSymbolsFromWord(word);
            string result = "Информаця";
            Assert.AreEqual(word, result);
        }

        [TestMethod()]
        public void clearSameSymbolsFromWordTestFromMiddle()
        {
            string word = "Инфоррррррррмация";
            word = Logic.clearSameSymbolsFromWord(word);
            string result = "Информаця";
            Assert.AreEqual(word, result);
        }

        [TestMethod()]
        public void clearSameSymbolsFromWordTestFromEveryPlace()
        {
            string word = "Ииииииинфоррррррррмацияяяяяя";
            word = Logic.clearSameSymbolsFromWord(word);
            string result = "Информаця";
            Assert.AreEqual(word, result);
        }

        [TestMethod()]
        public void clearSameSymbolsFromWordTestDiffrentReg()
        {
            string word = "ИиИиИИинформация";
            word = Logic.clearSameSymbolsFromWord(word);
            string result = "Информаця";
            Assert.AreEqual(word, result);
        }

        [TestMethod()]
        public void checkSameElementsTestDefault()
        {
            string firstWord = "Процес";
            string secondWord = "Информация";
            string expectedResult = "нет да да да нет нет ";
            string actualResult = Logic.checkSameElements(firstWord, secondWord);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void checkSameElementsTestEveryYes()
        {
            string firstWord = "Процес";
            string secondWord = "Процес";
            string expectedResult = "да да да да да да ";
            string actualResult=Logic.checkSameElements(firstWord, secondWord);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void checkSameElementsTestEveryNo()
        {
            string firstWord = "вид";
            string secondWord = "Процес";
            string expectedResult = "нет нет нет ";
            string actualResult = Logic.checkSameElements(firstWord, secondWord);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void checkSameElementsTestDifReg()
        {
            string firstWord = "еСТь";
            string secondWord = "нЕт";
            string expectedResult = "да нет да нет ";
            string actualResult = Logic.checkSameElements(firstWord, secondWord);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}