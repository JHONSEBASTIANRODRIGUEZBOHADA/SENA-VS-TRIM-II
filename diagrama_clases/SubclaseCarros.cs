using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Vehiculos
{
    internal class SubclaseCarros : SubclaseParticulares
    {
        private string parachoques;

        public SubclaseCarros(string parachoques) :base("bujias","pistones")
        {
            this.Parachoques = parachoques;
        }

        public string Parachoques { get => parachoques; set => parachoques = value; }
    }
}
