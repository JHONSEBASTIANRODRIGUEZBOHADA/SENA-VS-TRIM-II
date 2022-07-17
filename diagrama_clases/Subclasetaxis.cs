using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Vehiculos
{
    internal class Subclasetaxis : SubclasePublicos
    {
        private string parrilla;

        public Subclasetaxis(string parrilla) :base("puertas","fuente_combustible_gasolina")
        {
            this.Parrilla = parrilla;
        }

        public string Parrilla { get => parrilla; set => parrilla = value; }
    }
}
