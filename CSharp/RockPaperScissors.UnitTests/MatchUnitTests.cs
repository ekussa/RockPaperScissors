using System;
using FluentAssertions;
using NUnit.Framework;

namespace RockPaperScissors.UnitTests
{
    [TestFixture]    
    public class MatchUnitTests
    {
        [TestCase(Move.Paper, Move.Rock)]
        [TestCase(Move.Rock, Move.Scissors)]
        [TestCase(Move.Scissors, Move.Paper)]
        public void ShouldMatch(Move winner, Move loser)
        {
            //Arrange
            var match1 = new Match(
                new ConstantPlayer(winner),
                new ConstantPlayer(loser));
            var match2 = new Match(
                new ConstantPlayer(loser),
                new ConstantPlayer(winner));
            
            //Act
            var result1 = match1.Run();
            var result2 = match2.Run();

            //Assert
            result1.Should().Be(MatchResult.Player1);
            result2.Should().Be(MatchResult.Player2);
        }
        
        [TestCase(Move.Rock, (Move)4)]
        [TestCase((Move)4, Move.Rock)]
        public void ShouldThrowExceptionOnMatchingUnexpectedMove(Move p1, Move p2)
        {
            //Arrange
            var match1 = new Match(
                new ConstantPlayer(p1),
                new ConstantPlayer(p2));
            
            //Act
            try
            {
                match1.Run();

                //Assert
                Assert.Fail();
            }
            catch (Exception)
            {
                Assert.True(true);
            }
        }
    }
}