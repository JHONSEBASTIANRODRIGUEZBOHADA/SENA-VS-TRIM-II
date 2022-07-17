using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Vehiculos
{
    public class PrincipalMain
    {
        public static void Main(string[] args)
        {
            /*SUPERCLASE VEHICULOS*/
            SuperclaseVehiculos datos = new SuperclaseVehiculos("modelo", "marca", "llantas", "color", "motor", "carroceria", "sillas_ascientos", "precio", "luces", "espejos", "sistema_electrico");
            datos.Modelo = "";
            datos.Marca = "";
            datos.Llantas = "";
            datos.Color = "";
            datos.Motor = "";
            datos.Carroceria = "";
            datos.Sillas_ascientos = "";
            datos.Precio = "";
            datos.Luces = "";
            datos.Espejos = "";
            datos.Sistema_electrico = "";
            Console.WriteLine($"MODELO: {datos.Modelo} /nMARCA: {datos.Marca} /nLLANTAS: {datos.Llantas} /nCOLOR: {datos.Color} /nMOTOR: {datos.Motor} /nCARROCERIA: {datos.Carroceria} /nSILLAS ASIENTOS: {datos.Sillas_ascientos} /nPRECIO: {datos.Precio} /nLUCES: {datos.Luces} /nESPEJOS: {datos.Espejos} /nSISTEMA ELECTRICO: {datos.Sistema_electrico}");
                    
            /*SUBCASE TERRESTRE*/
            SubclaseTerrestre datos2 = new SubclaseTerrestre("bateria","paanca_cabios");
            datos2.Bateria = "";
            datos2.Palanca_cambios = "";
            Console.WriteLine($"BATERIA: {datos2.Bateria} /nPALANCA CAMBIOS: {datos2.Palanca_cambios}");

            /*SUBCLASE PUBLICOS*/
            SubclasePublicos datos3 = new SubclasePublicos("puertas", "fuente_combustible_gasolina");
            datos3.Puertas = "";
            datos3.Fuente_combustible_gasolina = "";
            Console.WriteLine($"PUERTAS: {datos3.Puertas} /nFUENTE COMBUSTIBLE GASOLINA: {datos3.Fuente_combustible_gasolina}");

            /*SUBCLASE BUSES*/
            SubclaseBuses datos4 = new SubclaseBuses("escaleras", "sistema_suspencion");
            datos4.Escaleras = "";
            datos4.Sistema_suspencion = "";
            Console.WriteLine($"ESCALERAS: {datos4.Escaleras} /nSISTEMA SUSPENCION: {datos4.Sistema_suspencion}");

            /*SUBCLASE TAXIS*/
            Subclasetaxis datos5 = new Subclasetaxis("parrilla");
            datos5.Parrilla = "";
            Console.WriteLine($"PARRILLA: {datos5.Parrilla}");

            /*SUBCLASE CARGA MERCANCIA*/
            SubclaseCargaMercancia datos6 = new SubclaseCargaMercancia("chasis", "cabina", "sistea_hidrauico");
            datos6.Chasis = "";
            datos6.Cabina = "";
            datos6.Sistema_hidraulico = "";
            Console.WriteLine($"CHASIS: {datos6.Chasis} /nCABINA: {datos6.Cabina} /nSISTEMA HIDRAULICO: {datos6.Sistema_hidraulico}");

            /*SUBCLASE CAMION*/
            SubclaseCamion datos7 = new SubclaseCamion("remolque");
            datos7.Remolque = "";
            Console.WriteLine($"REMOLQUE: {datos7.Remolque}");

            /*SUBCLASE VOLQUETA*/
            SubclaseVolqueta datos8 = new SubclaseVolqueta("cama");
            datos8.Cama = "";
            Console.WriteLine($"CAMA: {datos8.Cama}");

            /*SUBCLASE PARTICULARES*/
            SubclaseParticulares datos9 = new SubclaseParticulares("bujias", "pistones");
            datos9.Bujias = "";
            datos9.Pistones = "";
            Console.WriteLine($"BUJIAS: {datos9.Bujias} /nPISTONES: {datos9.Pistones}");

            /*SUBCLASE CARROS*/
            SubclaseCarros datos10 = new SubclaseCarros("parachoques");
            datos10.Parachoques = "";
            Console.WriteLine($"PARACHOQUES: {datos10.Parachoques}");

            /*SUBCLASE MOTOS*/
            SubclaseMotos datos11 = new SubclaseMotos("manubrio");
            datos11.Manubrio = "";
            Console.WriteLine($"MANUBRIO: {datos11.Manubrio}");
        }
    }
}