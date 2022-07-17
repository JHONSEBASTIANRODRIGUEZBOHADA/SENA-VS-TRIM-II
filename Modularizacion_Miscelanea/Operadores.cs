using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modularizacion_Miscelanea
{
    public class Operadores
    {
        public static void submenu1_operadores()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Elija la opcion que desea: " +
            "\n1 Área del triangulo. " +
            "\n2 Suma de dos numeros." +
            " \n3 Numero elevado al cuadrado. " +
            "\n4 Convertir euros a dolares. " +
            "\n5 Area y perimetro de un cuadrado. " +
            "\n6 Area y volumen de un cilindro. " +
            "\n7 Longitud y area de una circunferencia. " +
            "\n8 Promedio de tres numeros. " +
            "\n9 Salir.");
        }
        public static void punto1(int num1, int num2)
        {
                Console.WriteLine("----------------------");
                Console.WriteLine("Área del triangulo");
                Console.WriteLine("Ingrese un numero para la base del triangulo: ");
                num1 = (int)Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese un numero para la altura del triangulo: ");
                num2 = (int)Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("el area del triangulo es : " + (num1 * num2) / 2);
        }
        public static void punto2(int num1, int num2)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Suma de dos numeros");
            Console.WriteLine("Ingrese un numero: ");
            num1 = (int)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero: ");
            num2 = (int)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("el resultado de la suma es : " + (num1 + num2));
        }
        public static void punto3(int num1)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Numero elevado al cuadrado");
            Console.WriteLine("Ingrese un numero: ");
            num1 = (int)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("el resultado del numero al cuadrado es : " + Math.Pow(num1, 2));
        }
        public static void punto4(int num1)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Convertir euros a dolares");
            Console.WriteLine("Ingrese un monto: ");
            num1 = (int)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num1 + " euros a dolares es : " + (num1 * 1.06 + " USD"));
        }
        public static void punto5(int num1)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Area y perimetro de un cuadrado");
            Console.WriteLine("Ingrese un numero para el lado del cuadrado: ");
            num1 = (int)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("el resultado del area del cuadrado es : " + (num1 * 2) + " y el perimetro es: " + (num1 + num1 + num1 + num1));
        }
        public static void punto6(int num1, int num2, int num3)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Area y volumen de un cilindro");
            Console.WriteLine("Ingrese un numero para la altura del cilindro: ");
            num1 = (int)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese un numero para la base del cilindro: ");
            num2 = (int)Convert.ToDouble(Console.ReadLine());
            num3 = (num2 / 2);
            Console.WriteLine("el resultado del area del cilindro es : " + (2 * 3.1416 * num3 * num1) + " y el volumen es: " + ((3.1416 * Math.Pow(num3, 2)) * num1));
        }
        public static void punto7(int num1)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Longitud y area de una circunferencia");
            Console.WriteLine("Ingrese un numero para el radio de la circunferencia: ");
            num1 = (int)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("la longitud de la circunferencia es : " + (2 * 3.1416) * num1 + " y el area es: " + (3.1416 * Math.Pow(num1, 2)));
        }
        public static void punto8(int num1, int num2, int num3)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Promedio de tres numeros");
            Console.WriteLine("Ingrese un numero : ");
            num1 = (int)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero : ");
            num2 = (int)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero : ");
            num3 = (int)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("el promedio de los 3 numeros es : " + (num1 + num2 + num3));
        }
        public static void punto9()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Salir");
        }
    }
}