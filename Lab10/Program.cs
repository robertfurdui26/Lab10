using System;
using Lab10.CasaDeMarcat;
using Lab10.ModalitatiPlata;

namespace Lab10
{
    class Program
    {
        public static void Main(string[] args)
        {
            CasaMarcat casaDeMarcat = new CasaMarcat();

            //plata card clasic

            CardClasic cardClasic = new CardClasic();
            casaDeMarcat.EfectueazaPlataContactFull(cardClasic, 50);

            //plata contact less

            ContactLess contactLess = new ContactLess();
            casaDeMarcat.EfectueazaPlataContactFull(contactLess, 50);
            casaDeMarcat.EfectueazaPlataContactless(contactLess, 80);

            //[lata telefon

            TelefonContactLess telefonContactLess = new TelefonContactLess();
            casaDeMarcat.EfectueazaPlataContactless(telefonContactLess, 90);

        }
    }
}