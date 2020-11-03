using System;

namespace RockPaperScissors
{
    public class Match
    {
        private readonly IPlayer _player1;
        private readonly IPlayer _player2;

        public Match(IPlayer player1, IPlayer player2)
        {
            _player1 = player1;
            _player2 = player2;
        }

        public MatchResult Run()
        {
            var p1Move = _player1.Play();
            var p2Move = _player2.Play();

            if (p1Move == p2Move)
                return MatchResult.Tie;

            return p1Move switch
            {
                Move.Scissors when p2Move == Move.Paper => MatchResult.Player1,
                Move.Paper when p2Move == Move.Scissors => MatchResult.Player2,
                Move.Paper when p2Move == Move.Rock => MatchResult.Player1,
                Move.Rock when p2Move == Move.Paper => MatchResult.Player2,
                Move.Rock when p2Move == Move.Scissors => MatchResult.Player1,
                Move.Scissors when p2Move == Move.Rock => MatchResult.Player2,
                _ => throw new NotImplementedException($"{p1Move} {p2Move}")
            };
        }
    }
}