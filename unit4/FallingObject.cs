using System;

namespace unit04_greed
{
    class FallingObject : Actor
    {
        private Actor _actor;
        public Point _velocity;

        public FallingObject()
        {
            //_velocity = new Point(0,1);            
        }
        public FallingObject(Actor actor)
        {
            _actor = actor;
        }
        public void MoveNext()
        {
            int x = position.GetX() + velocity.GetX();
            int y = position.GetY() + velocity.GetY();
            //Console.WriteLine($"x: {x}");
            //Console.WriteLine($"y: {y}");
            position = new Point(x, y);
        }
        public Actor GetActor()
        {
            return _actor;
        }
    }
}