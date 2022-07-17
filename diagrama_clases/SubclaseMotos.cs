using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Vehiculos
{
    internal class SubclaseMotos :SubclaseParticulares
    {
        private string manubrio;

        public SubclaseMotos(string manubrio) :base("bujias","pistones")
        {
            this.Manubrio = manubrio;
        }

        public string Manubrio { get => manubrio; set => manubrio = value; }
    }
}
