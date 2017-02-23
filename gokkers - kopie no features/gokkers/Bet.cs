using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gokkers
{
    public class Bet
    {
        public int Amount; //Het bedrag van de weddenschap.
        public int Dog;    //Het nummer van de hond waarop weddenschap is afgesloten.
        public Player Bettor; //De gokker die gewed heeft.

        public Bet(int Amount, int Dog)
        {
            this.Amount = Amount;
            this.Dog = Dog;
        }
        public string GetDiscription()
        {
            string Description;
            if (Amount == 0)
            {
                Description = Bettor.name + "heeft geen weddenschap geplaatst";
            }
            Description = Bettor.name + "wedt" + Amount + " euro  op vlo " + Dog;
            //Retourneer een string die aangeeft wie de weddenschap heeft gedaan,
            //voor welk bedrag er is gewed en op welke hond er is gewed.
            //Bijv. “Sietse wedt 8 euro op hond 4”.
            //Als het bedrag 0 is, is er geen weddenschap geplaatst.
            //De string die dan geretourneerd wordt is bijv.
            //“Sietse heeft geen weddenschap geplaatst.”)
            return Description;
        }
        public int PayOut(int winner)
        {
            if(winner == Dog)
            {
                return Amount*2;
            }
            else
            {
                return 0;
            }
            //De parameter van deze methode is de winnar van de race.
            //Als de hond gewonnen heeft, retourneer dan het bedrag dat gewed is.
            //Anders, retourneer het tegengestelde van het gewedde bedrag.   
        }
    }
}
