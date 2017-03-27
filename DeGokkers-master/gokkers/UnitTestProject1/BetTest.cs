using System;
using gokkers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class GokkersTest

    {
        [TestMethod]
        public void PayOutTest()
        {
            int money = 100;
            int inzet = 10;
            int winner = 4;
            int betOn = 3;
            money -= inzet;
            if(winner == betOn)
            {
                money += inzet * 2;
                Console.WriteLine("You won");
                Console.WriteLine(money);

            }
            else
            {
                Console.WriteLine("You Lost");
                Console.WriteLine(money);
            }
        }
    }
}
