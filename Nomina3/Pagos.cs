using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomina2
{
    internal class Pagos
    {
        Empleado myEmployee = new Empleado();
        public void Calculate_Payroll()
        {
            StreamWriter File1 = new StreamWriter("text.txt", true);
            bool Error = false;
            while (!Error)
            {
                try
                {
                    Console.WriteLine("\nEnter the document");
                    myEmployee.Document1 = double.Parse(Console.ReadLine());
                    if (!Error)
                    {
                        Console.Write(Environment.NewLine);
                        Error = true;
                        if (myEmployee.Document1 < 0)
                        {
                            Console.WriteLine("ingreso un valor negativo");
                            Error = false;
                        }
                    }
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("ingreso un numero de identificacion muy largo");
                    Error = false;
                }
                catch(FormatException e)
                {
                    Console.WriteLine("no ingreso un valor numerico");
                    Error = false;
                }
            }

            Error = false;
            while (!Error)
            {
                try
                {
                    Console.WriteLine("Enter the first name");
                    myEmployee.First_Name1 = Console.ReadLine();
                    if (!Error)
                    {
                        Console.Write(Environment.NewLine);
                        Error = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("The data entered is incorrect");
                    Error = false;
                }
            }

            Error = false;
            while (!Error)
            {
                try
                {
                    Console.WriteLine("Enter the last name");
                    myEmployee.Last_Name1 = Console.ReadLine();
                    if (!Error)
                    {
                        Console.Write(Environment.NewLine);
                        Error = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("The data entered is incorrect");
                    Error = false;
                }
            }

            Error = false;
            while (!Error)
            {
                try
                {
                    Console.WriteLine("Enter the Salary");
                    myEmployee.Salary1 = double.Parse(Console.ReadLine());
                    if (!Error)
                    {
                        Console.Write(Environment.NewLine);
                        Error = true;
                        if (myEmployee.Salary1 < 0)
                        {
                            Console.WriteLine("ingreso un valor negativo");
                            Error = false;
                        }
                    }
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("ingreso un numero de identificacion muy largo");
                    Error = false;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("no ingreso un valor numerico");
                    Error = false;
                }
            }

            Error = false;
            while (!Error)
            {
                try
                {
                    Console.WriteLine("Enter the worked days");
                    myEmployee.Wroked_Days1 = double.Parse(Console.ReadLine());
                    if (!Error)
                    {
                        Console.Write(Environment.NewLine);
                        Error = true;
                        if (myEmployee.Wroked_Days1 < 0)
                        {
                            Console.WriteLine("ingreso un valor negativo");
                            Error = false;
                        }
                    }
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("ingreso un numero de identificacion muy largo");
                    Error = false;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("no ingreso un valor numerico");
                    Error = false;
                }
            }

            myEmployee.Accrued1 = myEmployee.Salary1 / 30;
            myEmployee.Accrued1 = Math.Round(myEmployee.Accrued1 * myEmployee.Wroked_Days1);

            myEmployee.Transport_Subsidy1 = 117172 / 30;
            myEmployee.Transport_Subsidy1 = myEmployee.Transport_Subsidy1 * myEmployee.Wroked_Days1;

            myEmployee.Healt1 = Math.Round(myEmployee.Accrued1 - myEmployee.Transport_Subsidy1) * 0.04;
            myEmployee.Pension1 = Math.Round(myEmployee.Accrued1 - myEmployee.Transport_Subsidy1) * 0.04;



            if (myEmployee.Accrued1 <= 2000000)
            {
                myEmployee.Transport_Subsidy1 = myEmployee.Transport_Subsidy1 * myEmployee.Wroked_Days1;
                myEmployee.Transport_Subsidy1 = Math.Round(myEmployee.Transport_Subsidy1);
            }
            else
            {
                myEmployee.Accrued1 = myEmployee.Accrued1 + myEmployee.Healt1 + myEmployee.Pension1;
            }

            File1.WriteLine($"\nDocument: {myEmployee.Document1}\nFirst name: {myEmployee.First_Name1}\nLast name: {myEmployee.Last_Name1}\nSalary: {myEmployee.Salary1}\nWorked days: {myEmployee.Wroked_Days1}\nAccrued: {myEmployee.Accrued1}\nHealt: {myEmployee.Healt1}\nPension: {myEmployee.Pension1}");
            File1.Close();
        }

        public void Print_Data()
        {
            Console.WriteLine($"Document:-------------------------------------------- {myEmployee.Document1}");
            Console.WriteLine($"First name:-------------------------------------------- {myEmployee.First_Name1}");
            Console.WriteLine($"Last name:-------------------------------------------- {myEmployee.Last_Name1}");
            Console.WriteLine($"Salary:-------------------------------------------- {myEmployee.Salary1}");
            Console.WriteLine($"Worked days:-------------------------------------------- {myEmployee.Wroked_Days1}");
            Console.WriteLine($"Accrued:-------------------------------------------- {myEmployee.Accrued1}");
            Console.WriteLine($"Healt:-------------------------------------------- {myEmployee.Healt1}");
            Console.WriteLine($"Pension:-------------------------------------------- {myEmployee.Pension1}");
        }

        public void menu()
        {
            Console.WriteLine("\nPAYROLL");
            Console.WriteLine("1.You want to add an employee");
            Console.WriteLine("2.You want to exit the program");
        }
    }
}
