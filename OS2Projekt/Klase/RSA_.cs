using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Xml.Serialization;

namespace OS2Projekt.Klase
{
    public class RSA_
    {

        public static RSACryptoServiceProvider csp = new RSACryptoServiceProvider(2048);
        private RSAParameters _privatniKljuc { get; set; }
        private RSAParameters _javniKljuc { get; set; }
        public string PrivatniKljuc { get; set; }
        public string JavniKljuc { get; set; }
        private RSAPKCS1SignatureFormatter formatter { get; set; }
        private RSAPKCS1SignatureDeformatter deformatter { get; set; }

        public RSA_()
        {

            _privatniKljuc = csp.ExportParameters(true);
            _javniKljuc = csp.ExportParameters(false);
            JavniKljuc = VratiKljuc(_javniKljuc);
            PrivatniKljuc = VratiKljuc(_privatniKljuc);
            Pomocna.zapisiUDatoteku("javni_kljuc.txt", JavniKljuc);
            Pomocna.zapisiUDatoteku("privatni_kljuc.txt", PrivatniKljuc);
            formatter = new RSAPKCS1SignatureFormatter(csp);
            deformatter = new RSAPKCS1SignatureDeformatter(csp);
        }
        public string VratiKljuc(RSAParameters rSA)
        {
            StringWriter sw = new StringWriter();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(RSAParameters));
            xmlSerializer.Serialize(sw, rSA);
            return sw.ToString();
        }


        public string Dekriptiraj(string plainText)
        {

            var dataBytes = Convert.FromBase64String(plainText);
            csp.ImportParameters(_privatniKljuc);
            var plaintext = csp.Decrypt(dataBytes, false);
            return Encoding.UTF8.GetString(plaintext);
        }

        public string Kriptiraj(string plainText)
        {
            csp.ImportParameters(_javniKljuc);
            var data = Encoding.UTF8.GetBytes(plainText);
            var cyper = csp.Encrypt(data, false);
            return Convert.ToBase64String(cyper);
        }

        public string IzradiDigitalniPotpis(string hash)
        {
            formatter.SetHashAlgorithm("SHA512");
            byte[] potpisaniHash = formatter.CreateSignature(Convert.FromBase64String(hash));
            return Pomocna.PretvoriByteUString(potpisaniHash);
        }

        public bool ProvijeriDigitalniPotpis(string hashUlazneDatoteke, string digitalnipotpis)
        {
            deformatter.SetHashAlgorithm("SHA512");
            bool ispravnost = deformatter.VerifySignature(Convert.FromBase64String(hashUlazneDatoteke), Convert.FromBase64String(digitalnipotpis));
            return ispravnost;
        }
    }

}
