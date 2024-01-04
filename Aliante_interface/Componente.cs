using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aliante_interface
{
    public abstract class Componente
    {
        public abstract void Add(Componente comp);
        public abstract void Remove(int pos);
        public abstract Componente getChild(int pos);
        public abstract double Costo();
        public abstract string Descrizione();
    }
}