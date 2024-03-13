using System;

namespace Program
{
    class Konversi
    {
        //Program Input
        static void Main(string[] args)//Prosedur
        {
            Console.Write("Masukkan jumlah detik: ");//Memasukkan data berupa detik
            int detikInput = Convert.ToInt16(Console.ReadLine());//Melakukan Konversi dari Detik menjadi Int64
            KonversiWaktu(detikInput);//Memasukkan inputan kedalam Konversi Waktu
            Console.ReadLine();//Menahan Program
        }

        //Program Output
        static void KonversiWaktu(int detik)//Prosedur
        {
            int jam, menit, detikSisa;//Deklarasi Variabel
            jam = detik / 3600;//Deklarasi untuk jam
            detikSisa = detik % 3600;//Konversi untuk sisa detik yang dimoduluskan 3600
            menit = detikSisa / 60;//Deklarasi untuk menit
            detikSisa %= 60;//Deklarasi detik

            Console.WriteLine($"Hasil konversi: {jam} jam, {menit} menit, {detikSisa} detik");//Output
        }
    }
}
