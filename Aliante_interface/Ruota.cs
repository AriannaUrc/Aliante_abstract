using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aliante_interface
{
    public class Ruota : Componente
    {
        private double _costo;
        private double _lunghezza;
        private double _altezza;
        private int _pollici_materiale;
        private double _raggio;

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

        public double altezza
        {
            get { return _altezza; }
            set
            {
                if (value < 0)
                {
                    _altezza = 0;
                }
                else
                {
                    _altezza = value;
                }
            }
        }

        public int pollici_materiale
        {
            get { return _pollici_materiale; }
            set
            {
                if (value < 0)
                {
                    _pollici_materiale = 0;
                }
                else
                {
                    _pollici_materiale = value;
                }
            }
        }

        public double raggio
        {
            get { return _raggio; }
            set
            {
                if (value < 0)
                {
                    _raggio = 0;
                }
                else
                {
                    _raggio = value;
                }
            }
        }


        public Ruota()
        {
            this.lunghezza = 0;
            this.altezza = 0;
            this.pollici_materiale = 0;
            this.raggio = 0;
            this.costo = 0;
        }
        public Ruota(double lunghezza, double altezza, int pollici_materiale, double raggio, double costo)
        {
            this.lunghezza = lunghezza;
            this.altezza = altezza;
            this.pollici_materiale = pollici_materiale;
            this.raggio = raggio;
            this.costo = costo;
        }

        public override string Descrizione()
        {
            return "\nRuota\n-lunghezza: " + lunghezza + "\n-altezza: " + altezza + "\n-pollici_materiale: " + pollici_materiale + "\n-raggio: " + raggio + "\n-costo: " + costo;
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