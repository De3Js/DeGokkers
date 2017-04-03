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
using System.Media;

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
        public int[] scores = new int[4];
        public int[] position = new int[4];
        private SoundPlayer splayer = new SoundPlayer();

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
            ArrayFiller();
            MakePlayers();
            FillFleas();
            countdown1.Hide();
            countdown2.Hide();
            countdown3.Hide();
            countdownGo.Hide();        
        }
        public void ArrayFiller()
        {
            for (int i = 0; i < scores.Length; i++)
            {
                scores[i] = 0;
            }
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
            if (e.KeyChar == (char)49 && countdown == false)
            {
                fleas[0].Run(vlooi1);
            }
            if (fleas[0].GetLocation() >= fleas[0].GetRaceTrackLength())
            {
                finished = true;
                MessageBox.Show(fleas[0].name + " has won!");
                started = false;
                countdown = true;
                PositionChecker();
                walkBack();
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
                MessageBox.Show(fleas[1].name + " has won!");
                started = false;
                countdown = true;
                PositionChecker();
                walkBack();
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
                MessageBox.Show(fleas[2].name + " has won!");
                started = false;
                countdown = true;
                PositionChecker();
                walkBack();
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
                PositionChecker();
                MessageBox.Show(fleas[3].name + " has won!");
                started = false;
                countdown = true;
                walkBack();
            }
        }
        public void walkBack()
        {
            bool flea1Back = false;
            bool flea2Back = false;
            bool flea3Back = false;
            bool flea4Back = false;
            bool backed = false;
            do
            {
                if (fleas[0].GetLocation() > 4)
                {
                    fleas[0].TakeStartingPosition();
                }
                else
                {
                    flea1Back = true;
                }
                if (fleas[1].GetLocation() > 4)
                {
                    fleas[1].TakeStartingPosition();
                }
                else
                {
                    flea2Back = true;
                }
                if (players.Length == 3)
                {
                    if (fleas[2].GetLocation() > 4)
                    {
                        fleas[2].TakeStartingPosition();
                    }
                    else
                    {
                        flea3Back = true;
                    }
                }
                else if (players.Length == 4)
                {
                    if (fleas[2].GetLocation() > 4)
                    {
                        fleas[2].TakeStartingPosition();
                    }
                    else
                    {
                        flea3Back = true;
                    }
                    if (fleas[3].GetLocation() > 4)
                    {
                        fleas[3].TakeStartingPosition();
                    }
                    else
                    {
                        flea4Back = true;
                    }
                }
                if (flea1Back == true && flea2Back == true && flea3Back == true && flea4Back == true)
                {
                    backed = true;
                }
            } while (!backed);
        }
        public void MakePlayers()
        {
            if (playerAmount == 2)
            {
                players[0] = new Player(names[0], vlooi1);
                players[1] = new Player(names[1], vlooi2);
                vlooi3.Hide();
                vlooi4.Hide();
                playerScore1.Text = players[0].name + " - " + scores[0];
                playerScore2.Text = players[1].name + " - " + scores[1];
                playerScore3.Hide();
                playerScore4.Hide();
            }
            else if(playerAmount == 3)
            {
                players[0] = new Player(names[0], vlooi1);
                players[1] = new Player(names[1], vlooi2);
                players[2] = new Player(names[2], vlooi3);
                vlooi4.Hide();
                playerScore1.Text = players[0].name + " - " + scores[0];
                playerScore2.Text = players[1].name + " - " + scores[1];
                playerScore3.Text = players[2].name + " - " + scores[2];
                playerScore4.Hide();
            }
            else if(playerAmount == 4)
            {
                players[0] = new Player(names[0], vlooi1);
                players[1] = new Player(names[1], vlooi2);
                players[2] = new Player(names[2], vlooi3);
                players[3] = new Player(names[3], vlooi4);
                playerScore1.Text = players[0].name + " - " + scores[0];
                playerScore2.Text = players[1].name + " - " + scores[1];
                playerScore3.Text = players[2].name + " - " + scores[2];
                playerScore4.Text = players[3].name + " - " + scores[3];
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
                splayer.SoundLocation = "Audio/Race2.wav";
                splayer.Load();
                splayer.Play();
                fleas[0].Run(vlooi1);
                fleas[1].Run(vlooi2);
                fleas[2].Run(vlooi3);
                fleas[3].Run(vlooi4);
            }
            if (started == true)
            {
                this.KeyPress +=
               new KeyPressEventHandler(playerPress1_KeyPress);
                this.KeyPress +=
                    new KeyPressEventHandler(playerPress2_KeyPress);
                this.KeyPress +=
                    new KeyPressEventHandler(playerPress3_KeyPress);
                this.KeyPress +=
                    new KeyPressEventHandler(playerPress4_KeyPress);
            }
        }
        private void PositionChecker()
        {
            for (int i = 0; i < fleas.Length; i++)
            {
                position[i] = fleas[i].GetLocation();
            }
            BubbleSort(position);
            for (int j = 0; j < fleas.Length; j++)
            {
                if (position[3] == fleas[j].GetLocation())
                {
                    if(playerAmount == 4)
                        scores[j] += 3;
                    if (playerAmount == 3)
                        scores[j] += 2;
                    if (playerAmount == 2)
                        scores[j] += 1;
                }
                if(position[2] == fleas[j].GetLocation())
                {
                    if (playerAmount == 4)
                        scores[j] += 2;
                    if (playerAmount == 3)
                        scores[j] += 1;
                    if (playerAmount == 2)
                        scores[j] += 0;
                }
                else if(position[1] == fleas[j].GetLocation())
                {
                    if (playerAmount == 4)
                        scores[j] += 1;
                    if (playerAmount == 3)
                        scores[j] += 0;
                    if (playerAmount == 2)
                        scores[j] += 0;


                }
                if(position[0] == fleas[j].GetLocation())
                {
                    if (playerAmount == 4)
                        scores[j] += 0;
                }
            }
            RefreshScoreBoard();
            splayer.Stop();
        }
        private void RefreshScoreBoard()
        {
            playerScore1.Text = players[0].name + " - " + scores[0];
            playerScore2.Text = players[1].name + " - " + scores[1];
            if (players.Length == 3)
            {
                playerScore3.Text = players[2].name + " - " + scores[2];
            }
            else if(players.Length == 4)
            {
                playerScore3.Text = players[2].name + " - " + scores[2];
                playerScore4.Text = players[3].name + " - " + scores[3];
            }
        }
        static int[] BubbleSort(int[] unsorted)
        {
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < unsorted.Length - 1; i++)
                {
                    if (unsorted[i] > unsorted[i + 1])
                    {
                        int temp = unsorted[i];
                        unsorted[i] = unsorted[i + 1];
                        unsorted[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);
            int[] sorted = new int[unsorted.Length];
            sorted = unsorted;
            return sorted;
        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
