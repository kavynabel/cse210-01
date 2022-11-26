using Unit05.Game.Casting;
using Unit05.Game.Directing;
using Unit05.Game.Scripting;
using Unit05.Game.Services;
using Unit05.Game;


namespace Unit05
{
    /// <summary>
    /// The program's entry point.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Starts the program using the given arguments.
        /// </summary>
        /// <param name="args">The given arguments.</param>
        static void Main(string[] args)
        {
            // create the cast
            Cast cast = new Cast();

            int x = Constants.CELL_SIZE+10;
            int y = Constants.CELL_SIZE+5;
            //player 1
            cast.AddActor("pieces", new Pieces(y*8, x, Constants.RED, Constants.YELLOW, "C" ));
            cast.AddActor("pieces", new Pieces(y*7, x, Constants.RED, Constants.YELLOW, "H" ));
            cast.AddActor("pieces", new Pieces(y*6, x, Constants.RED, Constants.YELLOW, "B" ));
            cast.AddActor("pieces", new Pieces(y*5, x, Constants.RED, Constants.YELLOW, "K" ));
            cast.AddActor("pieces", new Pieces(y*4, x, Constants.RED, Constants.YELLOW, "Q" ));
            cast.AddActor("pieces", new Pieces(y*3, x, Constants.RED, Constants.YELLOW, "B" ));
            cast.AddActor("pieces", new Pieces(y*2, x, Constants.RED, Constants.YELLOW, "H" ));
            cast.AddActor("pieces", new Pieces(y, x, Constants.RED, Constants.YELLOW, "C" ));

            cast.AddActor("pieces", new Pieces(y*8, x*2, Constants.RED, Constants.YELLOW, "P" ));
            cast.AddActor("pieces", new Pieces(y*7, x*2, Constants.RED, Constants.YELLOW, "P" ));
            cast.AddActor("pieces", new Pieces(y*6, x*2, Constants.RED, Constants.YELLOW, "P" ));
            cast.AddActor("pieces", new Pieces(y*5, x*2, Constants.RED, Constants.YELLOW, "P" ));
            cast.AddActor("pieces", new Pieces(y*4, x*2, Constants.RED, Constants.YELLOW, "P" ));
            cast.AddActor("pieces", new Pieces(y*3, x*2, Constants.RED, Constants.YELLOW, "P" ));
            cast.AddActor("pieces", new Pieces(y*2, x*2, Constants.RED, Constants.YELLOW, "P" ));
            cast.AddActor("pieces", new Pieces(y, x*2, Constants.RED, Constants.YELLOW, "P" ));
            

            //player 2
            cast.AddActor("pieces", new Pieces(y*8, x*7, Constants.BLUE, Constants.GREEN, "C" ));
            cast.AddActor("pieces", new Pieces(y*7, x*7, Constants.BLUE, Constants.GREEN, "H" ));
            cast.AddActor("pieces", new Pieces(y*6, x*7, Constants.BLUE, Constants.GREEN, "B" ));
            cast.AddActor("pieces", new Pieces(y*5, x*7, Constants.BLUE, Constants.GREEN, "K" ));
            cast.AddActor("pieces", new Pieces(y*4, x*7, Constants.BLUE, Constants.GREEN, "Q" ));
            cast.AddActor("pieces", new Pieces(y*3, x*7, Constants.BLUE, Constants.GREEN, "B" ));
            cast.AddActor("pieces", new Pieces(y*2, x*7, Constants.BLUE, Constants.GREEN, "H" ));
            cast.AddActor("pieces", new Pieces(y, x*7, Constants.BLUE, Constants.GREEN, "C" ));

            cast.AddActor("pieces", new Pieces(y*8, x*6, Constants.BLUE, Constants.YELLOW, "P" ));
            cast.AddActor("pieces", new Pieces(y*7, x*6, Constants.BLUE, Constants.YELLOW, "P" ));
            cast.AddActor("pieces", new Pieces(y*6, x*6, Constants.BLUE, Constants.YELLOW, "P" ));
            cast.AddActor("pieces", new Pieces(y*5, x*6, Constants.BLUE, Constants.YELLOW, "P" ));
            cast.AddActor("pieces", new Pieces(y*4, x*6, Constants.BLUE, Constants.YELLOW, "P" ));
            cast.AddActor("pieces", new Pieces(y*3, x*6, Constants.BLUE, Constants.YELLOW, "P" ));
            cast.AddActor("pieces", new Pieces(y*2, x*6, Constants.BLUE, Constants.YELLOW, "P" ));
            cast.AddActor("pieces", new Pieces(y, x*6, Constants.BLUE, Constants.YELLOW, "P" ));

            // to pring the players 
            cast.AddActor("player1", new Player(1, 0, 0));
            cast.AddActor("player2", new Player(2, 0, x*8));

            // create the services
            KeyboardService keyboardService = new KeyboardService();
            VideoService videoService = new VideoService(false);
           
            //Director director = new Director(videoService);
            // create the script
            Script script = new Script();
            //script.AddAction("input", new ControlActorsAction(keyboardService, director));
            script.AddAction("input", new ControlActorsAction(keyboardService));
            script.AddAction("update", new MoveActorsAction());
            script.AddAction("update", new HandleCollisionsAction());
            script.AddAction("output", new DrawActorsAction(videoService));

            // start the game
            Director director = new Director(videoService);
            director.StartGame(cast, script);
            // bool isRDown = false;
            // do
            // {
            //     isRDown = false;
            //     isRDown = director.StartGame(cast, script, keyboardService);
            //     if (isRDown == false)
            //     {
            //         break;
            //     }
            // } while (isRDown);          
        }
    }
}