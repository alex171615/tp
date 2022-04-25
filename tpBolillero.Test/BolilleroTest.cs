using System;
using Xunit;
using tpbolillero.core;
using System.Collections.Generic;
using System.Linq;

namespace tpBolillero.Test
{
    public class BolilleroTest
    {
        
        [Fact]
        public void Bolillero()
        {
            Bolillero = new Bolillero(10);
            Bolillero.Azar= new Primero();
        }

        [Fact]
        public void TestSacatBolilla()
        {
            Assert.Equal(0, bolillero.SacarBolilla());
            Assert.Equal(9,bolillero.Adentro.Count);
            Assert.Equal(1,bolillero.Afuera.Count);
        }
    }
}
