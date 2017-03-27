using System;
using System.Text;
using System.Collections.Generic;
using gokkers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class FleaTest
    {
        [TestMethod]
        public void TakeStartingPositionTest()
        {
            int location = 500;
            int startingPosition = 4;
            do
            {
                location -= 5;
                Console.WriteLine(location);
            } while (location > startingPosition);
            if (location < startingPosition)
                location = startingPosition;
        }
    }
}
