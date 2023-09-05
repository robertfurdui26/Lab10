using Lab10.ModalitatiPlata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10.CasaDeMarcat
{
    class CasaMarcat
    {
        private bool Seif = false;

        public void DeschideSeif()
        {
            Seif = true;
            Console.WriteLine("Seiful a fost deschis...");
        }

       
 
        public void IntroduSumaSeif(decimal suma)
        {
            Console.WriteLine($"Am introdus {suma} in seif");
        }

        public void InchideSeif()
        {
            Seif = false;
            Console.WriteLine("Seif inchis..");
        }


        public void ElibereazaChitanta(decimal sumaChitanta)
        {
            Console.WriteLine($"Chitanta cu suma de {sumaChitanta} a fost eliberata.");
        }

        public POS OferaPOS()
        {
            Console.WriteLine("Ofera POS Clientului...");
            return new POS();
        }

        public void EfectueazaPlataContactFull(IPlataContactFull dispozitiv, decimal suma)
        {
            dispozitiv.IntroduCardul();
            dispozitiv.EfectueazaPlata(suma);
            dispozitiv.ExtrageCard();
        }

        public void EfectueazaPlataContactless(IPlataContactless dispozitiv, decimal suma)
        {
            dispozitiv.ApropieCard();
            dispozitiv.EfectueazaPlata(suma);
        }
    }
}
