using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modularizacion_Miscelanea
{
    public class Ciclos
    {
        public static void ciclos()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Elija la opcion que desea: " +
            "\n1 Multiplos de 3 que hay entre 1 y 100. " +
            "\n2 Numeros impares entre 0 y 100. " +
            "\n3 Numeros pares del 1 al 100. " +
            "\n4 Cuadrado de los numeros del 1 al 30. " +
            "\n5 Sumar cuadrados de los cien primeros numeros naturales. " +
            "\n6 Numeros comprendidos de manera ascendente, con dos numeros naturales. " +
            "\n7 Suma de todos los numeros mientras no sea cero. " +
            "\n9 Salir.");
        }
        public static void punto1(int num1)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Multiplos de 3 que hay entre 1 y 100");
            for (num1 = 3; num1 <= 100; num1 += 3)
            {
                Console.WriteLine("Primer multiplo de 3: " + num1);
            }
        }
        public static void punto2(int num1)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Numeros impares entre 0 y 100");
            for (num1 = 1; num1 <= 100; num1 += 2)
            {
                Console.WriteLine("El numero impar es: " + num1);
            }
        }
        public static void punto3(int num1)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Numeros pares del 1 al 100");
            for (num1 = 2; num1 <= 100; num1 += 2)
            {
                Console.WriteLine("El numero par es: " + num1);
            }
        }
        public static void punto4(int num1)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Cuadrado de los numeros del 1 al 30");
            for (num1 = 1; num1 <= 30; num1++)
            {
                Console.WriteLine("El cuadrado del numero " + num1 + " es: " + Math.Pow(num1, 2));
            }
        }
        public static void punto5(int num1, int num2)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Sumar cuadrados de los cien primeros numeros naturales");
            num2 = 0;
            num1 = 0;
            for (num1 = 0; num1 <= 100; num1++)
            {
                Console.WriteLine("El cuadrado del numero " + num1 + " es: " + Math.Pow(num1, 2));
                num2 = num2 + (int)Math.Pow(num1, 2);
            }
            Console.WriteLine("La suma de todos los numeros es: " + num2);
        }
        public static void punto6(int num1, int num2, int num3)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Numeros comprendidos de manera ascendente, con dos numeros naturales");
            Console.WriteLine("Ingrese dos numeros, el primero menor que el segundo");
            Console.WriteLine("Ingrese un numero");
            num1 = (int)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el otro numero");
            num2 = (int)Convert.ToDouble(Console.ReadLine());
            num3 = 0;
            for (num3 = num1; num3 <= num2; num3++)
            {
                Console.WriteLine("numero " + num3);
            }
        }
        public static void punto7(int num1, int num2)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Suma de todos los numeros mientras no sea cero");
            num1 = 0;
            num2 = 0;
            do
            {
                Console.WriteLine("Ingrese un numero");
                num1 = (int)Convert.ToDouble(Console.ReadLine());
                num2 = num2 + num1;
            } while (num1 != 0);
            Console.WriteLine("La suma de todos los numeros es: " + num2);
        }
        public static void punto9()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Salir");
        }
    }
}
