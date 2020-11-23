using BoardGame.Core.Interfaces;

namespace BoardGame.Core.Models
{
    /**
     * We'll have balls and board with four holes. 
     * When to emmit event?
     * When a ball enters a hole the board emmits
     * 
     */
    public class Ball:IBall
    {
        private int _value;
        private BallColorEnum _color;
        
        public Ball(int value, BallColorEnum color)
        {
            this._value = value;
            this._color = color;
        }
    }

}
