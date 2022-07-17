using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Vehiculos
{
    public class SubclaseTerrestre : SuperclaseVehiculos
    {
        private string bateria;
        private string palanca_cambios;

        public SubclaseTerrestre(string bateria, string palanca_cambios) :base("modelo", "marca", "llantas", "color", "motor", "carroceria", "sillas_ascientos", "precio", "luces", "espejos", "sistema_electrico")
        {
            this.Bateria = bateria;
            this.Palanca_cambios = palanca_cambios;
        }

        public string Bateria { get => bateria; set => bateria = value; }
        public string Palanca_cambios { get => palanca_cambios; set => palanca_cambios = value; }
    }
}