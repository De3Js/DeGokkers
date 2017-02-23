using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace gokkers
{
    public partial class Form1 : Form
    {
        public Player[] players = new Player[4];
        public Flea[] fleas = new Flea[15];
        public string a = "a";
        public string[] names;

        public Form1(string[] names)
        {
            InitializeComponent();
            FillFleas();
            this.names = names;
            MakePlayers();
            
            for (int i = 0; i < players.Length; i++)
            {
                players[i].UpdateLabels();
            }

            for (int i = 0; i < fleas.Length; i++)
            {
                ChoiseList1.Items.Add(fleas[i].name);
            }
            for (int i = 0; i < fleas.Length; i++)
            {
                ChoiseList2.Items.Add(fleas[i].name);
            }
            for (int i = 0; i < fleas.Length; i++)
            {
                ChoiseList3.Items.Add(fleas[i].name);
            }
            for (int i = 0; i < fleas.Length; i++)
            {
                ChoiseList4.Items.Add(fleas[i].name);
            }
        }

        private void Moneybar1_Scroll(object sender, EventArgs e)
        {
            amount1.Text = "" + moneybar1.Value.ToString();
        }

        private void moneybar2_Scroll(object sender, EventArgs e)
        {
            amount2.Text = "" + moneybar2.Value.ToString();
        }

        private void moneybar3_Scroll(object sender, EventArgs e)
        {
            amount3.Text = "" + moneybar3.Value.ToString();
        }

        private void moneybar4_Scroll(object sender, EventArgs e)
        {
            amount4.Text = "" + moneybar4.Value.ToString();
        }

        private void bed_Click(object sender, EventArgs e)
        {
            if(ready1.Checked)
            {
                players[0].PlaceBet();
            }
            else if(ready2.Checked)
            {
                players[1].PlaceBet();
            }
            else if(ready3.Checked)
            {
                players[2].PlaceBet();
            }
            else if(ready4.Checked)
            {
                players[3].PlaceBet();
            }
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer();
            splayer.SoundLocation = "Audio/Race.wav";
            splayer.Load();
            splayer.Play();
            bool finish = false;

            do
            {
                fleas[0].Run(vlooi1);
                fleas[1].Run(vlooi2);
                fleas[2].Run(vlooi3);
                fleas[3].Run(vlooi4);
                fleas[4].Run(vlooi5);
                fleas[5].Run(vlooi6);
                fleas[6].Run(vlooi7);
                fleas[7].Run(vlooi8);
                fleas[8].Run(vlooi9);
                fleas[9].Run(vlooi10);
                fleas[10].Run(vlooi11);
                fleas[11].Run(vlooi12);
                fleas[12].Run(vlooi13);
                fleas[13].Run(vlooi14);
                fleas[14].Run(vlooi15);
                for (int i = 0; i < fleas.Length; i++)
                {
                    if (fleas[i].GetLocation() >= fleas[i].GetRaceTrackLength())
                    {
                        finish = true;
                        splayer.Stop();
                        for (int j = 0; j < players.Length; j++)
                        {
                            players[j].Collect(i);
                        }
                    }
                }
            } while (!finish);
            for (int i = 0; i < fleas.Length; i++)
            {
                fleas[i].TakeStartingPosition();
            }   
        }

        public static string generateName()
        {
            Random r = new Random();
            string[] consonants = {"b","c","d","f","g","h","j","k","l","m","n","p","q","r","s","sh","z","zh",
            "t","v","w","x","y"};
            string[] vowels = { "a", "e", "i", "o", "u" };
            string stringName;
            string[] arrayName = new string[3];
            bool Cons;
            int a = r.Next(0, 1);
            if (a == 1) Cons = true; else Cons = false;
            int i = 0;
            Cons = false;
            while (i < 3)
            {
                if (Cons)
                {
                    arrayName[i] = consonants[r.Next(consonants.Length)];
                    Cons = false;
                    i++;
                }
                else
                {
                    arrayName[i] = vowels[r.Next(vowels.Length)];
                    Cons = true;
                    i++;
                }
            }
            stringName = string.Join("", arrayName);
            return stringName;
        }
        public void MakePlayers()
        {
            players[0] = new Player(names[0], name1, moneybar1, ChoiseList1);
            players[1] = new Player(names[1], name2, moneybar2, ChoiseList2);
            players[2] = new Player(names[2], name3, moneybar3, ChoiseList3);
            players[3] = new Player(names[3], name4, moneybar4, ChoiseList4);
        }
        public void FillFleas()
        {
            for(int i = 0; i < fleas.Length; i++)
            {
                fleas[i] = new Flea(generateName());
            }
        }
    }
}
