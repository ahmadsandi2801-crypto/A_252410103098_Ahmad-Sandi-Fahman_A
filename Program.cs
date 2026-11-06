using System;

namespace Sekolah
{
    public class Sekolah
    {
        public string idSekolah { get; set; }
        public string namaSekolah { get; set;}
        public int jumlahPaketDiterima { get; set;}
    }
    public class Sekolah(string idSekolah, string namaSekolah, int jumlahPaketDiterima)
    {
        this.idSekolah = idSekolah;
        this.namaSekolah = namaSekolah;
        this.jumlahPaketDiterima = jumlahPaketDiterima;
    }
}
