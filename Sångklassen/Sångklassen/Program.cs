using System;
using System.Collections.Generic;

namespace Sångklassen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sång förstaSången = new Sång("Magnus Uggla", "Kung för en dag", 203);

            //Console.WriteLine(förstaSången.Artist + "-" + förstaSången.Sångnamn + "(" + förstaSången.Speltid + "s)");

            //Sång andraSången = new Sång("Cornelis Vreeswijk", "Somliga går med trasiga skor", 180);
            //Console.WriteLine("Sången " + andraSången.Sångnamn + " spelas av " + andraSången.Artist + " och den är " + andraSången.Speltid + " sekunder lång.");

            List<Sång> sångLista = new List<Sång>();
            Sång förstaSången = new Sång("Magnus Uggla", "Kung för en dag", 203);
            Sång tredjeSången = new Sång("Peps Persson", "Oh Boy", 244);
            sångLista.Add(förstaSången);
            sångLista.Add(tredjeSången);
            //Console.WriteLine("Vi presenterar låten " + sångLista[0].Sångnamn + " av " + sångLista[0].Artist + "!");

            Sång[] sångVektor = new Sång[2];
            Sång sång1 = new Sång("Magnus Uggla", "Kung för en dag", 203);
            Sång sång3 = new Sång("Peps Persson", "Oh Boy", 244);
            sångVektor[0] = sång1;
            sångVektor[1] = sång3;

            for (int i = 0; i < sångLista.Count; i++)

            {

                Console.WriteLine(sångLista[i].Sångnamn + " av " + sångLista[i].Artist + " (" + sångLista[i].Speltid + "s)");

            }

            foreach (Sång varjeSång in sångVektor)

            {

                Console.WriteLine(varjeSång.Sångnamn + " av " + varjeSång.Artist + " (" + varjeSång.Speltid + "s)");

            }
        }
    }
}
