namespace RockPaperScissors
{
    public class ListPlayer : IPlayer
    {
        private readonly Move[] _moves;
        private int _index;

        public ListPlayer(Move[] moves)
        {
            _moves = moves;
        }

        public Move Play()
        {
            if (_index < _moves.Length)
                return _moves[_index++];
            
            _index = 0;
            return _moves[_index];
        }
    }
}