using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Vehiculos
{
    internal class SubclasePublicos : SubclaseTerrestre
    {
        private string puertas;
        private string fuente_combustible_gasolina;

        public SubclasePublicos(string puertas, string fuente_combustible_gasolina) :base("bateria","palanca_cambios")
        {
            this.Puertas = puertas;
            this.Fuente_combustible_gasolina = fuente_combustible_gasolina;
        }

        public string Puertas { get => puertas; set => puertas = value; }
        public string Fuente_combustible_gasolina { get => fuente_combustible_gasolina; set => fuente_combustible_gasolina = value; }
    }
}