using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modularizacion_Miscelanea
{
    internal class Cass_Metodos_Get_y_Set
    {
        private int num1;
        private int num2;
        private int num3;

        public Cass_Metodos_Get_y_Set(int num1, int num2, int num3)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.num3 = num3;
        }

        public int getnum1()
        {
            return num1;
        }

        public void setnum1(int num1)
        {
            this.num1 = num1;
        }

        public int getnum2()
        {
            return num2;
        }

        public void setnum2(int num2)
        {
            this.num2 = num2;
        }

        public int getnum3()
        {
            return num3;
        }

        public void setnum3(int num3)
        {
            this.num3 = num3;
        }
    }
}