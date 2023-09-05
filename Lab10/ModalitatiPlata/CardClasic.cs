using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10.ModalitatiPlata
{
    internal class CardClasic : IPlataContactFull
    {
        public void IntroduCardul()
        {
            Console.WriteLine("Introduceti cardul clasic in dispozitiv");
        }

        public void EfectueazaPlata(decimal suma)
        {
            Console.WriteLine($"Plata contact-full in valoare de {suma:C} efectuata cu card clasic");
        }

        public void ExtrageCard()
        {
            Console.WriteLine("Extrageti cardul clasic din dispozitiv");
        }
    }

    public interface IPlataContactFull
    {
        void IntroduCardul();
        void EfectueazaPlata(decimal suma);

        void ExtrageCard();
    }
}
