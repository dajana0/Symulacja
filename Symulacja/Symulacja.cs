using System;
using System.Collections.Generic;

namespace Symulacja
{
    public class Symulacja
    {
        //tablica z bramkami
        bool[] bramki = { false, false, false };

        //ustawia wszystkie bramki na przegrane
        public void Resetuj()
        {
            for (int x = 0; x < bramki.Length; x++)
            {
                bramki[x] = false;
            }
        }

        //ustawia losową bramkę na wygraną
        public void Przygotuj()
        {
            Random rnd = new Random();
            int losowyNrBramkiWygranej = rnd.Next(0, 2);
            bramki[losowyNrBramkiWygranej] = true;
        }

        //zwraca wygraną bramkę
        public int PobierzBramkeWygrana()
        {
            for (int x = 0; x < bramki.Length; x++)
            {
                if (bramki[x]) return x;
            }
            return -1;
        }

        //zwraca bramkę pustą na podstawie pierwszej wybranej bramki
        public int PobierzBramkePusta(int wybrana_bramka)
        {
            List<int> result = new List<int>();
            for (int x = 0; x < bramki.Length; x++)
            {
                if (x == wybrana_bramka) continue;
                if (!bramki[x]) result.Add(x);
            }
            Random rnd = new Random();
            var index = rnd.Next(0, result.Count - 1);
            return result[index];
        }

    }
}
