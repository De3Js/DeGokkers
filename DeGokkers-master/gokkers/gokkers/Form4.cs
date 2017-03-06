using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gokkers
{
    public partial class Form4 : Form
    {
        public Player[] players;
        public string[] names;
        public bool race = false;
        public int winner;
        public int playerAmount;
        Flea[] fleas = new Flea[4];

        public Form4(string[] names, int playerAmount)
        {
            InitializeComponent();

            players = new Player[playerAmount];
            this.names = names;
            this.playerAmount = playerAmount;
        }
        public void Start()
        {
            MakePlayers();
            FillFleas();
        }
        public void playerPress1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 49)
            {

            }
        }
        public void playerPress2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 61)
            {

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
                fleas[i] = new Flea(names[i]);
            }
        }
    }
}
