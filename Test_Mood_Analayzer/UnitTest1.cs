using Mood_Analyzer;
using NUnit.Framework;

namespace Test_Mood_Analayzer
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {

        }
        //TC.1.1
        //TC1.2
        //TC2.1=with null value


        [TestCase("sad")]
        [TestCase("SAD")]
        [TestCase("i am sad")]
        [TestCase("i am in sad mood")]
        [TestCase("I AM SAD")]
        [TestCase(null)]

        public void test_TO_checkMood_FOR_SAD(string input)
        {
            Mood mood = new Mood(input);
            string expected = "SAD";
            var actual = mood.checkMood();
            Assert.AreEqual(expected, actual);
        }

        [TestCase("happy")]
        [TestCase("HAPPY")]
        [TestCase("i am happy")]
        [TestCase("i am not in sad mood")]
        [TestCase("I AM in any mood")]
        [TestCase(null)]

        public void test_TO_checkMood_FOR_HAPPY(string moodinput)
        {
            Mood mood = new Mood(moodinput);
            string expected = "HAPPY";
            var actual = mood.checkMood();
            Assert.AreEqual(expected, actual);
        }

        //TC3.1
        [TestCase(null)]

        public void test_TO_checkMood_FOR_Null_eception(string input)
        {
            Mood mood = new Mood(input);
            string expected = "nullmood";
            var actual = mood.checkMood();
            Assert.AreEqual(expected, actual);
        }
    }
}