using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace BlackJack.Test
{
    [TestClass]
    public class BlackJackTests
    {
        [TestMethod]
        [DataRow (21, 10 , 10 ,1) ]
        [DataRow (21, 5, 6, 10) ]
        public void IsItBlackJack(int expected, int card1, int card2, int card3)
        {
            var cards = new List<int> { card1, card2, card3};
            var game = new Game();
            //Act
            int actual = game.CheckBlackJack(cards);
            //Assert
            Assert.AreEqual(expected, actual, "Values are not equal");
        }

        [TestMethod]
        public void IsFullSet36Cards()
        {
            var game = new Game();
            var expected = 36;

            //Act
            int actual = game.set.cardset.Count;
            //Assert
            Assert.AreEqual(expected, actual, "Cards are not 36");
        }

    }
}
