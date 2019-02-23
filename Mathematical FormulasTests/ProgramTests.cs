using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathematical_Formulas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematical_Formulas.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void AreaCTest()
        {
            Assert.AreEqual(Math.PI, Program.AreaC(1));
        }

        [TestMethod()]
        public void HeronTest()
        {
            Assert.AreEqual(0, Program.Heron(1, 2, 3);
        }

        [TestMethod()]
        public void Heron2Test()
        {
            Assert.AreEqual(, Program.Heron2(1, 2, 3);
        }
    }
}