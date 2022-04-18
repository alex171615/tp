using System.Collections.Generic;
using System;
using System.Linq;

namespace tpBolillero.Core
{
    public class Primero : IAzar
    {
        byte IAzar.SacarBolilla(List<byte>  b) => b[0];
        
    
    }
}