using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Vehiculos
{
    internal class SubclaseVolqueta : SubclaseCargaMercancia
    {
        private string cama;

        public SubclaseVolqueta(string cama) :base("chasis","cabina","sistema_hidraulico")
        {
            this.Cama = cama;
        }

        public string Cama { get => cama; set => cama = value; }
    }
}
