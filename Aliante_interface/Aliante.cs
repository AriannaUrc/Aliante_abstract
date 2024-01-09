using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aliante_interface
{
    public class Aliante : Componente
    {
        int dim = 0;
        public List<Componente> componenti;

        public Aliante()
        {
            componenti = new List<Componente>(100);
        }

        public override string Descrizione()
        {
            string temp = "\n";
            for (int i = 0; i < dim; i++)
            {
                temp += componenti[i].Descrizione() + "\n";
            }

            return temp;
        }

        public override double Costo()
        {
            double temp = 0;
            for (int i = 0; i < dim; i++) 
            {
                temp += componenti[i].Costo();
            }

            return temp;
        }

        public override void Add(Componente comp)
        {
            componenti.Add(comp);
            dim++;
        }
        public override void Remove(int pos)
        {
            for (int i = pos + 1; i < dim; i++)
            {
                componenti[i - 1] = componenti[i];
            }
            componenti.RemoveAt(dim - 1);
            dim--;
        }

        public override Componente getChild(int pos)
        {
            return componenti[pos];
        }
    }
}