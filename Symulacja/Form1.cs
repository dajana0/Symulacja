using System;
using System.Drawing;
using System.Windows.Forms;

namespace Symulacja
{
    public partial class Form1 : Form
    {
        Symulacja symulacja = new Symulacja();
        Button[] przyciski = new Button[3]; //tablica z bramkami
        int pierwszyWybor = -1;  //numer pierwszej wybranej bramki
        int drugiWybor = -1; //numer drugiej wybranej bramki
        int liczbaGier = 0; // liczba wszystkich rozegranych gier
        int wygranePierwotnyWybor = 0;
        int wygraneZmienionyWybor = 0;
        int przegranePierwotnyWybor = 0;
        int przegraneZmienionyWybor = 0;

        public Form1()
        {
            InitializeComponent();
            symulacja.Przygotuj();
            przyciski[0] = bramka1;
            przyciski[1] = bramka2;
            przyciski[2] = bramka3;
        }

        //metoda kliknięcia bramki nr 1
        private void bramka1_Click(object sender, EventArgs e)
        {
            if (pierwszyWybor==-1)
            {
                pierwszyWybor = 0;
                int pustaBramka = symulacja.PobierzBramkePusta(0);
                przyciski[pustaBramka].Text = "PUSTA";
                przyciski[pustaBramka].Enabled = false;

            }
            else if ( drugiWybor ==-1)
            {
                drugiWybor = 0;
                int wygrana = symulacja.PobierzBramkeWygrana();
                przyciski[wygrana].Text = "NAGRODA";
                przyciski[wygrana].ForeColor = Color.Green;
                KoniecGry();
            }
        }
        //metoda kliknięcia bramki nr 2
        private void bramka2_Click(object sender, EventArgs e)
        {
            if (pierwszyWybor == -1)
            {
                pierwszyWybor = 1;
                int pustaBramka = symulacja.PobierzBramkePusta(1);
                przyciski[pustaBramka].Text = "PUSTA";
                przyciski[pustaBramka].Enabled = false;

            }
            else if (drugiWybor == -1)
            {
                drugiWybor = 1;
                int wygrana = symulacja.PobierzBramkeWygrana();
                przyciski[wygrana].Text = "NAGRODA";
                przyciski[wygrana].ForeColor = Color.Green;
                KoniecGry();
            }
        }
        //metoda kliknięcia bramki nr 3
        private void bramka3_Click(object sender, EventArgs e)
        {
            if (pierwszyWybor == -1)
            {
                pierwszyWybor = 2;
                int pustaBramka = symulacja.PobierzBramkePusta(2);
                przyciski[pustaBramka].Text = "PUSTA";
                przyciski[pustaBramka].Enabled = false;

            }
            else if (drugiWybor == -1)
            {
                drugiWybor = 2;
                int wygrana = symulacja.PobierzBramkeWygrana();
                przyciski[wygrana].Text = "NAGRODA";
                przyciski[wygrana].ForeColor = Color.Green;
                KoniecGry();
            }
        }

        //Aktualizacja wyników
        private void KoniecGry()
        {
            lbLiczbaGier.Text = (++liczbaGier).ToString();
            int wygrana = symulacja.PobierzBramkeWygrana();
            if(pierwszyWybor == drugiWybor && drugiWybor == wygrana)
            {
                lbWygranePierwotnyWybor.Text = (++wygranePierwotnyWybor).ToString(); ;
            }
            else if(pierwszyWybor == drugiWybor && drugiWybor != wygrana)
            {
                lbPrzegranePierwotnyWybor.Text = (++przegranePierwotnyWybor).ToString();
            }
            else if (pierwszyWybor != drugiWybor && drugiWybor == wygrana)
            {
                lbWygraneZmienionyWybor.Text = (++wygraneZmienionyWybor).ToString();
            }
            else if (pierwszyWybor != drugiWybor && drugiWybor != wygrana)
            {
                lbPrzegraneZmienionyWybor.Text = (++przegraneZmienionyWybor).ToString();
            }
            double procentWygranychGierZmieniajacWybor = ((double)wygraneZmienionyWybor * 100)/(double)liczbaGier;
            procentWygranychGierZmieniajacWybor = Math.Round(procentWygranychGierZmieniajacWybor, 2);
            lbProcent.Text = procentWygranychGierZmieniajacWybor.ToString() + "%";
        }
        
        //rozpoczęcie nowej gry i wylosowanie nowej bramki z nagrodą.
        private void btNowaGra_Click(object sender, EventArgs e)
        {
            if (drugiWybor != -1)
            {
                symulacja.Resetuj();
                symulacja.Przygotuj();
                pierwszyWybor = -1;
                drugiWybor = -1;
                for(int x = 0; x <przyciski.Length; x++)
                {
                    przyciski[x].Text = "Bramka " + (x + 1).ToString();
                    przyciski[x].ForeColor = Color.Black;
                    przyciski[x].Enabled = true;
                }
            }
        }
    }
}
