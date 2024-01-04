using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Aliante_interface
{
    public class Ala : Componente
    {
        private double _costo;
        private double _lunghezza;
        private double _apertura;
        public double costo
        {
            get { return _costo; }
            set
            {
                if (value < 0)
                {
                    _costo = 0;
                }
                else
                {
                    _costo = value;
                }
            }
        }
        public double lunghezza
        {
            get { return _lunghezza; }
            set
            {
                if (value < 0)
                {
                    _lunghezza = 0;
                }
                else
                {
                    _lunghezza = value;
                }
            }
        }

        public double apertura
        {
            get {return _apertura;}
            set
            {
                if(value < 0)
                {
                    _apertura = 0;
                }
                else
                {
                    _apertura = value;
                }
            }
        }

        public override string Descrizione()
        {
            return "\nAla\n-lunghezza: " + lunghezza + "\n-apertura: " + apertura;
        }

        public Ala()
        {
            lunghezza = 0;
            apertura = 0;
            costo = 0;
        }

        public Ala(double lung, double aper, double cost)
        {
            lunghezza = lung;
            apertura = aper;
            costo = cost;
        }
        public override void Add(Componente comp)
        {
            throw new System.NotImplementedException();
        }
        public override void Remove(int pos)
        {
            throw new System.NotImplementedException();
        }

        public override Componente getChild(int pos)
        {
            throw new System.NotImplementedException();
        }

        public override double Costo()
        {
            return costo;
        }

        
    }
}