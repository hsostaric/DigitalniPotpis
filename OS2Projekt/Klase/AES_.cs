using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace OS2Projekt.Klase
{
    public class AES_
    {
        public AesCryptoServiceProvider serviceProvider { get; set; }

        public AES_()
        {
            this.postaviPocetneParametre();
        }
        public void postaviPocetneParametre()
        {
            serviceProvider = new AesCryptoServiceProvider();




            serviceProvider.BlockSize = 128;
            serviceProvider.KeySize = 256;
            serviceProvider.Padding = PaddingMode.PKCS7;
            serviceProvider.Mode = CipherMode.CFB;
            serviceProvider.GenerateIV();
            serviceProvider.GenerateKey();


            Pomocna.zapisiUDatoteku("tajni_kljuc.txt", Pomocna.PretvoriByteUString(serviceProvider.Key));
        }


        public byte[] KriptirajTekst(string ulaz, AesCryptoServiceProvider asp)
        {
            byte[] kriptirano = null;

            ICryptoTransform cryptoTransform = serviceProvider.CreateEncryptor(serviceProvider.Key, serviceProvider.IV);
            using (MemoryStream msEncrypt = new MemoryStream())
            {
                using (CryptoStream csEnrypt = new CryptoStream(msEncrypt, cryptoTransform, CryptoStreamMode.Write))
                {
                    using (StreamWriter swEncrypt = new StreamWriter(csEnrypt))
                    {
                        swEncrypt.Write(ulaz);

                    }
                    kriptirano = msEncrypt.ToArray();
                }
            }
            return kriptirano;
        }

        public string DekriptirajTekst(string pom, AesCryptoServiceProvider asp)
        {
            string izlaz = null;
            byte[] pom1 = Convert.FromBase64String(pom);

            ICryptoTransform decryptor = serviceProvider.CreateDecryptor(serviceProvider.Key, serviceProvider.IV);

            using (MemoryStream msDecrypt = new MemoryStream(pom1))
            {
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                {
                    using (StreamReader streamReader = new StreamReader(csDecrypt))
                    {
                        izlaz = streamReader.ReadToEnd();
                    }
                }
            }

            return izlaz;
        }

    }
}
