using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoardGame.Core.Interfaces;

namespace BoardGame.Core.Models
{
    public class Game : IGame
    {
        private Board _board;
        private List<Ball> _ballsOnBoard;
        private int _maxBallsOnBoard;

        public Game(Board board, int maxNumberOfBall)
        {
            this._board = board;
            this._maxBallsOnBoard = maxNumberOfBall;
            this._ballsOnBoard = new List<Ball>();
        }

        public void Init()
        {
            Array values = Enum.GetValues(typeof(BallColorEnum));
            Random random = new Random();

            for (int i = 0; i < _maxBallsOnBoard; i++)
            {
                Ball b = new Ball(i, (BallColorEnum)values.GetValue(random.Next(values.Length)));
                this._ballsOnBoard.Add(b);
            }
        }

        public void Play()
        {
            Random random = new Random();

            //simulation of randomly filling the holes with balls
            foreach (var ball in _ballsOnBoard)
            {                
                switch (random.Next())
                {
                    case 2:
                        _board.TwoPointerHole.EnterBall(ball);
                        break;
                    case 3:
                        _board.ThreePointerHole.EnterBall(ball);
                        break;
                    case 5:
                        _board.OnePointerHole.EnterBall(ball);
                        break;
                    default:
                        _board.OnePointerHole.EnterBall(ball);
                        break;
                }
            }
        }
    }
}
