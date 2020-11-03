using FluentAssertions;
using NUnit.Framework;

namespace RockPaperScissors.UnitTests
{
    [TestFixture]
    public class ConstantPlayerUnitTests
    {
        [TestCase(Move.Rock)]
        [TestCase(Move.Paper)]
        [TestCase(Move.Scissors)]
        public void ShouldPlayTheSameMove(Move move)
        {
            //Assert
            const int max = 1000;
            var player = new ConstantPlayer(move);

            //Act & Assert
            for (var i = 0; i < max; i++)
                player.Play().Should().Be(move);
        }
    }
}