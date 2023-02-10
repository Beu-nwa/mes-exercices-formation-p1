using projet_a_tester._06_bowling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Moq;
using System.Threading.Tasks;

namespace testeur_de_projet._06_bowling
{
    [TestClass]
    public class FrameTest
    {
        //[TestMethod]
        //public void Frame_test_strike_sould_be_true()
        //{
        //    IGenerateur roll = Mock.Of<IGenerateur>();
        //    Mock.Get(roll).Setup((roll) => roll.RandomPin(10)).Returns(10);
        //    Frame frame = new Frame(roll, false);
        //    bool res = frame.MakeRoll();

        //    Assert.IsTrue(res);
        //}
        [TestMethod]
        public void Frame_test_strike_sould_be_true()
        {
            IGenerateur roll = Mock.Of<IGenerateur>();
            Mock.Get(roll).Setup((roll) => roll.RandomPin(10)).Returns(10);
            Frame frame = new Frame(roll, false);
            bool res = frame.MakeRoll();

            Assert.IsTrue(res);
        }
    }
}
