using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Testy.Tests
{
    [TestClass()]
    public class ObjektTests
    {
        Objekt klasa;
        [TestInitialize]
        public void Setup()
        {
            int[] a = { 7, 8, 11, 45 };
            klasa = new Objekt(a);
        }

        [TestMethod()]
        public void MaksimumTest()
        {
            int expected = 45;
            int actual = klasa.Maksimum();
            Assert.AreEqual(expected, actual);
        }
    }
}