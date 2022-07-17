using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Vehiculos
{
    public class SuperclaseVehiculos
    {
        private string modelo;
        private string marca;
        private string llantas;
        private string color;
        private string motor;
        private string carroceria;
        private string sillas_ascientos;
        private string precio;
        private string luces;
        private string espejos;
        private string sistema_electrico;

        public SuperclaseVehiculos(string modelo, string marca, string llantas, string color, string motor, string carroceria, string sillas_ascientos, string precio, string luces, string espejos, string sistema_electrico)
        {
            this.Modelo = modelo;
            this.Marca = marca;
            this.Llantas = llantas;
            this.Color = color;
            this.Motor = motor;
            this.Carroceria = carroceria;
            this.Sillas_ascientos = sillas_ascientos;
            this.Precio = precio;
            this.Luces = luces;
            this.Espejos = espejos;
            this.Sistema_electrico = sistema_electrico;
        }

        public string Modelo { get => modelo; set => modelo = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Llantas { get => llantas; set => llantas = value; }
        public string Color { get => color; set => color = value; }
        public string Motor { get => motor; set => motor = value; }
        public string Carroceria { get => carroceria; set => carroceria = value; }
        public string Sillas_ascientos { get => sillas_ascientos; set => sillas_ascientos = value; }
        public string Precio { get => precio; set => precio = value; }
        public string Luces { get => luces; set => luces = value; }
        public string Espejos { get => espejos; set => espejos = value; }
        public string Sistema_electrico { get => sistema_electrico; set => sistema_electrico = value; }
    }
}