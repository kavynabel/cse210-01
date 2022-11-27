using System.Collections.Generic;
using Unit06.Game.Casting;


namespace Unit06
{
    public class Constants
    {
        // ----------------------------------------------------------------------------------------- 
        // GENERAL GAME CONSTANTS
        // ----------------------------------------------------------------------------------------- 

        // GAME
        public static string GAME_NAME = "Batter";
        public static int FRAME_RATE = 60;

        // SCREEN
        public static int SCREEN_WIDTH = 1000;
        public static int SCREEN_HEIGHT = 875;
        public static int CENTER_X = SCREEN_WIDTH / 2;
        public static int CENTER_Y = SCREEN_HEIGHT / 2;

        // FIELD
        public static int FIELD_TOP = 60;
        public static int FIELD_BOTTOM = SCREEN_HEIGHT;
        public static int FIELD_LEFT = 0;
        public static int FIELD_RIGHT = SCREEN_WIDTH;
        public static int FIELD_MID = SCREEN_WIDTH/2;

        // FONT
        public static string FONT_FILE = "Assets/Fonts/zorque.otf";
        public static int FONT_SIZE = 32;

        // SOUND
        public static string BOUNCE_SOUND = "Assets/Sounds/boing.wav";
        public static string WELCOME_SOUND = "Assets/Sounds/start.wav";
        public static string OVER_SOUND = "Assets/Sounds/over.wav";

        // TEXT
        public static int ALIGN_LEFT = 0;
        public static int ALIGN_CENTER = 1;
        public static int ALIGN_RIGHT = 2;


        // COLORS
        public static Color BLACK = new Color(0, 0, 0);
        public static Color WHITE = new Color(255, 255, 255);
        public static Color PURPLE = new Color(255, 0, 255);

        // Mouse 
        public static string CLICK = "click";

        // KEYS
        public static string LEFT = "left";
        public static string RIGHT = "right";
        public static string SPACE = "space";
        public static string ENTER = "enter";
        public static string PAUSE = "p";

        // SCENES
        public static string NEW_GAME = "new_game";
        public static string TRY_AGAIN = "try_again";
        public static string NEXT_LEVEL = "next_level";
        public static string IN_PLAY = "in_play";
        public static string GAME_OVER = "game_over";

        // LEVELS
        public static string LEVEL_FILE = "Assets/Data/level-001.txt";
        public static string LEVEL_FILE1 = "Assets/Data/level-002.txt";
        public static int BASE_LEVELS = 5;

        // ----------------------------------------------------------------------------------------- 
        // SCRIPTING CONSTANTS
        // ----------------------------------------------------------------------------------------- 

        // PHASES
        public static string INITIALIZE = "initialize";
        public static string LOAD = "load";
        public static string INPUT = "input";
        public static string UPDATE = "update";
        public static string OUTPUT = "output";
        public static string UNLOAD = "unload";
        public static string RELEASE = "release";

        // ----------------------------------------------------------------------------------------- 
        // CASTING CONSTANTS
        // ----------------------------------------------------------------------------------------- 

        // STATS
        public static string STATS_GROUP = "stats";
        public static int DEFAULT_LIVES = 3;
        public static int MAXIMUM_LIVES = 5;

        // HUD
        public static int HUD_MARGIN = 15;
        public static string LEVEL_GROUP = "level";
        public static string LIVES_GROUP = "lives";
        public static string SCORE_GROUP = "score";
        public static string LEVEL_FORMAT = "Player 1";
        public static string LIVES_FORMAT = "Player 2";
        public static string SCORE_FORMAT = "Chess game";

        // BALL
        public static string BALL_GROUP = "balls";
        public static string BALL_IMAGE = "Assets/Images/000.png";
        public static int BALL_WIDTH = 28;
        public static int BALL_HEIGHT = 28;
        public static int BALL_VELOCITY = 6;

        // Mouse 

        public static string MOUSE_GROUP = "mouse";
        public static string MOUSE_IMAGE = "Assets/Images/mouse_image.png";
        public static List<string> MOUSE_IMAGES = new List<string>() 
        {"Assets/Images/mouse_image.png"};
        
        // RACKET
        public static string RACKET_GROUP = "rackets";
        
        public static List<string> RACKET_IMAGES
            = new List<string>() {
                "Assets/Images/100.png",
                "Assets/Images/101.png",
                "Assets/Images/102.png"
            };

