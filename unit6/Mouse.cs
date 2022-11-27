using System;
using System.Collections.Generic;


namespace Unit06.Game.Casting
{
    /// <summary>
    /// 
    /// </summary>
    public class Mouse : Actor
    {

        private Body body;
        private Animation animation;
        private Point position;

        /// <summary>
        /// Constructs a new instance of Actor.
        /// </summary>
        public Mouse(Body body, Animation animation, bool debug) : base(debug)
        {
            this.body = body;
            this.animation = animation;
        }

        /// <summary>
        /// Gets the animation.
        /// </summary>
        /// <returns>The animation.</returns>
        public Animation GetAnimation()
        {
            return animation;
        }

        public Point GetPosition()
        {
            return position;
        }

        public void SetPosition(Point position)
        {
            this.position = position;
        }

        public Body GetBody()
        {
            return body;
        }

    }
}