using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomina2
{
    internal class Empleado
    {
        private string Document;
        private string First_Name;
        private string Last_Name;
        private double Salary;
        private double Wroked_Days;
        private double Accrued;
        private double Transport_Subsidy;
        private double Healt;
        private double Pension;

        public Empleado() { }

        public string Document1 { get => Document; set => Document = value; }
        public string First_Name1 { get => First_Name; set => First_Name = value; }
        public string Last_Name1 { get => Last_Name; set => Last_Name = value; }
        public double Salary1 { get => Salary; set => Salary = value; }
        public double Wroked_Days1 { get => Wroked_Days; set => Wroked_Days = value; }
        public double Accrued1 { get => Accrued; set => Accrued = value; }
        public double Transport_Subsidy1 { get => Transport_Subsidy; set => Transport_Subsidy = value; }
        public double Healt1 { get => Healt; set => Healt = value; }
        public double Pension1 { get => Pension; set => Pension = value; }
    }
}
