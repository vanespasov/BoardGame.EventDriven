using System;
namespace BoardGame.Core.Models
{

    public class Board
    {
        private OnePointerHole _onePointerHole;
        private TwoPointerHole _twoPointerHole;
        private ThreePointerHole _threePointerHole;
        private FivePointerHole _fivePointerHole;

        public OnePointerHole OnePointerHole { get => _onePointerHole; private set => _onePointerHole = value; }
        public TwoPointerHole TwoPointerHole { get => _twoPointerHole; private set => _twoPointerHole = value; }
        public ThreePointerHole ThreePointerHole { get => _threePointerHole; private set => _threePointerHole = value; }
        public FivePointerHole FivePointerHole { get => _fivePointerHole; private set => _fivePointerHole = value; }

        public Board(OnePointerHole onePointerHole, TwoPointerHole twoPointerHole, ThreePointerHole threePointerHole, FivePointerHole fivePointerHole)
        {
            OnePointerHole = onePointerHole;
            TwoPointerHole = twoPointerHole;
            ThreePointerHole = threePointerHole;
            FivePointerHole = fivePointerHole;

            OnePointerHole.BallEntered += OnePointerHole_BallEntered;
            TwoPointerHole.BallEntered += TwoPointerHole_BallEntered;
            ThreePointerHole.BallEntered += ThreePointerHole_BallEntered;
            FivePointerHole.BallEntered += FivePointerHole_BallEntered;

            OnePointerHole.BallReleased += _onePointerHole_BallReleased;
        }

        private void _onePointerHole_BallReleased(object sender, EventArgs e)
        {
            Console.WriteLine("Last ball released from One pointer hole");
        }

        private void FivePointerHole_BallEntered()
        {
            throw new NotImplementedException();
        }

        private void ThreePointerHole_BallEntered()
        {
            throw new NotImplementedException();
        }

        private void TwoPointerHole_BallEntered()
        {
            throw new NotImplementedException();
        }

        private void OnePointerHole_BallEntered()
        {
            Console.WriteLine("One point ball entered");
        }
    }
}
