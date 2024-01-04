using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aliante_interface
{
    public class Coda : Componente
    {
        private double _costo;
        private double _lunghezza;
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

        public Coda()
        {
            costo = 0;
            lunghezza = 0;
        }

        public Coda(double lunghezza, double costo)
        {
            this.costo = costo;
            this.lunghezza = lunghezza;
        }


        public override string Descrizione()
        {
            return "\nCoda\n-lunghezza: " + lunghezza + "\n-costo: " + costo;
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