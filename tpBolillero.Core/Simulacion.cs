using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System;

namespace tpBolillero.Core
{
    public class Simulacion
    {
        public long simularSinHilos(Bolillero copia, List <byte> juegos, long cantidadJugadas )
        {
            return copia.JugarN(juegos,cantidadJugadas);

        }

        public long simularConHilos(Bolillero bolillero, List <byte> juegos, long cantidadJugadas, long hilos)
        {
            Task <long>[] tarea = new Task <long>[hilos]; 

            long cantidadh  = cantidadJugadas/hilos;
            for (int i = 0; i < cantidadJugadas; i++)
            {
                Bolillero copia =(Bolillero)bolillero.Clone();
                tarea[i] = Task<long>.Run(() => simularSinHilos(copia, juegos, cantidadJugadas));
            }

            Task <long>.WaitAll(tarea);
            return tarea.Sum(x => x.Result);
   
        }    

        public async Task<long> imprimirAsync(Bolillero bolillero, List <byte> juegos, long cantidadJugadas, long hilos)
        {
            Task <long>[] tarea = new Task <long>[hilos]; 

            long cantidadh  = cantidadJugadas/hilos;

            for (int i = 0; i < cantidadJugadas; i++)
            {
                Bolillero copia = (Bolillero)bolillero.Clone();
                tarea[i] = Task<long>.Run(() => simularSinHilos(copia, juegos, hilos));
            }

            await Task <long>.WhenAll(tarea);
            return tarea.Sum(x => x.Result);

        }
        
    }
}