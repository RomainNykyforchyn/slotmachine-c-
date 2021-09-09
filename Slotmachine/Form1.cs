using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slotmachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        


        private void button1_Click(object sender, EventArgs e)
        {   
            //Gewinn der vorherigen Runde leeren
            Gewinn.Clear();

            //Erste Random
            Random rnd = new Random(); 
            int Zufall1 = rnd.Next(1, 10);
            Nr1.Text = Convert.ToString(Zufall1);

            //Zweite Random
            int Zufall2 = rnd.Next(1, 10);
            Nr2.Text = Convert.ToString(Zufall2);

            //Dritte Random
            int Zufall3 = rnd.Next(1, 10);
            Nr3.Text = Convert.ToString(Zufall3);

            //Randoms vergleichen

            //Wenn alle drei Randoms gleich sind
            if (Zufall1 == Zufall2 && Zufall2 == Zufall3)
            {
                try
                {
                    int einsatz = Convert.ToInt32(Einsatz.Text);
                    int Preis = einsatz * 20;
                    Gewinn.Text = Convert.ToString(Preis);
                    Einsatz.Clear();
                    SoundPlayer simpleSound = new SoundPlayer(Slotmachine.Properties.Resources.click_nice);
                    simpleSound.Play();


                }
                //Fehleingaben abfangen
                catch
                {
                    Einsatz.Text = "Einsatz eingeben";
                }


            }
            //Wenn zwei Randoms gleich sind
            else if (Zufall1 == Zufall2 || Zufall2 == Zufall3 || Zufall1 == Zufall3)
            {
                try
                {
                    int einsatz = Convert.ToInt32(Einsatz.Text);
                    int Preis = einsatz * 2;
                    Gewinn.Text = Convert.ToString(Preis);
                    Einsatz.Clear();
                    SoundPlayer simpleSound = new SoundPlayer(Slotmachine.Properties.Resources.click_nice);
                    simpleSound.Play();
                }
                //Fehleingaben abfangen
                catch
                {
                    Einsatz.Text = "Einsatz eingeben";
                }
            }
            //Wenn alle drei Randoms unterschiedlich sind
            else
            {
                Gewinn.Text = "Nichts";
                Einsatz.Clear();

                
                
            }
        }

        private void Nr2_TextChanged(object sender, EventArgs e)
        {

        }

        private void gewinntext_Click(object sender, EventArgs e)
        {

        }
    }
}
