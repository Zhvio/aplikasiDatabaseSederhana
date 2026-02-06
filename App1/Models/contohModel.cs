using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Models
{
    public class contohModel
    {
        public required int ID { get; set; }
        public required string Nama { get; set; }
        private int _jumlah;
        private int _harga;

        public int Jumlah { get { return _jumlah; } set { if (value < 0) { _jumlah = 0; } else { _jumlah = value; } } }
        public int Harga { get { return _harga; } set { if (value < 0) { _harga = 0; } else { _harga = value;  } } }
    }
}
