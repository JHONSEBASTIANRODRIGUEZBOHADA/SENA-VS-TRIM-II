using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Nomina2
{
    internal class Mainprincipal
    {
        public static void Main(string[]args)
        {
            do
            {
                try
                {
                    Pagos mybill = new Pagos();
                    Console.WriteLine("\nPAYROLL");
                    Console.WriteLine("1.You want to add an employee");
                    Console.WriteLine("2.You want to exit the program");
                    int Options = int.Parse(Console.ReadLine());
                    switch (Options)
                    {
                        case 1:
                            mybill.Calculate_Payroll();
                            Console.Clear();
                            mybill.Print_Data();
                            break;

                        case 2:
                            Console.WriteLine("Leaving the program");
                            break;

                        default:
                            Console.WriteLine("Invalid option");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("The data entered is incorrect");
                }
                Console.WriteLine("----------------------");
                Console.WriteLine("\nPresione una tecla, para ir al MENU PRINCIPAL");
                Console.ReadKey();
            }
            while (true);
        }
    }
}
