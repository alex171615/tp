using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using System;

namespace tpBolillero.Core
{
    public class Simulacion
    {
        public long simularSinHilos(Bolillero copia, List <byte> juegos, long j )
        {
            return copia.JugarN(juegos,j);

        }

        public long simularConHilos(Bolillero copia, List <byte> juegos, long j, long hilos)
        {
        Task <long>[] tarea = new Task <long>[hilos];
           return 1;
        }
    

        
        
    }
}