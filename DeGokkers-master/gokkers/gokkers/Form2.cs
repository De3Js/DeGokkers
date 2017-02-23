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
            ArrayFiller();
            boxFiller();
        }

        private void nameButton4_Click(object sender, EventArgs e)
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
        public void ArrayFiller()
        {
            chooseStarterMoney[0] = 0;
            chooseStarterMoney[1] = 25;
            chooseStarterMoney[2] = 50;
            chooseStarterMoney[3] = 100;
            chooseStarterMoney[4] = 250;
            chooseStarterMoney[5] = 500;
            chooseStarterMoney[6] = 1000;
            chooseStarterMoney[7] = 5000;
            chooseStarterMoney[8] = 10000;
            chooseStarterMoney[9] = 1000000;
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            if(playerAmount == 1)
            {
                if(names[0] != null)
                {
                    Program.SetNextForm(new Form1(names, starterMoney, playerAmount));
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Enter your name");
                }
            }
            else if(playerAmount == 2)
            {
                if (names[0] != null && names[1] != null)
                {
                    Program.SetNextForm(new Form1(names, starterMoney, playerAmount));
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Enter your names");
                }
            }
            else if(playerAmount == 3)
            {
                if (names[0] != null && names[1] != null && names[2] != null)
                {
                    Program.SetNextForm(new Form1(names, starterMoney, playerAmount));
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Enter your names");
                }
            }
            else if(playerAmount == 4)
            {
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
        public void boxFiller()
        {
            for (int i = 0; i < chooseStarterMoney.Length; i++)
            {
                chooseMoneyBox1.Items.Add(chooseStarterMoney[i]);
                chooseMoneyBox1.SelectedIndex = 0;
                chooseMoneyBox2.Items.Add(chooseStarterMoney[i]);
                chooseMoneyBox2.SelectedIndex = 0;
                chooseMoneyBox3.Items.Add(chooseStarterMoney[i]);
                chooseMoneyBox3.SelectedIndex = 0;
                chooseMoneyBox4.Items.Add(chooseStarterMoney[i]);
                chooseMoneyBox4.SelectedIndex = 0;
            }

            amountPlayers.Items.Add(1);
            amountPlayers.Items.Add(2);
            amountPlayers.Items.Add(3);
            amountPlayers.Items.Add(4);
            amountPlayers.SelectedIndex = 3;
        }

        private void startMoneyButton_Click(object sender, EventArgs e)
        {
            starterMoney[0] = Convert.ToInt32(chooseMoneyBox1.Text);
            starterMoney[1] = Convert.ToInt32(chooseMoneyBox2.Text);
            starterMoney[2] = Convert.ToInt32(chooseMoneyBox3.Text);
            starterMoney[3] = Convert.ToInt32(chooseMoneyBox4.Text);
        }

        private void playerAmountButton_Click(object sender, EventArgs e)
        {
            playerAmount = Convert.ToInt32(amountPlayers.Text);
            amountChecker();
        }
        public void amountChecker()
        {
            if (playerAmount == 4)
            {
                nameLabel1.Show();
                nameTextBox1.Show();
                chooseMoneyBox1.Show();
                nameLabel2.Show();
                nameTextBox2.Show();
                chooseMoneyBox2.Show();
                nameLabel3.Show();
                nameTextBox3.Show();
                chooseMoneyBox3.Show();
                nameLabel4.Show();
                nameTextBox4.Show();
                chooseMoneyBox4.Show();
            }
            if (playerAmount < 4)
            {
                nameLabel1.Show();
                nameTextBox1.Show();
                chooseMoneyBox1.Show();
                nameLabel2.Show();
                nameTextBox2.Show();
                chooseMoneyBox2.Show();
                nameLabel3.Show();
                nameTextBox3.Show();
                chooseMoneyBox3.Show();
                nameLabel4.Hide();
                nameTextBox4.Hide();
                chooseMoneyBox4.Hide();

                if (playerAmount < 3)
                {
                    nameLabel1.Show();
                    nameTextBox1.Show();
                    chooseMoneyBox1.Show();
                    nameLabel2.Show();
                    nameTextBox2.Show();
                    chooseMoneyBox2.Show();
                    nameLabel3.Hide();
                    nameTextBox3.Hide();
                    chooseMoneyBox3.Hide();
                    nameLabel4.Hide();
                    nameTextBox4.Hide();
                    chooseMoneyBox4.Hide();
                    if (playerAmount < 2)
                    {
                        nameLabel1.Show();
                        nameTextBox1.Show();
                        nameLabel2.Hide();
                        nameTextBox2.Hide();
                        chooseMoneyBox2.Hide();
                        nameLabel3.Hide();
                        nameTextBox3.Hide();
                        chooseMoneyBox3.Hide();
                        nameLabel4.Hide();
                        nameTextBox4.Hide();
                        chooseMoneyBox4.Hide();
                    }
                }
            }
        }
    }
}