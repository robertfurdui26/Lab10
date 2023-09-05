using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10.ModalitatiPlata
{
    internal class TelefonContactLess : IPlataContactless
    {
        public void ApropieCard()
        {
            Console.WriteLine("Apropiați telefonul mobil de dispozitiv.");
        }

        public void EfectueazaPlata(decimal suma)
        {
            Console.WriteLine($"Plata contactless in valoare de {suma:C} efectuata cu telefonul mobil.");
        }
    }
}
