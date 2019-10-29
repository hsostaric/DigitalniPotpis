using System.Text;
using System.Security.Cryptography;
using System;

namespace OS2Projekt.Klase
{
    public class SHA512_
    {
        public SHA512Managed serviceProvider { get; set; }
        public SHA512_()
        {
            serviceProvider = new SHA512Managed();

        }

        public string IzracunajSazetak(string ulaz)
        {

            byte[] bajtovi = Pomocna.PretvoriStringUBytove(ulaz);
            serviceProvider.ComputeHash(bajtovi);
            return Pomocna.PretvoriByteUString(serviceProvider.Hash);


        }
    }
}
