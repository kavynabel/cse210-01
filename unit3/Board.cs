using System;
using System.Collections.Generic;

namespace unit03_jumper
{
    class Board
    {
        //---------------------------------------------------------------------
        // Member Variables
        //---------------------------------------------------------------------        
        int _jumperLife;
        List<string> _parachute;
        List<string> _dash;

        //---------------------------------------------------------------------
        // Constructors
        //---------------------------------------------------------------------
        public Board()
        {
            _parachute = new List<string>{" --- ", "/   \\ ", " --- ", "\\   /", " \\ / ", "  0  ", " /|\\ ", " / \\ "};            
            _jumperLife = 5;
            _dash = new List<string>{};            
        }
        public Board(string guessword)
        {
            _parachute = new List<string>{" --- ", "/   \\ ", " --- ", "\\   /", " \\ / ", "  0  ", " /|\\ ", " / \\ "};            
            _jumperLife = 5;
            _dash = new List<string>{};
            createDash(guessword);
        }

        //---------------------------------------------------------------------
        // Member Functions
        //---------------------------------------------------------------------
        public List<string> getJumper()
        {            
            // print jumper guy graphic
            // Console.WriteLine(" --- ");
            // Console.WriteLine("/   \ ");
            // Console.WriteLine(" --- ");
            // Console.WriteLine("\   /");
            // Console.WriteLine(" \ / ");
            // Console.WriteLine("  0  ");
            // Console.WriteLine(" /|\ ");
            // Console.WriteLine(" / \ ");
            return _parachute;
        }        
        public void changeJumper()
        {
            // change graphic conditional upon if user input was correct or not
            int mistakesMade = 5 - _jumperLife;
            if (mistakesMade >= 5)
            {                
                _parachute[4] = "";
                _parachute[5] = "  x  ";
            }
            else
            {
                for (int i = 0; i < mistakesMade; i++)
                {
                    _parachute[i] = "";
                }
            }            
        }
        public int getJumperLife()
        {
            return _jumperLife;
        }

        public void createDash(string wordToGuess)
        {
            int count = wordToGuess.Length;
            // with worlf count is equal to 5
            // Console.WriteLine(count);

            for (int i = 0; i < count; i++)
            {
                _dash.Add("_");
            }
        }
        public List<string> getDash()
        {
            return _dash;
        }
        public void changeDash(int index, char letter)
        {
            _dash[index] = letter.ToString();
        }
        // public void changeDash(string wordToGuess, List<char> userGuesses)
        // {
        //     foreach (char charGuess in userGuesses)
        //     {
        //         for (int i = 0; i < _dash.Count; i++)
        //         {
        //             if (charGuess == wordToGuess[i])
        //             {
        //                 _dash[i] = charGuess.ToString();
        //             }                                      
        //         }
        //     }
        // }        

        public void changeBoard(string wordToGuess, char userGuess)
        {
            // checks if user made a mistake
            bool madeMistake = true;
            for (int i = 0; i < _dash.Count; i++)
            {
                if (userGuess == wordToGuess[i])
                {
                    _dash[i] = userGuess.ToString();
                    madeMistake = false;
                }
            }
            if (madeMistake)
            {
                _jumperLife -= 1;
            }
            // updates jumper guy
            changeJumper();
            // updates dashes
            //changeDash(wordToGuess, userGuesses);
        }
    }
}