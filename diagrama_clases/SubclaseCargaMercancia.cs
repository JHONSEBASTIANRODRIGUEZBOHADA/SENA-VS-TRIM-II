using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Vehiculos
{
    internal class SubclaseCargaMercancia : SubclasePublicos
    {
        private string chasis;
        private string cabina;
        private string sistema_hidraulico;

        public SubclaseCargaMercancia(string chasis, string cabina, string sistema_hidraulico) :base("puertas","fuente_combustible_gasolina")
        {
            this.Chasis = chasis;
            this.Cabina = cabina;
            this.Sistema_hidraulico = sistema_hidraulico;
        }

        public string Chasis { get => chasis; set => chasis = value; }
        public string Cabina { get => cabina; set => cabina = value; }
        public string Sistema_hidraulico { get => sistema_hidraulico; set => sistema_hidraulico = value; }
    }
}
