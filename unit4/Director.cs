using System;
using System.Collections.Generic;
using unit04_greed.Services;
//using unit04-greed.Services;
//using System.Diagnostics;

namespace unit04_greed
{
    /// <summary>
    /// <para>A person who directs the game.</para>
    /// <para>
    /// The responsibility of a Director is to control the sequence of play.
    /// </para>
    /// </summary>
    public class Director
    {
        private KeyboardService keyboardService = null;
        private VideoService videoService = null;
        private static int FONT_SIZE = 20;
        
        private int _score = 0;
        /// <summary>
        /// Constructs a new instance of Director using the given KeyboardService and VideoService.
        /// </summary>
        /// <param name="keyboardService">The given KeyboardService.</param>
        /// <param name="videoService">The given VideoService.</param>

        public void Collisions()
        {
            return;
        }

        public Director(KeyboardService keyboardService, VideoService videoService)
        {
            this.keyboardService = keyboardService;
            this.videoService = videoService;
        }

        /// <summary>
        /// Starts the game by running the main game loop for the given cast.
        /// </summary>
        /// <param name="cast">The given cast.</param>
        public void StartGame(Cast cast)
        {
            videoService.OpenWindow();
            while (videoService.IsWindowOpen())
            {
                GetInputs(cast);
                DoUpdates(cast);
                DoOutputs(cast);
            }
            videoService.CloseWindow();
        }

        /// <summary>
        /// Gets directional input from the keyboard and applies it to the robot.
        /// </summary>
        /// <param name="cast">The given cast.</param>
        private void GetInputs(Cast cast)
        {
            Actor robot = cast.GetFirstActor("robot");
            Point velocity = keyboardService.GetDirection("dontMove");
            robot.SetVelocity(velocity);

            List<Actor> fallings = cast.GetActors("falling");            
            if (fallings.Count < 20)
            {
                Random random = new Random();
                int spawn = random.Next(0, 10);
                if (spawn == 1)
                {
                    int x = random.Next(1, 890);
                    int r = random.Next(0, 256);
                    int g = random.Next(0, 256);
                    int b = random.Next(0, 256);
                    Color color = new Color(r, g, b);
                    FallingObject falling = new FallingObject();
                    falling.SetText("O");
                    falling.SetFontSize(FONT_SIZE);
                    falling.SetColor(color);
                    falling.SetPosition(new Point(x,0));

                    Point velocityF = keyboardService.GetDirection("down");
                    falling.SetVelocity(velocityF);

                    cast.AddActor("falling", falling);
                }
                if (spawn == 2)
                {
                    int x = random.Next(1, 890);
                    int r = random.Next(0, 256);
                    int g = random.Next(0, 256);
                    int b = random.Next(0, 256);
                    Color color = new Color(r, g, b);
                    FallingObject falling = new FallingObject();
                    falling.SetText("*");
                    falling.SetFontSize(FONT_SIZE);
                    falling.SetColor(color);
                    falling.SetPosition(new Point(x,0));

                    Point velocityF = keyboardService.GetDirection("down");
                    falling.SetVelocity(velocityF);

                    cast.AddActor("falling", falling);
                }
            }                        
        }

        /// <summary>
        /// Updates the robot's position and resolves any collisions with artifacts.
        /// </summary>
        /// <param name="cast">The given cast.</param>
        private void DoUpdates(Cast cast)
        {
            Actor banner = cast.GetFirstActor("banner");
            //ScoreBoard bannerScore = new ScoreBoard();
            //_score = bannerScore.UpdateScore(_score);
            banner.SetText($"Score: {_score}");

            // this code will be for adding to the score board.
            //if colide then _score = _score + add or subtract  
            //_score = _score + 10;

            Actor robot = cast.GetFirstActor("robot");

            int max = videoService.GetWidth();
            int may = videoService.GetHeight();
            robot.MoveNext(max, may);

            // Get all the falling objects to fall
            List<Actor> fallings = cast.GetActors("falling");
            foreach (Actor f in fallings)
            {
                // if falling object goes out of screen, remove it
                f.MoveNext();
                if (f.GetPosition().GetY() > may)
                {
                    cast.RemoveActor("falling", f);
                }
                // COLLISION
                // if robot position is close enough to a falling object, add score, remove falling object
                Point robotPosition = robot.GetPosition();
                Point fPosition = f.GetPosition();
                if ((Math.Abs(robotPosition.GetX() - fPosition.GetX()) <= 10) & (Math.Abs(robotPosition.GetY() - fPosition.GetY()) <= 10))
                {                    
                    if (f.GetText() == "O")
                    {
                        _score += 15;
                    }
                    else
                    {
                        _score -= 10;
                    }
                    cast.RemoveActor("falling", f);
                    //Console.WriteLine("Score activated");
                }
            }            
                   
        }

        /// <summary>
        /// Draws the actors on the screen.
        /// </summary>
        /// <param name="cast">The given cast.</param>


        public void DoOutputs(Cast cast)
        {
            List<Actor> actors = cast.GetAllActors();
            videoService.ClearBuffer();
            videoService.DrawActors(actors);
            videoService.FlushBuffer();
        }


    }
}