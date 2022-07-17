using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Vehiculos
{
    internal class SubclaseParticulares :SubclaseTerrestre
    {
        private string bujias;
        private string pistones;

        public SubclaseParticulares(string bujias, string pistones) :base("bateria","palanca_cambios")
        {
            this.Bujias = bujias;
            this.Pistones = pistones;
        }

        public string Bujias { get => bujias; set => bujias = value; }
        public string Pistones { get => pistones; set => pistones = value; }
    }
}