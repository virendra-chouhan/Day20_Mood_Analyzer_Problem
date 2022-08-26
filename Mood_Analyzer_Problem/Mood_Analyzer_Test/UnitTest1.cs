using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Mood_Analyzer_Problem;

namespace Mood_Analyzer_Test
{
    [TestClass]
    public class UnitTest1
    {




        [TestMethod]
        public void TestMethod1()
        {
            Mood_Analyzer_Problem.Program program = new Mood_Analyzer_Problem.Program("Happy");
            var result = program.AnalyseMood();
            Assert.AreEqual("Happy mood", result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Mood_Analyzer_Problem.Program program = new Mood_Analyzer_Problem.Program("Sad");
            var result = program.AnalyseMood();
            Assert.AreEqual("Sad mood", result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Mood_Analyzer_Problem.Program program = new Mood_Analyzer_Problem.Program("I am Sad");
            var result = program.AnalyseMood();
            Assert.AreEqual("SAD", result);
        }
        [TestMethod]
        public void TestMethod4()
        {
            Mood_Analyzer_Problem.Program program = new Mood_Analyzer_Problem.Program("I am in Any");
            var result = program.AnalyseMood();
            Assert.AreEqual("Happy", result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Mood_Analyzer_Problem.Program program = new Mood_Analyzer_Problem.Program();
            var result = program.AnalyseMood();
            Assert.AreEqual("Happy", result);
        }

        [TestMethod]
        [DataRow("")]
        public void TestMethod6(string m)
        {
            try
            {
                Mood_Analyzer_Problem.Program program = new Mood_Analyzer_Problem.Program(m);
                string result = program.AnalyseMood();
                
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual("Mood should not be empty", e.Message);

            }
        }
    }
}
