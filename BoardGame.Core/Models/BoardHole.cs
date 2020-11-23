using System;
using System.Collections.Generic;
using BoardGame.Core.Interfaces;

namespace BoardGame.Core.Models
{
    public class BoardHole : IBoardHole
    {
        private int _points = 0;
        private List<IBall> _hole;
        private int _maxNumberOfBalls = 4;
        public BoardHole(int points, int maxBalls)
        {
            _points = points;
            _maxNumberOfBalls = maxBalls;
            _hole = new List<IBall>();
        }

        public delegate void NotifyBallEntered();
        public event NotifyBallEntered BallEntered;
        protected virtual void OnBallEntered()
        {
            BallEntered?.Invoke();
        }

        public void EnterBall(IBall ball)
        {
            if (_hole.Count == _maxNumberOfBalls)
            {
                OnMaxReached(EventArgs.Empty);
                ReleaseLastBall();
            }
            _hole.Add(ball);
            OnBallEntered();
        }       

        public event EventHandler BallReleased;
        private void OnBallReleased(EventArgs e)
        {
            BallReleased?.Invoke(this, e);
        }

        public void ReleaseLastBall()
        {
            IBall ballForReleasing;
            if (_hole.Count > 0)
            {
                ballForReleasing = _hole[_hole.Count - 1];
                _hole.Remove(ballForReleasing);
                OnBallReleased(EventArgs.Empty);
            }
        }

        public event EventHandler MaxReached;
        private void OnMaxReached(EventArgs e)
        {
            MaxReached?.Invoke(this, e);
        }
    }
}
