using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Derajat
    {
        //Program Input
        static void Main(string[] args)//Prosedur
        {
            Console.Write("Masukkan suhu dalam Celcius: ");//Memasukkan data berupa detik
            int input = Convert.ToInt32(Console.ReadLine());//Melakukan Konversi dari Detik menjadi Int64
            KonversiSuhu(input);//Memasukkan inputan kedalam Konversi Waktu
            Console.ReadLine();//Menahan Program
        }

        //Program Output
        static void KonversiSuhu(double suhu)//Prosedur
        {
            double fahrenheit = (suhu * 9 / 5) + 32;
            double reamur = suhu * 4 / 5;
            double kelvin = suhu + 273.15;

            Console.WriteLine($"Hasil konversi:\nFahrenheit : {fahrenheit}°F\nReamur : {reamur}°R\nKelvin : {kelvin}K");
        }
    }
}
