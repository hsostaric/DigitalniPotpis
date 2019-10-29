using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OS2Projekt.Klase
{
    public interface IKriptiranje
    {
        byte[] KriptirajTekst(string ulaz, AesCryptoServiceProvider asp);
        string DekriptirajTekst(string pom, AesCryptoServiceProvider asp);
    }
}
