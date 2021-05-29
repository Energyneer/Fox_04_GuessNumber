using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task4;

namespace Task4test
{
    [TestClass]
    public class UnitTest1
    {
        private Game game;

        [TestInitialize]
        public void TestInitialize()
        {
            game = new Game();
        }

        [TestMethod]
        public void TestCheckNumber()
        {
            int reqValue = 66;
            game.ReqNumber = reqValue;
            Assert.AreEqual(0, game.CheckNumber(reqValue));
            Assert.AreEqual(-1, game.CheckNumber(reqValue - 1));
            Assert.AreEqual(1, game.CheckNumber(reqValue + 1));
        }

        [TestMethod]
        public void TestParseNumber()
        {
            int inValue = 66;
            int outValue = 0;
            Assert.IsTrue(InputEncoder.CheckAndParse(inValue.ToString(), out outValue));
            Assert.AreEqual(inValue, outValue);

            Assert.IsFalse(InputEncoder.CheckAndParse("no number", out outValue));
        }

        [TestMethod]
        public void TestParseAgain()
        {
            bool outValue = false;
            Assert.IsTrue(InputEncoder.CheckAgain("YES", out outValue));
            Assert.IsTrue(InputEncoder.CheckAgain("y", out outValue));
            Assert.IsTrue(outValue);

            Assert.IsTrue(InputEncoder.CheckAgain("NO", out outValue));
            Assert.IsTrue(InputEncoder.CheckAgain("n", out outValue));
            Assert.IsFalse(outValue);

            Assert.IsFalse(InputEncoder.CheckAgain("not correct", out outValue));
        }

        [TestMethod]
        public void TestGenerateValue()
        {
            int oldValue = game.ReqNumber;
            game.GenerateNewNumber();
            if (game.ReqNumber == oldValue)
                game.GenerateNewNumber();

            Assert.AreNotEqual(oldValue, game.ReqNumber);
        }
    }
}
