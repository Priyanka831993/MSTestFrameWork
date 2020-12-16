using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstUnitTestProject
{
    [TestClass]
    public class Test4
    {
        [TestMethod, TestCategory("SmokeTest")]
        public void Test()
        {
            Console.WriteLine("This is class two Test4 Method");
        }
    }
}
