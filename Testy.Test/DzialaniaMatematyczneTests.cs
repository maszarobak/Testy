using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testy.Test
{
    [TestClass]
    public class DzialaniaMatematyczneTests
    {
        [TestMethod]
        public void Maksimum_LiczbyDodatnie()
        {
            int[] a = { 4, 8, 6, 44, 87 };
            int expected = 87;
            int actual = DzialaniaMatematyczne.Maksimum(a);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Maksimum_LiczbyUjemne()
        {
            int[] a = { -4, -8, -6, -44, -87 };
            int expected = -4;
            int actual = DzialaniaMatematyczne.Maksimum(a);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void Maksimum_aRownaSieZero()
        {
            int[] a = null;
            int actual = DzialaniaMatematyczne.Maksimum(a);
            
        }
        [TestMethod]
        public void Maksimum_Srednia()
        {
            int[] a = {5,3,2 };
            double expected = 3.33;
            double actual = DzialaniaMatematyczne.Srednia(a);
            Assert.AreEqual(expected, actual, 0.01);
        }

    }
}
