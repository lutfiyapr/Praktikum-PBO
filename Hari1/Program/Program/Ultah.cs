using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Ultah
    {
        static void Main(String[] args)
        {
            ushort hari, bulan, tahun;
            Console.WriteLine("Hitung Usia");
            Console.WriteLine("-----------");
            try
            {
                Console.Write("Tanggal Lahir\t : ");
                hari = Convert.ToUInt16(Console.ReadLine());
                Console.Write("Bulan Lahir\t : ");
                bulan = Convert.ToUInt16(Console.ReadLine());
                Console.Write("Tahun Lahir\t : ");
                tahun = Convert.ToUInt16(Console.ReadLine());

                DateTime ultah = new DateTime(tahun, bulan, hari);
                DateTime hariIni = DateTime.Now;

                TimeSpan usia = hariIni.Subtract(ultah);
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Umur kamu adalah {0} hari, {1} jam, {2} menit.", usia.Days, usia.Hours, usia.Minutes);
            }
            catch (FormatException e1)
            {
                Console.WriteLine("Data tanggal, bulan, tahun harus berupa angka.");
            }
            catch (Exception e2)
            {
                Console.WriteLine("Terjadi kesalahan: " + e2.Message);
            }
            Console.ReadKey();
        }
    }
}