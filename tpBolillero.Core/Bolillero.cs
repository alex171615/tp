using System.Collections.Generic;
using System;
using System.Linq;
namespace tpBolillero.Core
{
    public class Bolillero
    {
        private List<byte> Adentro {get;set;}
        private List<byte> Afuera {get;set;}
        public IAzar Azar{get;set;}

       public Bolillero(IAzar azar)
        {
            Adentro = new List<byte>();
            Afuera = new List<byte>();
            Azar = azar;
        }

        public Bolillero(IAzar azar, byte numerob) 
            => CrearBolillas(numerob);
        

        public void CrearBolillas(byte numerob)
        {
            Adentro=new List<byte>();
            Afuera=new List<byte>();
            
            for  (byte i = 0; i < numerob; i++)
            {
            Adentro.Add(numerob);
            }
            

        }
        public void Reingresar()
        {
            Afuera.AddRange(Adentro);
            Afuera.Clear();
        }
        

        public byte SacarBolilla()
        {
            var bol = Azar.SacarBolilla(Adentro);
            Adentro.Add(bol);
            Adentro.Remove(bol);
            return(bol);
        }


        public bool Jugar(List <byte> bol) 
        => bol.TrueForAll(x => x == SacarBolilla());


        public long JugarN(List<byte> juegos,long j)
        {
            long contador=0;

            for(long i=0; i < j; i++)
            {
                if (Jugar(juegos))
                contador ++;
            }
            return contador;
        }
    }

    
}
