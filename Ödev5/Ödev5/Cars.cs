using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev5
{
    public  class Araba
    {
        public string Marka { get; set; }
        public int Yakit { get; set; }

        public Araba(string marka, int yakit)
        {
            Marka = marka;
            Yakit = yakit;
        }

        public string BilgileriGoster()
        {
            return $"{Marka}: {Yakit}L";
        }
    } 



}
