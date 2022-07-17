using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Vehiculos
{
    internal class SubclaseCamion : SubclaseCargaMercancia
    {
        private string remolque;

        public SubclaseCamion(string remolque) :base("chasis","cabina","sistema_hidraulico")
        {
            this.Remolque = remolque;
        }

        public string Remolque { get => remolque; set => remolque = value; }
    }
}
