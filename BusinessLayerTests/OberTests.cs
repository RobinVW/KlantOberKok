using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Text;


namespace BusinessLayer.Tests
{
    [TestClass()]
    public class OberTests
    {
        [TestMethod()]
        public void OberTest()
        {
            var name = "Jean";
            var ober = new Ober("Jean");
            Assert.AreEqual(ober.Naam,name);
        }

        
    }
}