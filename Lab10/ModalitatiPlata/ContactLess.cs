using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10.ModalitatiPlata
{
    internal class ContactLess : IPlataContactless,IPlataContactFull
    {
        public void IntroduCardul()
        {
            Console.WriteLine("Apropiați cardul contactless de dispozitiv.");
        }

        public void ApropieCard()
        {
            Console.WriteLine("Introduceti cardul contactless in dispozitiv.");
        }

        public void EfectueazaPlata(decimal suma)
        {
            Console.WriteLine($"Plata in valoare de {suma:C} efectuata cu cardul contactless.");
        }

        public void ExtrageCard()
        {
            Console.WriteLine("Extrageți cardul din dispozitiv.");
        }

       
    }

    public interface IPlataContactless
    {
        void ApropieCard();
        void EfectueazaPlata(decimal suma);
    }


}
