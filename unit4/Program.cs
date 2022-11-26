﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using unit04_greed;
using unit04_greed.Services;


namespace unit04_greed
{
    /// <summary>
    /// The program's entry point.
    /// </summary>
    class Program
    {
        private static int FRAME_RATE = 12;
        private static int MAX_X = 900;
        private static int MAX_Y = 600;
        private static int CELL_SIZE = 15;
        private static int FONT_SIZE = 15;
        //private static int COLS = 60;
        //private static int ROWS = 40;
        private static string CAPTION = "Greed Game";

        private static Color WHITE = new Color(255, 255, 255);
        private static int DEFAULT_FallingO = 4;


        /// <summary>
        /// Starts the program using the given arguments.
        /// </summary>
        /// <param name="args">The given arguments.</param>
        static void Main(string[] args)
        {
            // create the cast
            Cast cast = new Cast();

            // create the banner
            ScoreBoard banner = new ScoreBoard();
            //banner.SetText($"Score: " );
            banner.SetFontSize(30);
            banner.SetColor(WHITE);
            banner.SetPosition(new Point(CELL_SIZE, 0));
            cast.AddActor("banner", banner);

            // create the robot
            Player robot = new Player();
            robot.SetText("#");
            robot.SetFontSize(FONT_SIZE);
            robot.SetColor(WHITE);
            robot.SetPosition(new Point(MAX_X / 2, 580));
            cast.AddActor("robot", robot);

            // TODO
            // move the creation of falling objects here
            // so it doesn't infinitely spawn           

            // start the game
            KeyboardService keyboardService = new KeyboardService(CELL_SIZE);
            VideoService videoService 
                = new VideoService(CAPTION, MAX_X, MAX_Y, CELL_SIZE, FRAME_RATE, false);
            Director director = new Director(keyboardService, videoService);
            
            director.StartGame(cast);

        }
    }
}