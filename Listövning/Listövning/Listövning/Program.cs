using System;
using System.Collections.Generic;

namespace Listövning
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> NamnLista = new List<string>();
            //NamnLista.Add("Emil");
            //NamnLista.Add("Simon");
            //NamnLista.Add("Marcus");
            //NamnLista.Add("Mattias");
            //NamnLista.Add("Amanda");
            //NamnLista.Add("Belinda");
            //NamnLista.Add("Cecilia");
            //NamnLista.Add("Elsa");
            //NamnLista.Add("Yan");

            //foreach (string namn in NamnLista)
            //{
            //    Console.WriteLine("Namn: " + namn);
            //}

            string[] namnlistaArray = { "Emil", "Simon", "Marcus", "Mattias", "Amanda", "Belinda", "Cecilia", "Elsa", "Yan" };
            List<string> namnlistaList = new List<string>(namnlistaArray);

            namnlistaList.Sort();
            namnlistaList.Reverse();

            foreach (string namn in namnlistaList)
            {
                Console.WriteLine(namn);
            }

        }
    }
}
