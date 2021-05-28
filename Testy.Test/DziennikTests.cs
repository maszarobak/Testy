using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Testy;

namespace Testy.Tests
{
    [TestFixture]
    public class DziennikTests
    {
        [Test]
        public void Dziennik_OcenaWDzienniku_PunktyMniejszeNiz50_Zwroc_Niedostateczne()
        {
            var result = Dziennik.OcenaWDzienniku(12);
            Assert.That(result, Is.EqualTo("niedostateczne"));
        }
        [Test]
        public void Dziennik_OcenaWDzienniku_PunktyMniejszeNiz65_Zwroc_dostateczne()
        {
            var result = Dziennik.OcenaWDzienniku(55);
            Assert.That(result, Is.EqualTo("dostateczny"));
        }
        [Test]
        public void Dziennik_OcenaWDzienniku_PunktyMniejszeNiz75_Zwroc_Dobry()
        {
            var result = Dziennik.OcenaWDzienniku(67);
            Assert.That(result, Is.EqualTo("dobry"));
        }
        [Test]
        public void Dziennik_OcenaWDzienniku_PunktyMniejszeNiz85_Zwroc_BardzoDobry()
        {
            var result = Dziennik.OcenaWDzienniku(80);
            Assert.That(result, Is.EqualTo("bardzo dobry"));
        }
        [Test]
        public void Dziennik_OcenaWDzienniku_PunktyWiekszeNiz85_Zwroc_Celujacy()
        {
            var result = Dziennik.OcenaWDzienniku(97);
            Assert.That(result, Is.EqualTo("celujacy"));
        }

        [Test]
        [TestCase(25, 39, 1)]
        [TestCase(8, 2, 2)]
        public void EkstraOcenaTest_ZnajdzNWD(int x, int y, int z)
        {
            var result = Dziennik.EkstraOcena(x, y);
            Assert.That(result, Is.EqualTo(z));
        }
    }
}

namespace Testy.Test
{
    [TestFixture]
    class DziennikTests
    {
        [Test]
        public void Dziennik_Sprawdzian_WiekszeOd50_Zwraca_Zdales()
        {
            var result = Dziennik.Sprawdzian(89);
            Assert.That(result, Is.EqualTo("zdales"));
        }
        [Test]
        public void Dziennik_Sprawdzian_Rowne50_Zwraca_EkstraZadanie()
        {
            var result = Dziennik.Sprawdzian(50);
            Assert.That(result, Is.EqualTo("ekstra zadanie"));
        }
        [Test]
        public void Dziennik_Sprawdzian_MniejszeOd50_Zwraca_NieZdales()
        {
            var result = Dziennik.Sprawdzian(20);
            Assert.That(result, Is.EqualTo("nie zdales"));
        }

        
    }
}
