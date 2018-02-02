using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Symulacja
{
    public partial class Form1 : Form
    {
        Symulacja symulacja = new Symulacja();
        Button[] przyciski = new Button[3];
        int pierwszyWybor = -1;
        int drugiWybor = -1;
        int liczbaGier = 0;
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
