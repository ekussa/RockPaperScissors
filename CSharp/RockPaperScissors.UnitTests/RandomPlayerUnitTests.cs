using System;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace RockPaperScissors.UnitTests
{
    [TestFixture]
    public class RandomPlayerUnitTests
    {
        [Test]
        public void ShouldPlayEveryPossibleMove()
        {
            //Arrange
            var count = Enum.GetValues(typeof(Move)).Length;
            var player = new RandomPlayer();
            var playHashSet = new HashSet<Move>(count);
            
            //Act
            for (var i = 0; i < count*10 && playHashSet.Count != count; i++)
            {
                var move = player.Play();
                if (!playHashSet.Contains(move))
                    playHashSet.Add(move);
            }

            //Assert
            (playHashSet.Count == count).Should().BeTrue();
        }
    }
}