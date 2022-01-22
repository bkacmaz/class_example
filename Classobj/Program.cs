using System;

namespace Classobj
{

  
    class Program
    {
        static void Main(string[] args)
        {
            
            hesap hsp = new hesap(1,2);
            object tpl=hsp.toplam();

            hsp.verial();
            object tpl3 = hsp.toplam();

            hesap hsp2 = new hesap(1.2, 3.4);
            object tpl2 = hsp2.toplam();

            double deger = (double)tpl2;
            double cikar = hsp2.dcıkar();
           
        }
    }
}
