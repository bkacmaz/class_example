using System;
using System.Collections.Generic;
using System.Text;

namespace Classobj
{
    class hesap
    {
        public int inum1;
        int inum2;
        public double dnum1;
        double dnum2;
        //constructor
        bool tip;
        
        public hesap(int n1, int n2)
        {
            inum1 = n1;
            inum2 = n2;
            tip = true;
        }
        public hesap(double n1, double n2)
        {
            dnum1 = n1;
            dnum2 = n2;
            tip = false;
        }
        public object toplam()
        {
            if (tip)
            {
                return inum1 + inum2;
            }
            else
            {
                return dnum1 + dnum2;
            }
            
        }

        public int icıkar()
        {
            return inum1 - inum2;
        }
        public double dcıkar()
        {
            return dnum1 - dnum2;
        }

        public void verial()
        {
            Console.Write("deger1: ");
            inum1=int.Parse(Console.ReadLine());
            Console.Write("deger2: ");
            inum2 = int.Parse(Console.ReadLine());
        }

    }
}
