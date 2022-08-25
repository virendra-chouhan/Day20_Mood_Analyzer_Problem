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
            Mood_Analyzer_Problem.Program program = new Mood_Analyzer_Problem.Program();
            var result = program.AnalyseMood("Happy");
            Assert.AreEqual("Happy mood", result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Mood_Analyzer_Problem.Program program = new Mood_Analyzer_Problem.Program();
            var result = program.AnalyseMood("Sad");
            Assert.AreEqual("Sad mood", result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Mood_Analyzer_Problem.Program program = new Mood_Analyzer_Problem.Program();
            var result = program.AnalyseMood("I am Sad");
            Assert.AreEqual("SAD", result);
        }
        [TestMethod]
        public void TestMethod4()
        {
            Mood_Analyzer_Problem.Program program = new Mood_Analyzer_Problem.Program();
            var result = program.AnalyseMood("I am in Any");
            Assert.AreEqual("Happy", result);
        }

    }
}