        public static int RACKET_WIDTH = 106;
        public static int RACKET_HEIGHT = 28;
        public static int RACKET_RATE = 6;
        public static int RACKET_VELOCITY = 7;

        // BRICK
        public static string BRICK_GROUP = "bricks";
        
        public static Dictionary<string, List<string>> BRICK_IMAGES
            = new Dictionary<string, List<string>>() {
                { "b", new List<string>() {
                    "Assets/Images/white_square.png",
                    "Assets/Images/011.png",
                    "Assets/Images/012.png",
                    "Assets/Images/013.png",
                    "Assets/Images/014.png",
                    "Assets/Images/015.png",
                    "Assets/Images/016.png",
                    "Assets/Images/017.png",
                    "Assets/Images/018.png"
                } },
                { "g", new List<string>() {
                    "Assets/Images/black_square.png",
                    "Assets/Images/black_square.png",
                    "Assets/Images/black_square.png",
                    "Assets/Images/black_square.png",
                    "Assets/Images/black_square.png",
                    "Assets/Images/black_square.png",
                    "Assets/Images/black_square.png",
                    "Assets/Images/black_square.png",
                    "Assets/Images/black_square.png"
                } }                
        };

        public static int BRICK_WIDTH = 100;
        public static int BRICK_HEIGHT = 100;
        public static double BRICK_DELAY = 0.5;
        public static int BRICK_RATE = 4;
        public static int BRICK_POINTS = 50;

        // PIECE
        public static string PIECE_GROUP = "pieces";
        public static Dictionary<string, List<string>> PIECE_IMAGES
            = new Dictionary<string, List<string>>() {
                { "b", new List<string>() {
                    "Assets/Images/white_square.png",
                    "Assets/Images/011.png",
                    "Assets/Images/012.png",
                    "Assets/Images/013.png",
                    "Assets/Images/014.png",
                    "Assets/Images/015.png",
                    "Assets/Images/016.png",
                    "Assets/Images/017.png",
                    "Assets/Images/018.png"
                } },
                { "g", new List<string>() {
                    "Assets/Images/black_square.png",
                    "Assets/Images/black_square.png",
                    "Assets/Images/black_square.png",
                    "Assets/Images/black_square.png",
                    "Assets/Images/black_square.png",
                    "Assets/Images/black_square.png",
                    "Assets/Images/black_square.png",
                    "Assets/Images/black_square.png",
                    "Assets/Images/black_square.png"
                } },
                { "p", new List<string>() {
                    "Assets/Images/yellow_pawn.png",
                    "Assets/Images/00.png",
                    "Assets/Images/00.png",
                    "Assets/Images/yellow_rook.png",
                    "Assets/Images/yellow_queen.png",
                    "Assets/Images/yellow_king.png",
                    "Assets/Images/036.png",
                    "Assets/Images/037.png",
                    "Assets/Images/038.png"
                } },
                { "a", new List<string>() {
                    "Assets/Images/yellow_bishop.png"
                } },
                { "c", new List<string>() {
                    "Assets/Images/yellow_knight.png"
                } },
                { "d", new List<string>() {
                    "Assets/Images/yellow_rook.png"
                } },
                { "e", new List<string>() {
                    "Assets/Images/yellow_queen.png"
                } },
                { "f", new List<string>() {
                    "Assets/Images/yellow_king.png"
                } },
                { "z", new List<string>() {
                    "Assets/Images/red_pawn.png"
                } },
                { "x", new List<string>() {
                    "Assets/Images/red_bishop.png"
                } },
                { "y", new List<string>() {
                    "Assets/Images/red_knight.png"
                } },
                { "w", new List<string>() {
                    "Assets/Images/red_rook.png"
                } },
                { "v", new List<string>() {
                    "Assets/Images/red_queen.png"
                } },
                { "u", new List<string>() {
                    "Assets/Images/red_king.png"
                } }
        };
        public static int PIECE_WIDTH = BRICK_WIDTH;
        public static int PIECE_HEIGHT = BRICK_HEIGHT;
        public static double PIECE_DELAY = 0.5;
        public static int PIECE_RATE = 2000;
        public static int PIECE_POINTS = 50;
        
        // DIALOG
        public static string DIALOG_GROUP = "dialogs";
        public static string ENTER_TO_START = "PRESS ENTER TO START";
        public static string PREP_TO_LAUNCH = "Ready...Set...Go";
        public static string WAS_GOOD_GAME = "GAME OVER";

    }
}