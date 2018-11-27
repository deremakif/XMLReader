using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XMLReader;
using XMLReader.Models;

namespace XMLReader.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            WordModel wm = new WordModel();
            Assert.AreEqual(wm.book, "Moby Dick"); 
        }
    }
}
