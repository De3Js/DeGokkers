using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace gokkers
{
    public partial class Form4 : Form
    {
        public Player[] players;
        public string[] names;
        public bool race = false;
        public int winner;
        public int playerAmount;
        public Flea[] fleas = new Flea[4];
        public bool countdown = true;
        public bool finished = false;
        public bool started = false;

        public Form4(string[] names, int playerAmount)
        {
            InitializeComponent();

            players = new Player[playerAmount];
            this.names = names;
            this.playerAmount = playerAmount;

            Start();
        }
        public void Start()
        {
            MakePlayers();
            FillFleas();
            countdown1.Hide();
            countdown2.Hide();
            countdown3.Hide();
            countdownGo.Hide();

            this.KeyPress +=
                new KeyPressEventHandler(playerPress1_KeyPress);
            this.KeyPress +=
                new KeyPressEventHandler(playerPress2_KeyPress);
            this.KeyPress +=
                new KeyPressEventHandler(playerPress3_KeyPress);
            this.KeyPress +=
                new KeyPressEventHandler(playerPress4_KeyPress);
        }
        public void DoCountdown()
        {
            countdown3.Show();
            Application.DoEvents();
            Thread.Sleep(1000);
            countdown3.Hide();
            countdown2.Show();
            Application.DoEvents();
            Thread.Sleep(1000);
            countdown2.Hide();
            countdown1.Show();
            Application.DoEvents();
            Thread.Sleep(1000);
            countdown1.Hide();
            countdownGo.Show();
            Application.DoEvents();
            Thread.Sleep(1000);
            countdownGo.Hide();
            Application.DoEvents();
        }
        public void playerPress1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '1' && countdown == false && finished == false)
            {
                fleas[0].Run(vlooi1);
            }
            if (fleas[0].GetLocation() >= fleas[0].GetRaceTrackLength())
            {
                finished = true;
                MessageBox.Show(fleas[0].name + "has won?");
                started = true;
            }
        }
        public void playerPress2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)61 && countdown == false)
            {
                fleas[1].Run(vlooi2);
            }
            if (fleas[1].GetLocation() >= fleas[1].GetRaceTrackLength())
            {
                finished = true;
                MessageBox.Show(fleas[1].name + "has won?");
                started = true;
            }
        }
        public void playerPress3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)122 && countdown == false)
            {
                fleas[2].Run(vlooi3);
            }
            if (fleas[2].GetLocation() >= fleas[2].GetRaceTrackLength())
            {
                finished = true;
                MessageBox.Show(fleas[2].name + "has won?");
                started = true;
            }
        }
        public void playerPress4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)47 && countdown == false)
            {
                fleas[3].Run(vlooi4);
            }
            if (fleas[3].GetLocation() >= fleas[3].GetRaceTrackLength())
            {
                finished = true;
                MessageBox.Show(fleas[3].name + "has won?");
                started = true;
            }
        }
        public void MakePlayers()
        {
            if (playerAmount == 2)
            {
                players[0] = new Player(names[0], vlooi1);
                players[1] = new Player(names[1], vlooi2);
                vlooi3.Hide();
                vlooi4.Hide();
            }
            else if(playerAmount == 3)
            {
                players[0] = new Player(names[0], vlooi1);
                players[1] = new Player(names[1], vlooi2);
                players[2] = new Player(names[2], vlooi3);
                vlooi4.Hide();
            }
            else if(playerAmount == 4)
            {
                players[0] = new Player(names[0], vlooi1);
                players[1] = new Player(names[1], vlooi2);
                players[2] = new Player(names[2], vlooi3);
                players[3] = new Player(names[3], vlooi4);
            }
        }
        public void FillFleas()
        {
            for (int i = 0; i < fleas.Length; i++)
            {
                fleas[i] = new Flea(names[i], 5);
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (started == false)
            {
                DoCountdown();
                countdown = false;
                started = true;
                fleas[0].Run(vlooi1);
                fleas[1].Run(vlooi2);
                fleas[2].Run(vlooi3);
                fleas[3].Run(vlooi4);
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
