namespace RockPaperScissors
{
    public class ConstantPlayer : IPlayer
    {
        private readonly Move _move;

        public ConstantPlayer(Move move)
        {
            _move = move;
        }
        
        public Move Play()
        {
            return _move;
        }
    }
}