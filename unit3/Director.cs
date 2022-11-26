using System;
using System.Collections.Generic;

namespace unit03_jumper
{
    class Director
    {
        //---------------------------------------------------------------------
        // Member Variables
        //---------------------------------------------------------------------
        bool _isPlaying;
        // bool _isGuessingWord;
        UI _ui;        
        Dictionary _dictionary;
        Board _board;
        // List<char> _userGuesses;
        char _userGuess;
        string _wordToGuess;
        string _message;
        
        //---------------------------------------------------------------------
        // Constructors
        //---------------------------------------------------------------------
        public Director ()
        {
            _isPlaying = true;
            // _isGuessingWord = false;
            _ui = new UI();
            _dictionary = new Dictionary();
            _board = new Board();
            //_userGuesses = new List<char>();
            _wordToGuess = "tacos";
        }

        //---------------------------------------------------------------------
        // Member Functions
        //---------------------------------------------------------------------
        public void startGame()
        {
            Console.WriteLine("Starting game!");                        

            // initial stuff
            _wordToGuess = _dictionary.getRandomWord();
            _board.createDash(_wordToGuess);
            _ui.DrawBoard(_board, _wordToGuess);

            while (_isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();                
            }
        }

        public void GetInputs()
        {                                                                                           
            // gets user input for guess
            _userGuess = _ui.UserGuess();            
            // adds user input to list of guesses
            //_userGuesses.Add(guess);                                               
        }
        public void DoUpdates()
        {
            // update board
            _board.changeBoard(_wordToGuess, _userGuess);            
            
            // stop conditions
            if (_board.getJumperLife() <= 0)
            {
                _isPlaying = false;
                _message = "Sorry, you died!";                
            }
            if (isWordFound())
            {                
                _isPlaying = false;
                _message = "Congrats, you found the word!";                
            }            
        }
        public void DoOutputs()
        {
            _ui.DrawBoard(_board, _wordToGuess);
            if (_isPlaying == false)
            {
                _ui.PrintWords(_message);
            }                       
        }
        
        public bool isWordFound()
        {
            int numOfDashes = 0;
            List<string> dashes = _board.getDash();
            foreach (string s in dashes)
            {
                if (s == "_")
                {
                    numOfDashes += 1;
                }
            }
            if (numOfDashes > 0)
            {
                return false;
            }
            else 
            {
                return true;
            }
        }
    }
}
