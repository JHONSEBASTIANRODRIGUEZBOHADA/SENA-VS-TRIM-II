using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modularizacion_Miscelanea
{
    public class Condicionales
    {
        public static void condicionales()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Elija la opcion que desea: " +
            "\n1 Numero positivo o negativo. " +
            "\n2 Numero mayor y menor. " +
            "\n3 Tres numeros mayor y menor. " +
            "\n4 Dos numeros, sumar si A es menor que B, si no restar. " +
            "\n5 Cociene entre A y B. " +
            "\n6 Dos numeros, sumar si al menos uno es negativo, si no multiplicar. " +
            "\n7 Año biciestro. " +
            "\n9 Salir.");
        }
        public static void punto1(int num1)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Numero positivo o negativo");
            Console.WriteLine("Ingrese un numero: ");
            num1 = (int)Convert.ToDouble(Console.ReadLine());
            if (num1 > 0)
            {
                Console.WriteLine("Positivo");
            }
            else
            {
                Console.WriteLine("Negativo");
            }
        }
        public static void punto2(int num1, int num2)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Numero mayor y menor");
            Console.WriteLine("Ingrese un numero: ");
            num1 = (int)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero: ");
            num2 = (int)Convert.ToDouble(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine("El numero " + num1 + " es igual al numero " + num2 + " por lo tanto, ninguno es mayor o menor que el otro");
            }
            else if (num1 > num2)
            {
                Console.WriteLine("El numero " + num1 + " es mayor, y el numero " + num2 + " es menor");
            }
            else
            {
                Console.WriteLine("El numero " + num1 + " es menor, y el numero " + num2 + " es mayor");
            }
        }
        public static void punto3(int num1, int num2, int num3)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Tres numeros mayor y menor");
            Console.WriteLine("Ingrese un numero: ");
            num1 = (int)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero: ");
            num2 = (int)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese un numero: ");
            num3 = (int)Convert.ToDouble(Console.ReadLine());
            if (num1 < num2 && num1 < num3)
            {
                Console.WriteLine("El numero menor es el: " + num1);
            }
            else if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("El numero mayor es el: " + num1);
            }
            else if (num2 < num1 && num2 < num3)
            {
                Console.WriteLine("El numero menor es el: " + num2);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("El numero mayor es el: " + num2);
            }
            else if (num3 < num2 && num3 < num1)
            {
                Console.WriteLine("El numero menor es el: " + num3);
            }
            else if (num3 > num2 && num3 > num1)
            {
                Console.WriteLine("El numero mayor es el: " + num3);
            }
            else
            {
                Console.WriteLine("hay dos o tres numeros iguales, proceso invalido");
            }
        }
        public static void punto4(int num1, int num2)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Dos numeros, sumar si A es menor que B, si no restar");
            Console.WriteLine("Ingrese un numero: ");
            num1 = (int)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero: ");
            num2 = (int)Convert.ToDouble(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine("No se tiene operacion");
            }
            else if (num1 < num2)
            {
                Console.WriteLine("La suma de los dos numeros es: " + (num1 + num2));
            }
            else
            {
                Console.WriteLine("La resta de los dos numeros es: " + (num1 - num2));
            }
        }
        public static void punto5(int num1, int num2)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Cociene entre A y B");
            Console.WriteLine("Ingrese un numero para el dividendo: ");
            num1 = (int)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero para el divisor: ");
            num2 = (int)Convert.ToDouble(Console.ReadLine());
            if (num2 == 0)
            {
                Console.WriteLine("La division no es posible");
            }
            else
            {
                Console.WriteLine("El cociente de la division es: " + (num1 / num2));
            }
        }
        public static void punto6(int num1, int num2)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Dos numeros, sumar si al menos uno es negativo, si no multilicar");
            Console.WriteLine("Ingrese un numero: ");
            num1 = (int)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero: ");
            num2 = (int)Convert.ToDouble(Console.ReadLine());
            if (num1 < 0)
            {
                Console.WriteLine("La suma de los dos numeros es: " + (num1 + num2));
            }
            else if (num2 < 0)
            {
                Console.WriteLine("La suma de los dos numeros es: " + (num1 + num2));
            }
            else
            {
                Console.WriteLine("La multiplicacion de los dos numeros es: " + (num1 * num2));
            }
        }
        public static void punto7(int num1)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Año biciestro");
            Console.WriteLine("Ingrese el año que desee: ");
            num1 = (int)Convert.ToDouble(Console.ReadLine());
            if (num1 / 4 == 0)
            {
                if (num1 / 100 == 0)
                {
                    if (num1 / 400 == 0)
                    {
                        Console.WriteLine("Si, el año" + num1 + " es un año biciestro");
                    }
                    else
                    {
                        Console.WriteLine("No, el año" + num1 + " no es un año biciestro");
                    }
                }
                else
                {
                    Console.WriteLine("Si, el año" + num1 + " es un año biciestro");
                }
            }
            else
            {
                Console.WriteLine("No, el año" + num1 + " no es un año biciestro");
            }
        }
        public static void punto9()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Salir");
        }
    }
}