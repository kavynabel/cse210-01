using System;
using System.Collections.Generic;
using System.Linq;


namespace Unit05.Game.Casting
{
    /// <summary>
    /// <para>A tasty item that snakes like to eat.</para>
    /// <para>
    /// The responsibility of Food is to select a random position and points that it's worth.
    /// </para>
    /// </summary>
    public class Player : Actor
    {

        /// <summary>
        /// Constructs a new instance of an Food.
        /// </summary>
        public Player(int player, int numberPoint, int y)
        {
            AddPoints(numberPoint, player, y);
           
        }

        /// <summary>
        /// Adds the given points to the score.
        /// </summary>
        /// <param name="points">The points to add.</param>
        public void AddPoints(int points, int player, int y)
        {
            SetPosition(new Point(points, y));
            SetText($"Player {player}");

        }

    }
}