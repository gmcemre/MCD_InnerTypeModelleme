﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_InnerTypeModelleme
{
    public class Urun
    {
        public int urunId { get; set; }
        public string  Tanim { get; set; }
        public decimal fiyat { get; set; }

        public Urun()
        {
            Console.WriteLine("Ürün Yapıcı Metot Çalıştı.");
        }

        public void UrunTestMetot()
        {
            Console.WriteLine("UrunTestMetot");
        }
    }
}
