using System;
using System.Collections.Generic;
using System.Linq;

namespace tpBolillero.Core
{
    public class Aleatorio : IAzar
    {
        private Random r = new Random();

        public byte SacarBolilla(List<byte> numerob)
        {
            int aleatorionumero=numerob.Count();
            int indice=r.Next(0,aleatorionumero);
            return numerob[indice];
        }
    }
}