using System;
using System.Threading;
using System.Windows.Forms;
using System.Media;
namespace gokkers
{
    public partial class Form1 : Form
    {
        public Player[] players;
        public Flea[] fleas = new Flea[15];
        public string[] names;
        public bool race = false;
        public int winner;
        public int[] starterMoney;
        int playerAmount;

        public Form1(string[] names, int[] starterMoney, int playerAmount)
        {
            InitializeComponent();

            players = new Player[playerAmount];
            this.names = names;
            this.starterMoney = starterMoney;
            this.playerAmount = playerAmount;

            Start();
        }

        public void Start()
        {
            FillFleas();
            MakePlayers();
            for (int i = 0; i < players.Length; i++)
            {
                players[i].UpdateLabels();
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
        private void startButton_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer();
            splayer.SoundLocation = "Audio/Race.wav";
            splayer.Load();
            splayer.Play();
            bool finish = false;
            bool started = false;

            if (started == false)
            {
                do
                {
                    started = true;
                    startButton.Click -= startButton_Click;
                    race = true;
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
                            started = false;
                            startButton.Click += startButton_Click;
                            splayer.Stop();
                            winner = i;
                            MessageBox.Show("Winner of this race is flea: " + (i + 1).ToString());
                            break;
                        }
                    }
                } while (!finish);
                for (int i = 0; i < players.Length; i++)
                {
                    if (players[i].myBet != null)
                    {
                        players[i].Collect(winner);
                    }
                }
                race = false;

                for (int i = 0; i < fleas.Length; i++)
                {
                    fleas[i].TakeStartingPosition();
                }
            }
        }

        public static string generateName()
        {
            Random r = new Random();
            string[] consonants = {"b","c","d","f","g","h","j","k","l","m","n","p","q","r","s","z",
            "t","v","w","x","y"};
            string[] vowels = { "a", "e", "i", "o", "u" };
            string stringName;
            string[] arrayName = new string[3];
            bool Cons;
            int a = r.Next(0, 1);
            int i = 0;
            Cons = true;
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
            if (playerAmount == 1)
            {
                players[0] = new Player(names[0], name1, moneybar1, comboBox1, moneyLabel1, starterMoney[0]);
                for (int i = 0; i < fleas.Length; i++)
                {
                comboBox1.Items.Add(i + 1 + ". " + fleas[i].name);
                }
                amount1.Text = "5";
                amount2.Text = "5";
                amount3.Text = "5";
                amount4.Text = "5";
                comboBox2.Hide();
                comboBox3.Hide();
                comboBox4.Hide();
                moneyLabel2.Hide();
                moneyLabel3.Hide();
                moneyLabel4.Hide();
                name2.Hide();
                name3.Hide();
                name4.Hide();
                moneybar2.Hide();
                moneybar3.Hide();
                moneybar4.Hide();
                amount2.Hide();
                amount3.Hide();
                amount4.Hide();
                ready2.Hide();
                ready3.Hide();
                ready4.Hide();
            }
            else if (playerAmount == 2)
            {
                players[0] = new Player(names[0], name1, moneybar1, comboBox1, moneyLabel1, starterMoney[0]);
                players[1] = new Player(names[1], name2, moneybar2, comboBox2, moneyLabel2, starterMoney[1]);
                for (int i = 0; i < fleas.Length; i++)
                {
                    comboBox1.Items.Add(i + 1 + ". " + fleas[i].name);
                    comboBox2.Items.Add(i + 1 + ". " + fleas[i].name);
                }
                comboBox3.Hide();
                comboBox4.Hide();
                moneyLabel3.Hide();
                moneyLabel4.Hide();
                name3.Hide();
                name4.Hide();
                moneybar3.Hide();
                moneybar4.Hide();
                amount3.Hide();
                amount4.Hide();
                ready3.Hide();
                ready4.Hide();
            }
            else if (playerAmount == 3)
            {
                players[0] = new Player(names[0], name1, moneybar1, comboBox1, moneyLabel1, starterMoney[0]);
                players[1] = new Player(names[1], name2, moneybar2, comboBox2, moneyLabel2, starterMoney[1]);
                players[2] = new Player(names[2], name3, moneybar3, comboBox3, moneyLabel3, starterMoney[2]);
                for (int i = 0; i < fleas.Length; i++)
                {
                    comboBox1.Items.Add(i + 1 + ". " + fleas[i].name);
                    comboBox2.Items.Add(i + 1 + ". " + fleas[i].name);
                    comboBox3.Items.Add(i + 1 + ". " + fleas[i].name);
                }
                comboBox4.Hide();
                moneyLabel4.Hide();
                name4.Hide();
                moneybar4.Hide();
                amount4.Hide();
                ready4.Hide();
            }
            else if (playerAmount == 4)
            {
                players[0] = new Player(names[0], name1, moneybar1, comboBox1, moneyLabel1, starterMoney[0]);
                players[1] = new Player(names[1], name2, moneybar2, comboBox2, moneyLabel2, starterMoney[1]);
                players[2] = new Player(names[2], name3, moneybar3, comboBox3, moneyLabel3, starterMoney[2]);
                players[3] = new Player(names[3], name4, moneybar4, comboBox4, moneyLabel4, starterMoney[3]);
                for (int i = 0; i < fleas.Length; i++)
                {
                    comboBox1.Items.Add(i + 1 + ". " + fleas[i].name);
                    comboBox2.Items.Add(i + 1 + ". " + fleas[i].name);
                    comboBox3.Items.Add(i + 1 + ". " + fleas[i].name);
                    comboBox4.Items.Add(i + 1 + ". " + fleas[i].name);
                }
            }
        }
        public void FillFleas()
        {
            for(int i = 0; i < fleas.Length; i++)
            {
                fleas[i] = new Flea(generateName());
                Thread.Sleep(50);
            }
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            if (race == false)
            {
                if (ready1.Checked == true)
                {
                    if (players[0].hasBet == false)
                    {
                        players[0].PlaceBet();
                    }
                }
                else if (ready2.Checked == true)
                {
                    if (players[1].hasBet == false)
                    {
                        players[1].PlaceBet();
                    }
                }
                else if (ready3.Checked == true)
                {
                    if (players[2].hasBet == false)
                    {
                        players[2].PlaceBet();
                    }
                }
                else if (ready4.Checked == true)
                {
                    if (players[3].hasBet == false)
                    {
                        players[3].PlaceBet();
                    }
                }
            }            
        }
    }
}