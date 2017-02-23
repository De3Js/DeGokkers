using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gokkers
{
    public class Player
    {
        public string name; // De naam van de gokker
        public Bet myBet; // Een instantie van Bet()
        public int cash; // Het saldo van de gokker
        //Deze twee velden zijn de gokkers GUI controls op het formulier
        public Label myLabel;
        public TrackBar myTrackBar;
        public ComboBox myComboBox;
        public Label myMoneyLabel;
        public bool hasBet;

        public Player(string name, Label playerLabel, TrackBar myTrackBar, ComboBox myComboBox, Label myMoneyLabel, int cash)
        {
            this.name = name;
            this.myLabel = playerLabel;
            this.myTrackBar = myTrackBar;
            this.myComboBox = myComboBox;
            this.myMoneyLabel = myMoneyLabel;
            this.cash = cash;
        }

        public void UpdateLabels()
        {
            this.myLabel.Text = this.name;
            this.myMoneyLabel.Text = "$ " + this.cash;

            //Verander mijn label in de omschrijving van mijn weddenschap.
            //Verander de label op mijn radioknop zodat deze mijn saldo laat zien.
            //(Bijv. “Lidy heeft 43 euro.”)
        }
        public void UpdateBetLabel()
        {
            this.myLabel.Text = this.name + " has bet " + this.myTrackBar.Value + " dollars on flea " + this.myComboBox.SelectedItem.ToString();
            this.myMoneyLabel.Text = "$ " + this.cash;
        }
        public bool PlaceBet()
        {
            if(this.hasBet == false)
            {
                if(cash >= this.myTrackBar.Value)
                {
                    this.myBet = new Bet(this.myTrackBar.Value, this.myComboBox.SelectedIndex);
                    this.cash -= this.myTrackBar.Value;
                    UpdateBetLabel();
                    this.hasBet = true;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            //Plaats een nieuwe weddenschap en sla het op in de variabele MyBet.
            //Retourneer een true als de gokker genoeg geld heeft om te wedden.
            //Onderstaande regel staat er tijdelijk om foutmeldingen te voorkomen. 
            //Haal deze regel later weg.
        }
        public void ClearBet()
        {
            this.myBet = null;
            this.hasBet = false;
            //Maak de weddenschap leeg.
        }
        public void Collect(int Winner)
        {
            this.cash += this.myBet.PayOut(Winner);
            if (myBet.Dog == Winner)
            {
                MessageBox.Show(this.name + " has won $" + this.myBet.PayOut(Winner).ToString());
            }
            ClearBet();
            UpdateLabels();
            //Betaal mijn weddenschap uit.
            //Maak mijn weddenschap leeg.
            //Werk mijn labels bij.
        }
    }
}