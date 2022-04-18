using System;
using System.Collections.Generic;
using System.Linq;

namespace tpBolillero.Core
{
    public class Aleatorio : IAzar
    {
        private Random r = new Random();

        public byte SacarBolilla(List<byte> b)
        {
            int aleatorionumero=b.Count();
            int indice=r.Next(0,aleatorionumero);
            return b[indice];
        }
    }
}