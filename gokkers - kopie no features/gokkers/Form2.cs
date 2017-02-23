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
    public partial class Form2 : Form
    {
        public Player[] players;
        public string[] names = new string[4];
        public int[] starterMoney = new int[4];
        public int[] chooseStarterMoney = new int[10];
        public int playerAmount;

        public Form2()
        {
            InitializeComponent();

            this.playerAmount = 4;

            for (int i = 0; i < names.Length; i++)
            {
                names[i] = null;
            }
        }
        private void nameButton4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox1.Text))
            {
                names[0] = null;
            }
            else
            {
                names[0] = nameTextBox1.Text;
            }
            if (string.IsNullOrWhiteSpace(nameTextBox2.Text))
            {
                names[1] = null;
            }
            else
            {
                names[1] = nameTextBox2.Text;
            }
            if (string.IsNullOrWhiteSpace(nameTextBox3.Text))
            {
                names[2] = null;
            }
            else
            {
                names[2] = nameTextBox3.Text;
            }
            if (string.IsNullOrWhiteSpace(nameTextBox4.Text))
            {
                names[3] = null;
            }
            else
            {
                names[3] = nameTextBox4.Text;
            }
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            if (names[0] != null)
            {
                Program.SetNextForm(new Form1(names, starterMoney, playerAmount));
                this.Close();
            }
            else
            {
                MessageBox.Show("Enter your name");
            }
            if (names[0] != null && names[1] != null)
            {
                Program.SetNextForm(new Form1(names, starterMoney, playerAmount));
                this.Close();
            }
            else
            {
                MessageBox.Show("Enter your names");
            }
            if (names[0] != null && names[1] != null && names[2] != null)
            {
                Program.SetNextForm(new Form1(names, starterMoney, playerAmount));
                this.Close();
            }
            else
            {
                MessageBox.Show("Enter your names");
            }
            if (names[0] != null && names[1] != null && names[2] != null && names[3] != null)
            {
                Program.SetNextForm(new Form1(names, starterMoney, playerAmount));
                this.Close();
            }
            else
            {
                MessageBox.Show("Enter your names");
            }
        }
    }
}