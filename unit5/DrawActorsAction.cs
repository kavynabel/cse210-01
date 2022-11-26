using System.Collections.Generic;
using Unit05.Game.Casting;
using Unit05.Game.Services;


namespace Unit05.Game.Scripting
{
    /// <summary>
    /// <para>An output action that draws all the actors.</para>
    /// <para>The responsibility of DrawActorsAction is to draw each of the actors.</para>
    /// </summary>
    public class DrawActorsAction : Action
    {
        private VideoService videoService;

        /// <summary>
        /// Constructs a new instance of ControlActorsAction using the given KeyboardService.
        /// </summary>
        public DrawActorsAction(VideoService videoService)
        {
            this.videoService = videoService;
        }

        /// <inheritdoc/>
        public async void Execute(Cast cast, Script script)
        {
            videoService.ClearBuffer();            

            List<Actor> actors = cast.GetActors("pieces");
            
            foreach (Actor actor in actors)
            {
                Pieces snake = (Pieces)actor;
                List<Actor> segments = snake.GetSegments();
                videoService.DrawActors(segments);
            }            
           
            Actor player1 = cast.GetFirstActor("player1");
            Actor player2 = cast.GetFirstActor("player2");
            //Actor food = cast.GetFirstActor("food");
            List<Actor> messages = cast.GetActors("messages");
                        
            videoService.DrawActor(player1);
            videoService.DrawActor(player2);
            //videoService.DrawActor(food);
            videoService.DrawActors(messages);
            videoService.FlushBuffer();
        }
    }
}