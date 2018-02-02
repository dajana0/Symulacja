using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Symulacja
{
    public class Symulacja
    {
        //tablica z bramkami
        bool[] bramki = { false, false, false };

        public void Resetuj()
        {
            for (int x = 0; x < bramki.Length; x++)
            {
                bramki[x] = false;
            }
        }

        public void Przygotuj()
        {
            Random rnd = new Random();
            int losowyNrBramkiWygranej = rnd.Next(0, 2);
            bramki[losowyNrBramkiWygranej] = true;
        }

        public int PobierzBramkeWygrana()
        {
            for (int x = 0; x < bramki.Length; x++)
            {
                if (bramki[x]) return x;
            }
            return -1;
        }

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
