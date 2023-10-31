using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        //Naming convention --> isimlendirme kuralları Metotlar isimlendirilirken büyük harfle yazılır.
        public void Ekle(Urun urun)
        {

            Console.WriteLine("Tebrikler.Sepete eklendi:"+urun.Adi);
        }
    }
}
