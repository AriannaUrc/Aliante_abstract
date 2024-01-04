using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aliante_interface
{
    public class Fusoliera : Componente
    {
        private double _costo;
        private double _lunghezza;
        private string _materiale;
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

        public string materiale
        {
            get { return _materiale; }
            set
            {
                _materiale = value;
            }
        }


        public Fusoliera()
        {
            lunghezza = 0;
            materiale = "";
            costo = 0;
        }

        public Fusoliera(double lung, string mater, double cost)
        {
            lunghezza = lung;
            materiale = mater;
            costo = cost;
        }

        public override string Descrizione()
        {
            return "\nFusoliera\n-lunghezza: " + lunghezza + "\n-materiale: "+ materiale + "\n-costo: " + costo;
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