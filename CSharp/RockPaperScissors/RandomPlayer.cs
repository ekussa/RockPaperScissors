using System;

namespace RockPaperScissors
{
    public class RandomPlayer : IPlayer
    {
        private readonly Random _random;

        public RandomPlayer()
        {
            _random = new Random(DateTime.Now.Millisecond);
        }
        
        public Move Play()
        {
            return (Move)_random.Next(0, 3);
        }
    }
}