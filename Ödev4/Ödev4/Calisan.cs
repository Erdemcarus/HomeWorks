using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev4
{
    public class Calisan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Bölüm { get; set; }
        public string Departman { get; set; }
        public int Maas { get; set; }
    

    public Calisan(string ad, string soyad, string bölüm, string departman, int maas)
        {
            Ad = ad;
            Soyad = soyad;
            Bölüm = bölüm;
            Departman = departman;
            Maas = maas;
        }
        public string BilgileriGöster()
        {

            return $"{Ad} {Soyad} {Bölüm} {Departman} {Maas}";

        }


        
        


    }
}