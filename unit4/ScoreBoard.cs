using System;

namespace unit04_greed
{
    class ScoreBoard : Actor
    {
        private int _score; 
        public ScoreBoard()
        {

        }
        


        public void SetVelocityF(Point velocity)
        {
            if (velocity == null)
            {
                throw new ArgumentException("velocity can't be null");
            }
            this.velocity = velocity;
        }

    
        public int UpdateScore(int newScore)
        {
            _score = _score + newScore;
            return _score;
        }


    }
}