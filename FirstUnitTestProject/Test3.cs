using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstUnitTestProject
{
    [TestClass]
    public class Test3
    {
        [TestMethod, TestCategory("SmokeTest")]
        public void TestCaseOne()
        {
            Console.WriteLine("This is class two Test Method");
        }

    }
}
