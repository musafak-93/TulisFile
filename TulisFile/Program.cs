using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TulisFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //deklarasikan variabel untuk menyimpan kalimat
            string data;
            //deklarasikan variabel untuk memberi nama file
            string namaFile;
            try
            {
                //menuliskan nama file
                Console.Write("Nama File : ");
                namaFile = Convert.ToString(Console.ReadLine());
                //Lewatkan folder dan nama file yang akan digunakan untuk menyimpan data
                StreamWriter sw = new StreamWriter("D:\\Tugas\\SEMESTER 6\\Botcamp Pengembangan Aplikasi\\Project\\" + namaFile + ".txt");
                //Masukkan sebuah kalimat
                Console.Write("Tulis kalimat : ");
                data = Convert.ToString(Console.ReadLine());
                //Tulis data tersebut kedalam file
                sw.WriteLine(data);
                //Tutup file nya
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
