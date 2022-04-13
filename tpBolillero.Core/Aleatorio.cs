using System;
using System.Collections.Generic;
using System.Linq;

namespace tpBolillero.Core
{
    public class Aleatorio : IAzar
    {
        private Random r = new Random();
        public SacarBolilla(List<byte>b);
        
    }
}