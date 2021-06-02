using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task4;

namespace Task4test
{
    [TestClass]
    public class UnitTest1
    {
        private Game game;

        [TestMethod]
        public void TestCheckNumber()
        {
            int reqValue = 66;
            Game game = new Game(reqValue);
            Assert.AreEqual(Promt.EQUAL, game.CheckNumber(reqValue));
            Assert.AreEqual(Promt.LESS, game.CheckNumber(reqValue - 1));
            Assert.AreEqual(Promt.MORE, game.CheckNumber(reqValue + 1));
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
            Game game = new Game();
            int inValue = 50;
            Promt startState = game.CheckNumber(inValue);
            for (int i = 0; i < 10; i++)
            {
                game.GenerateNewNumber();
                if (startState != game.CheckNumber(inValue))
                    break;
            }
            Assert.AreNotEqual(startState, game.CheckNumber(inValue));
        }
    }
}
