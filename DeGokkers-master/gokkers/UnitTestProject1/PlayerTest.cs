using System;
using System.Text;
using System.Collections.Generic;
using gokkers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class PlayerTest
    {
        [TestMethod]
        public void CollectTest()
        {
            int money = 100;
            int profit = 50;
            int winner = 4;
            int betOn = 3;
            if (winner == betOn)
            {
                money += profit;
                Console.WriteLine("You won {0} and your money now is {1}", profit, money);
            }
            else
            {
                Console.WriteLine("You lost");
            }
        }
    }
}
