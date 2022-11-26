using Unit05.Game.Casting;
using Unit05.Game.Services;
using System.Collections.Generic;
using Unit05.Game.Directing;

namespace Unit05.Game.Scripting
{
    /// <summary>
    /// <para>An input action that controls the snake.</para>
    /// <para>
    /// The responsibility of ControlActorsAction is to get the direction and move the snake's head.
    /// </para>
    /// </summary>
    public class ControlActorsAction : Action
    {
        private KeyboardService keyboardService;
        private Point direction = new Point(0, -Constants.CELL_SIZE);
        private Point direction2 = new Point(0, -Constants.CELL_SIZE);
        private Director _director;

        /// <summary>
        /// Constructs a new instance of ControlActorsAction using the given KeyboardService.
        /// </summary>
        public ControlActorsAction(KeyboardService keyboardService)
        {
            this.keyboardService = keyboardService;            
        }
        public ControlActorsAction(KeyboardService keyboardService, Director director)
        {
            this.keyboardService = keyboardService;
            _director = director;
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            // left
            if (keyboardService.IsKeyDown("a"))
            {
                direction = new Point(-Constants.CELL_SIZE, 0);
            }

            // right
            if (keyboardService.IsKeyDown("d"))
            {
                direction = new Point(Constants.CELL_SIZE, 0);
            }

            // up
            if (keyboardService.IsKeyDown("w"))
            {
                direction = new Point(0, -Constants.CELL_SIZE);
            }

            // down
            if (keyboardService.IsKeyDown("s"))
            {
                direction = new Point(0, Constants.CELL_SIZE);
            }

            // left
            if (keyboardService.IsKeyDown("j"))
            {
                direction2 = new Point(-Constants.CELL_SIZE, 0);
            }

            // right
            if (keyboardService.IsKeyDown("l"))
            {
                direction2 = new Point(Constants.CELL_SIZE, 0);
            }

            // up
            if (keyboardService.IsKeyDown("i"))
            {
                direction2 = new Point(0, -Constants.CELL_SIZE);
            }

            // down
            if (keyboardService.IsKeyDown("k"))
            {
                direction2 = new Point(0, Constants.CELL_SIZE);
            }

            // restart
            // if (keyboardService.IsKeyDown("r"))
            // {
            //     //_director.GetVideoService().CloseWindow();
            //     //_director.GetVideoService().OpenWindow();
            //     //_director.StartGame(cast, script);
            // }

            // Snake snake = (Snake)cast.GetFirstActor("snake");
            // snake.TurnHead(direction);
            // Snake snake2 = (Snake)cast.GetFirstActor("snake");
            // snake2.TurnHead(direction2);
            List<Actor> actors = cast.GetActors("pieces");
            List<Pieces> snakes = new List<Pieces>();
            foreach (Actor actor in actors)
            {
                snakes.Add((Pieces)actor);
            }            
            for (int i = 0; i < snakes.Count; i++)
            {
                Pieces snake = snakes[i];
                if (i == 0)
                {
                    snake.TurnHead(direction);
                }
                else
                {
                    snake.TurnHead(direction2);
                }
            }
            // Snake player1 = snakes[0];
            // // Snake player2 = snakes[1];
            // player1.TurnHead(direction);
            // // player2.TurnHead(direction2);
        }
    }
}