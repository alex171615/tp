using System.Collections.Generic;
using System;
using System.Linq;
namespace tpBolillero.Core
{
    public class Bolillero
    {
        private List<byte> Adentro {get;set;}
        private List<byte> Afuera {get;set;}
        public IAzar azar{get;set;}

        public Bolillero()
        {
            Adentro=new List<byte>();
            Afuera=new List<byte>();
        }
        public Bolillero(byte n)
        {
            CrearBolillero(n);
        }
        
        public void CrearBolillero(byte n)
        {
            Adentro=new List<byte>();
            Afuera=new List<byte>();
            
            for  (byte i = 0; i < n; i++)
            {
            Adentro.Add(i);
            }
            

        }
        public Reingresar()
        {

        }
        
        public SacarBolilla(byte n);

    }

    
}