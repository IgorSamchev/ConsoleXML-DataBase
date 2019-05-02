using System.Diagnostics.CodeAnalysis;
using Main;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    [SuppressMessage("ReSharper", "ExpressionIsAlwaysNull")]
    public class CorrectDataCheckerTest
    {
        [TestMethod]
        public void CheckLastNameLengthMoreThanTwoCharsAndNotNull()
        {
            const string s1 = "lastName";
            bool result1 = CorrectDataChecker.CheckLastName(s1);
            Assert.AreEqual(true, result1); //lastName is > 2 chars

            const string s2 = "la";
            bool result2 = CorrectDataChecker.CheckLastName(s2);
            Assert.AreEqual(false, result2); //lastName is == 2 chars

            string s3 = null;
            bool result3 = CorrectDataChecker.CheckLastName(s3);
            Assert.AreEqual(false, result3); //lastName is null
        }

        [TestMethod]
        public void CheckGroupLengthMoreThanZeroCharsAndNotNull()
        {
            const string s1 = "group";
            bool result1 = CorrectDataChecker.CheckGroup(s1);
            Assert.AreEqual(true, result1); //Group is > 1 char

            const string s2 = "";
            bool result2 = CorrectDataChecker.CheckGroup(s2);
            Assert.AreEqual(false, result2); //Group is zero chars

            string s3 = null;
            bool result3 = CorrectDataChecker.CheckGroup(s3);
            Assert.AreEqual(false, result3); //Group is null;
        }

        [TestMethod]
        public void CheckYearIsNotMoreOrLessThan4Digits()
        {
            const int s1 = 1999;
            bool result1 = CorrectDataChecker.CheckYear(s1);
            Assert.AreEqual(true, result1); // 4 digits

            const int s2 = 888;
            bool result2 = CorrectDataChecker.CheckYear(s2);
            Assert.AreEqual(false, result2); //3 digits

            const int s3 = 20001;
            bool result3 = CorrectDataChecker.CheckYear(s3);
            Assert.AreEqual(false, result3); //5 digits
        }

        [TestMethod]
        public void CheckPhysicsScoreMoreThanZeroAndLessThanSix()
        {
            const int s1 = 4;
            bool result1 = CorrectDataChecker.CheckPhysicsScore(s1);
            Assert.AreEqual(true, result1); // > 0 && < 6

            const int s2 = 0;
            bool result2 = CorrectDataChecker.CheckPhysicsScore(s2);
            Assert.AreEqual(false, result2); // < 1

            const int s3 = 6;
            bool result3 = CorrectDataChecker.CheckPhysicsScore(s3);
            Assert.AreEqual(false, result3); // > 5
        }

        [TestMethod]
        public void CheckMathScoreMoreThanZeroAndLessThanSix()
        {
            const int s1 = 5;
            bool result1 = CorrectDataChecker.CheckMathScore(s1);
            Assert.AreEqual(true, result1); // > 0 && < 6

            const int s2 = 0;
            bool result2 = CorrectDataChecker.CheckMathScore(s2);
            Assert.AreEqual(false, result2); // < 1

            const int s3 = 6;
            bool result3 = CorrectDataChecker.CheckMathScore(s3);
            Assert.AreEqual(false, result3); // > 5
        }

        [TestMethod]
        public void CheckInformaticsScoreMoreThanZeroAndLessThanSix()
        {
            const int s1 = 3;
            bool result1 = CorrectDataChecker.CheckInformaticsScore(s1);
            Assert.AreEqual(true, result1); // > 0 && < 6

            const int s2 = 0;
            bool result2 = CorrectDataChecker.CheckInformaticsScore(s2);
            Assert.AreEqual(false, result2); // < 1

            const int s3 = 6;
            bool result3 = CorrectDataChecker.CheckInformaticsScore(s3);
            Assert.AreEqual(false, result3); // > 5
        }
    }
}
