using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Vehiculos
{
    internal class SubclaseBuses : SubclasePublicos
    {
        private string escaleras;
        private string sistema_suspencion;

        public SubclaseBuses(string escaleras, string sistema_suspencion) :base("puertas","fuente_combustible_gasolina")
        {
            this.Escaleras = escaleras;
            this.Sistema_suspencion = sistema_suspencion;
        }

        public string Escaleras { get => escaleras; set => escaleras = value; }
        public string Sistema_suspencion { get => sistema_suspencion; set => sistema_suspencion = value; }
    }
}
