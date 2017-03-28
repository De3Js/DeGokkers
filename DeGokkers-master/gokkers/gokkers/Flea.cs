using System;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace gokkers
{
    public class Flea
    {
        public int RaceTrackLength; //De lengte van de baan
        public PictureBox MyPictureBox = null;
        public Random Randomizer;   //Een instantie van Random (= Willekeurig)
        public Flea[] fleas = new Flea[15];
        public string name;
        public int move;

        public Flea(string name)
        {
            Randomizer = new Random();
            this.name = name;
        }

        public Flea(string name, int move)
        {
            this.name = name;
            this.move = move;
        }

        public bool Run(PictureBox MyPictureBox)
        {
            this.MyPictureBox = MyPictureBox;
            this.RaceTrackLength = 888;
            MyPictureBox.Location = new Point(MyPictureBox.Location.X + move, MyPictureBox.Location.Y);
            Application.DoEvents();
            if (MyPictureBox.Location.X >= RaceTrackLength)
            {
                return true;
            }
            else
            {
                return false;
            }
            //Ga willekeurig 1, 2, 3 of 4 posities
            //Werk de positie van PictureBox bij op het formulier
            //Geef de waarde 'true' terug als ik de race win
        }
        public bool Simulator_Run(PictureBox MyPictureBox)
        {
            this.move = Randomizer.Next(5, 10);
            this.MyPictureBox = MyPictureBox;
            this.RaceTrackLength = 888;
            MyPictureBox.Location = new Point(MyPictureBox.Location.X + move, MyPictureBox.Location.Y);
            Application.DoEvents();
            if (MyPictureBox.Location.X >= RaceTrackLength)
            {
                return true;
            }
            else
            {
                return false;
            }
            //Ga willekeurig 1, 2, 3 of 4 posities
            //Werk de positie van PictureBox bij op het formulier
            //Geef de waarde 'true' terug als ik de race win
        }
        public bool TakeStartingPosition()
        {
            if (MyPictureBox.Location.X <= 4)
            {
                MyPictureBox.Location = new Point(3, MyPictureBox.Location.Y);
                Application.DoEvents();
                return true;
            }
            else
            {
                MyPictureBox.Location = new Point(MyPictureBox.Location.X - 10, MyPictureBox.Location.Y);
                Application.DoEvents();
                return false;
            }
            //Wijzig mijn locatie naar de startlijn.
        }
        public int GetRaceTrackLength()
        {
            return this.RaceTrackLength;
        }
        public int GetLocation()
        {
            return this.MyPictureBox.Location.X;
        }
        public void SetLocation()
        {
            MyPictureBox.Location = new Point(3, MyPictureBox.Location.Y);
        }
    }
}