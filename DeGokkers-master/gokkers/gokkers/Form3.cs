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
    public partial class Form3 : Form
    {
        public Player[] players;
        public string[] names = new string[4];
        public int playerAmount;
        public string keyChar;

        public Form3()
        {
            InitializeComponent();
            this.KeyPreview = true;

            this.playerAmount = 4;
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = null;
            }
            Start();
        }
        
        public void Start()
        {
            amountBoxFiller();
        }
        private void nameChangeButton_Click(object sender, EventArgs e)
        {
            if (playerAmount == 1)
            {
                if (string.IsNullOrWhiteSpace(nameTextBox1.Text))
                {
                    names[0] = null;
                }
                else
                {
                    names[0] = nameTextBox1.Text;
                }
            }

            else if (playerAmount == 2)
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
            }
            else if (playerAmount == 3)
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
            }
            else if (playerAmount == 4)
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
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (playerAmount == 1)
            {
                if (names[0] != null)
                {
                    Program.SetNextForm(new Form4(names, playerAmount));
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Enter your name");
                }
            }
            else if (playerAmount == 2)
            {
                if (names[0] != null && names[1] != null)
                {
                    Program.SetNextForm(new Form4(names, playerAmount));
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Enter your names");
                }
            }
            else if (playerAmount == 3)
            {
                if (names[0] != null && names[1] != null && names[2] != null)
                {
                    Program.SetNextForm(new Form4(names, playerAmount));
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Enter your names");
                }
            }
            else if (playerAmount == 4)
            {
                if (names[0] != null && names[1] != null && names[2] != null && names[3] != null)
                {
                    Program.SetNextForm(new Form4(names, playerAmount));
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Enter your names");
                }
            }
        }

        public void amountBoxFiller()
        {
            playerAmountBox.Items.Add(2);
            playerAmountBox.Items.Add(3);
            playerAmountBox.Items.Add(4);
            playerAmountBox.SelectedIndex = 2;
        }

        private void setPlayersButton_Click(object sender, EventArgs e)
        {
            playerAmount = Convert.ToInt32(playerAmountBox.Text);
            amountChecker();
        }
        public void amountChecker()
        {
            if (playerAmount == 4)
            {
                nameLabel1.Show();
                nameTextBox1.Show();
                nameLabel2.Show();
                nameTextBox2.Show();
                nameLabel3.Show();
                nameTextBox3.Show();
                nameLabel4.Show();
                nameTextBox4.Show();
                label4.Show();
                label5.Show();
            }
            if (playerAmount < 4)
            {
                nameLabel1.Show();
                nameTextBox1.Show();
                nameLabel2.Show();
                nameTextBox2.Show();
                nameLabel3.Show();
                nameTextBox3.Show();
                nameLabel4.Hide();
                nameTextBox4.Hide();
                label4.Show();
                label5.Hide();
                if (playerAmount < 3)
                {
                    nameLabel1.Show();
                    nameTextBox1.Show();
                    nameLabel2.Show();
                    nameTextBox2.Show();
                    nameLabel3.Hide();
                    nameTextBox3.Hide();
                    nameLabel4.Hide();
                    nameTextBox4.Hide();
                    label4.Hide();
                    label5.Hide();
                }
            }
        }
    }
}
