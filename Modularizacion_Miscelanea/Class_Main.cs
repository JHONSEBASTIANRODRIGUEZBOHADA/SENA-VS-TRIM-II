using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modularizacion_Miscelanea
{
    public class Class_Main
    {
        public static void Main()
        {
            do
            {
                try
                {
                    int menuprincipal;
                    Menu_Principal.menu_principal();
                    menuprincipal = Convert.ToInt32(Console.ReadLine());
                    switch (menuprincipal)
                    {
                        case 1:
                            Operadores.submenu1_operadores();
                            int submenu1_operadores = Convert.ToInt32(Console.ReadLine());
                            switch (submenu1_operadores)
                            {
                                case 1:
                                    Operadores.punto1(1,2);  
                                    break;
                                case 2:
                                    Operadores.punto2(1, 2);
                                    break;
                                case 3:
                                    Operadores.punto3(1);
                                    break;
                                case 4:
                                    Operadores.punto4(1);
                                    break;
                                case 5:
                                    Operadores.punto5(1);
                                    break;
                                case 6:
                                    Operadores.punto6(1, 2, 3);
                                    break;
                                case 7:
                                    Operadores.punto7(1);
                                    break;
                                case 8:
                                    Operadores.punto8(1, 2, 3);
                                    break;
                                case 9:
                                    Operadores.punto9();
                                    break;
                                default:
                                    {
                                        Console.WriteLine("Dato invalido");
                                        break;
                                    }
                            }
                            break;
                        case 2:
                            Condicionales.condicionales();
                            int submenu2_condicionales = Convert.ToInt32(Console.ReadLine());
                            switch (submenu2_condicionales)
                            {
                                case 1:
                                    Condicionales.punto1(1);
                                    break;
                                case 2:
                                    Condicionales.punto2(1, 2);
                                    break;
                                case 3:
                                    Condicionales.punto3(1, 2, 3);
                                    break;
                                case 4:
                                    Condicionales.punto4(1, 2);
                                    break;
                                case 5:
                                    Condicionales.punto5(1, 2);
                                    break;
                                case 6:
                                    Condicionales.punto6(1, 2);
                                    break;
                                case 7:
                                    Condicionales.punto7(1);
                                    break;
                                case 9:
                                    Condicionales.punto9();
                                    break;
                                default:
                                    {
                                        Console.WriteLine("Dato invalido.");
                                        break;
                                    }
                            }
                            break;

                        case 3:
                            Ciclos.ciclos();
                            int submenu3_Ciclos = Convert.ToInt32(Console.ReadLine());
                            switch (submenu3_Ciclos)
                            {
                                case 1:
                                    Ciclos.punto1(1);
                                    break;
                                case 2:
                                    Ciclos.punto2(1);
                                    break;
                                case 3:
                                    Ciclos.punto3(1);
                                    break;
                                case 4:
                                    Ciclos.punto4(1);
                                    break;
                                case 5:
                                    Ciclos.punto5(1, 2);
                                    break;
                                case 6:
                                    Ciclos.punto6(1, 2, 3);
                                    break;
                                case 7:
                                    Ciclos.punto7(1, 2);
                                    break;
                                case 9:
                                    Ciclos.punto9();
                                    break;
                                default:
                                    {
                                        Console.WriteLine("Dato invalido.");
                                        break;
                                    }
                            }
                            break;
                        case 9:
                            Salir.salir();
                            break;
                        default:
                            Console.WriteLine("Dato invalido.");
                            break;
                    }
                    Console.WriteLine("----------------------");
                    Console.WriteLine("\nPresione una tecla, para ir al MENU PRINCIPAL");
                    Console.ReadKey();
                }catch(FormatException)
                {
                    Console.WriteLine("El dato ingresado, no es un valor numerico.");
                }
            } while (true);
        }
    }
}