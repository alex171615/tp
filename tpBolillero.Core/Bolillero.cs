using System.Collections.Generic;
using System;
using System.Linq;
namespace tpBolillero.Core
{
    public class Bolillero:ICloneable
    {
        public List<byte> Adentro {get;set;}
        public List<byte> Afuera {get;set;}
        public IAzar Azar{get;set;}

       public Bolillero(){}

        public Bolillero(byte numerob) 
            => CrearBolillas(numerob);
        

        public void CrearBolillas(byte numerob)
        {
            Adentro=new List<byte>();
            Afuera=new List<byte>();
            
            for  (byte bol = 0; bol < numerob; bol++)
            {
            Adentro.Add(bol);
            }
            

        }
        public void ReIngresar()
        {
            Adentro.AddRange(Afuera);
            Afuera.Clear();
        }
        

        public byte SacarBolilla()
        {
            byte bolilla = Azar.SacarBolilla(Adentro);
            Adentro.Remove(bolilla);
            Afuera.Add(bolilla);
            return bolilla;
        }


        public bool Jugar(List <byte> juegos) 
        => juegos.TrueForAll(x => x == SacarBolilla());


        public long JugarN(List<byte> bolilla,long j)
        {
            long contador=0;

           {
                ReIngresar();

                if (Jugar(bolilla))
                {
                    contador++;
                }
            }
            return contador;
        }
    }

    
}
