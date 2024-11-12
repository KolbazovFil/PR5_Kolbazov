using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PR4_Kolbazov;
namespace ProgramTests
{
    [TestClass]
    public class UnitTest1
    {
        // ----- positive
        [TestMethod]
        public void Module_MinimumValidScore()
        {
            int minScore1 = 0;
            int minScore2 = 0;
            int minScore3 = 0;
            int maxScore1 = 22;
            int maxScore2 = 38;
            int maxScore3 = 20;
            int score1 = 0;
            int score2 = 0;
            int score3 = 0;
            int expected1 = 0;
            int expected2 = 0;
            int expected3 = 0;

            Module module1 = new Module(score1, minScore1, maxScore1);
            Module module2 = new Module(score2, minScore2, maxScore2);
            Module module3 = new Module(score3, minScore3, maxScore3);

            int actual1 = module1.Score;
            int actual2 = module2.Score;
            int actual3 = module3.Score;

            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
        }
        [TestMethod]
        public void Module_MaximunValidScore()
        {
            int minScore1 = 0;
            int minScore2 = 0;
            int minScore3 = 0;
            int maxScore1 = 22;
            int maxScore2 = 38;
            int maxScore3 = 20;
            int score1 = 22;
            int score2 = 38;
            int score3 = 20;
            int expected1 = 22;
            int expected2 = 38;
            int expected3 = 20;

            Module module1 = new Module(score1, minScore1, maxScore1);
            Module module2 = new Module(score2, minScore2, maxScore2);
            Module module3 = new Module(score3, minScore3, maxScore3);

            int actual1 = module1.Score;
            int actual2 = module2.Score;
            int actual3 = module3.Score;

            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
        }
        [TestMethod]
        public void Sum_MinimumValidSumOfScores()
        {
            int score1 = 0;
            int score2 = 0;
            int score3 = 0;
            int expected = 0;

            Sum sum = new Sum(score1, score2, score3);

            int actual = sum.Total;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Sum_MidleValidSumOfScores()
        {
            int score1 = 0;
            int score2 = 0;
            int score3 = 0;
            int expected = 0;

            Sum sum = new Sum(score1, score2, score3);

            int actual = sum.Total;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Sum_MaximumValidSumOfScores()
        {
            int score1 = 22;
            int score2 = 38;
            int score3 = 20;
            int expected = 80;

            Sum sum = new Sum(score1, score2, score3);

            int actual = sum.Total;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Calculate_MinimumValidScoresForMarkTwo()
        {
            int score1 = 0;
            int score2 = 0;
            int score3 = 0;
            int total = score1 + score2 + score3;
            string expected = "Оценка: \"2\" (Неудовлетворительно)";
            Calculate calculate = new Calculate(total);
            string actual = calculate.Str;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Calculate_MidleValidScoresForMarkTwo()
        {
            int score1 = 2;
            int score2 = 3;
            int score3 = 4;
            int total = score1 + score2 + score3;
            string expected = "Оценка: \"2\" (Неудовлетворительно)";
            Calculate calculate = new Calculate(total);
            string actual = calculate.Str;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Calculate_MaximumValidScoresForMarkTwo()
        {
            int score1 = 5;
            int score2 = 5;
            int score3 = 5;
            int total = score1 + score2 + score3;
            string expected = "Оценка: \"2\" (Неудовлетворительно)";
            Calculate calculate = new Calculate(total);
            string actual = calculate.Str;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Calculate_MinimumValidScoresForMarkThree()
        {
            int score1 = 5;
            int score2 = 6;
            int score3 = 5;
            int total = score1 + score2 + score3;
            string expected = "Оценка: \"3\" (Удовлетворительно)";
            Calculate calculate = new Calculate(total);
            string actual = calculate.Str;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Calculate_MidleValidScoresForMarkThree()
        {
            int score1 = 7;
            int score2 = 7;
            int score3 = 7;
            int total = score1 + score2 + score3;
            string expected = "Оценка: \"3\" (Удовлетворительно)";
            Calculate calculate = new Calculate(total);
            string actual = calculate.Str;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Calculate_MaximumValidScoresForMarkThree()
        {
            int score1 = 10;
            int score2 = 11;
            int score3 = 10;
            int total = score1 + score2 + score3;
            string expected = "Оценка: \"3\" (Удовлетворительно)";
            Calculate calculate = new Calculate(total);
            string actual = calculate.Str;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Calculate_MinimumValidScoresForMarkFour()
        {
            int score1 = 11;
            int score2 = 11;
            int score3 = 10;
            int total = score1 + score2 + score3;
            string expected = "Оценка: \"4\" (Хорошо)";
            Calculate calculate = new Calculate(total);
            string actual = calculate.Str;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Calculate_MidleValidScoresForMarkFour()
        {
            int score1 = 15;
            int score2 = 15;
            int score3 = 15;
            int total = score1 + score2 + score3;
            string expected = "Оценка: \"4\" (Хорошо)";
            Calculate calculate = new Calculate(total);
            string actual = calculate.Str;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Calculate_MaximumValidScoresForMarkFour()
        {
            int score1 = 20;
            int score2 = 15;
            int score3 = 20;
            int total = score1 + score2 + score3;
            string expected = "Оценка: \"4\" (Хорошо)";
            Calculate calculate = new Calculate(total);
            string actual = calculate.Str;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Calculate_MinimumValidScoresForMarkFive()
        {
            int score1 = 20;
            int score2 = 16;
            int score3 = 20;
            int total = score1 + score2 + score3;
            string expected = "Оценка: \"5\" (Отлично)";
            Calculate calculate = new Calculate(total);
            string actual = calculate.Str;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Calculate_MidleValidScoresForMarkFive()
        {
            int score1 = 22;
            int score2 = 24;
            int score3 = 20;
            int total = score1 + score2 + score3;
            string expected = "Оценка: \"5\" (Отлично)";
            Calculate calculate = new Calculate(total);
            string actual = calculate.Str;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Calculate_MaximumValidScoresForMarkFive()
        {
            int score1 = 22;
            int score2 = 38;
            int score3 = 20;
            int total = score1 + score2 + score3;
            string expected = "Оценка: \"5\" (Отлично)";
            Calculate calculate = new Calculate(total);
            string actual = calculate.Str;
            Assert.AreEqual(expected, actual);
        }
        // ----- negative
        [TestMethod]
        public void Module_OneOrMoreWordsSymbolsInsteadNumbers_ShouldThrowFormatException()
        {
            string score1 = "ф12";
            string score2 = "№5";
            string score3 = "*78";
            Assert.ThrowsException<FormatException>(() => new Module(int.Parse(score1), int.Parse(score2), int.Parse(score3)));
        }
        [TestMethod]
        public void Module_ScoresLessMinimumOneOrMoreModules_ShouldThrowArgumentOutOfRange()
        {
            int minScore1 = 0;
            int minScore2 = 0;
            int minScore3 = 0;
            int maxScore1 = 22;
            int maxScore2 = 38;
            int maxScore3 = 20;
            int score1 = -1;
            int score2 = -1;
            int score3 = -1;

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Module(score1, minScore1, maxScore1));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Module(score2, minScore2, maxScore2));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Module(score3, minScore3, maxScore3));
        }
        [TestMethod]
        public void Module_ScoresAboveMaximumOneOrMoreModules_ShouldThrowArgumentOutOfRange()
        {
            int minScore1 = 0;
            int minScore2 = 0;
            int minScore3 = 0;
            int maxScore1 = 22;
            int maxScore2 = 38;
            int maxScore3 = 20;
            int score1 = 23;
            int score2 = 39;
            int score3 = 21;

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Module(score1, minScore1, maxScore1));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Module(score2, minScore2, maxScore2));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Module(score3, minScore3, maxScore3));
        }
        [TestMethod]
        public void Module_OneOrMoreSpaceEmptyEntreeInsteadNumbers_ShouldThrowFormatException()
        {
            string score1 = " ";
            string score2 = null;
            string score3 = "";
            Assert.ThrowsException<FormatException>(() => new Module(int.Parse(score1), int.Parse(score2), int.Parse(score3)));
        }
        [TestMethod]
        public void Sum_SumScoresAboveMaximum_ShouldThrowArgumentOutOfRange()
        {
            int score1 = 23;    // 22
            int score2 = 38;    // 38
            int score3 = 20;    // 20

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Sum(score1, score2, score3));
        }
    }
}