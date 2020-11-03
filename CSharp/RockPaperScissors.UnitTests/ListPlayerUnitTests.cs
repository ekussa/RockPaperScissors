using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace RockPaperScissors.UnitTests
{
    [TestFixture]
    public class ListPlayerUnitTests
    {
        [Test]
        public void ShouldPlayListedMoves()
        {
            //Arrange
            var moves = new[]
            {
                Move.Paper,
                Move.Rock,
                Move.Scissors,
                Move.Scissors,
                Move.Rock,
                Move.Paper
            };
            var player = new ListPlayer(moves);
            var result = new List<Move>(moves.Length);
            
            //Act
            for (var i = 0; i < moves.Length; i++)
                result.Add(player.Play());

            //Assert
            result.Should().BeEquivalentTo(moves);
        }
    }
}