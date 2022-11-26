using System.Collections.Generic;
using Unit05.Game.Casting;


namespace Unit05.Game.Scripting
{
    // TODO: Implement the MoveActorsAction class here
    public class MoveActorsAction : Action
    {
        // 1) Add the class declaration. Use the following class comment. Make sure you
        //    inherit from the Action class.

        /// <summary>
        /// <para>An update action that moves all the actors.</para>
        /// <para>
        /// The responsibility of MoveActorsAction is to move all the actors.
        /// </para>
        /// </summary>
        List<Actor> actors;

        // 2) Create the class constructor. Use the following method comment.

        /// <summary>
        /// Constructs a new instance of MoveActorsAction.
        /// </summary>
        public MoveActorsAction()
        {
        }

        // 3) Override the Execute(Cast cast, Script script) method. Use the following 
        //    method comment. You custom implementation should do the following:
        //    a) get all the actors from the cast
        //    b) loop through all the actors
        //    c) call the MoveNext() method on each actor.
        
        public void Execute(Cast cast, Script script)
        {
            GrowSnake(cast);
            //Cast theCast = new Cast();
            actors = cast.GetAllActors();
            
            foreach (Actor actor in actors)
            {
                actor.MoveNext();
            }
        }

        public void GrowSnake(Cast cast)
        {
            //Snake snake = (Snake)cast.GetFirstActor("snake");
            List<Actor> actors = cast.GetActors("snake");
            List<Pieces> snakes = new List<Pieces>();
            foreach (Actor actor in actors)
            {
                snakes.Add((Pieces)actor);
            }
            for (int i = 0; i < snakes.Count; i++)
            {
                Pieces snake = snakes[i];
                int points = 1;
                Color tailColor = Constants.GREEN;
                if (i != 0)                
                {
                    tailColor = Constants.BLUE;
                }
                 
                snake.GrowTail(points, tailColor);
            }
        }
        

    }
}   