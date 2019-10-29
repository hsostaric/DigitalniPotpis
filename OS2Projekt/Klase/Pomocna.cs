using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS2Projekt.Klase
{
    public class Pomocna
    {
        public Pomocna()
        {

        }
        public static void GenerirajDatoteke()
        {
            if (!File.Exists("tajni_kljuc.txt"))
            {
                File.Create("tajni_kljuc.txt").Close();
            }
            if (!File.Exists("javni_kljuc.txt"))
            {
                File.Create("javni_kljuc.txt").Close();
            }
            if (!File.Exists("privatni_kljuc.txt"))
            {
                File.Create("privatni_kljuc.txt").Close();
            }
        }


        public static string PretvoriByteUString(byte[] niz)
        {
            return Convert.ToBase64String(niz, 0, niz.Length);
        }
        public static void zapisiUDatoteku(string nazivDatoteke, string vrijednost)
        {
            File.WriteAllText(nazivDatoteke, vrijednost);
        }

        public static string UcitajSadrzajDatoteke(string nazivDatoteke)
        {
            return File.ReadAllText(nazivDatoteke);
        }

        public static byte[] PretvoriStringUBytove(string ulaz)
        {

            return Encoding.UTF8.GetBytes(ulaz);

        }

        public static byte[] citajDatotekeuBytu(string nazivDatoteke)
        {
            return Encoding.UTF8.GetBytes(File.ReadAllText(nazivDatoteke));
        }



    }
}
