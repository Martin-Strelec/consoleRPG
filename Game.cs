using System;
using System.Collections;


namespace consoleRPG
{
    class Game
    {
        //Variables
        private bool _exit;
        public bool Exit
        {
            get { return this._exit; }
            set { this._exit = value; }
        }
        private Stack<State> _states;
        private ArrayList _characterList;

        //Private functions

        //Initializing variables
        private void InitCharacterList()
        {
            this._characterList = new ArrayList();
        }
        private void InitVariables()
        {
            this._exit = false;
        }

        //Initializing states
        private void InitState()
        {
            this._states = new Stack<State>();

            //Push the first state
            this._states.Push(new StateMainMenu(this._states, this._characterList));
        }

        public Game()
        {
            InitVariables();
            InitCharacterList();
            InitState();
        }

        //Method for starting the game
        public void Run()
        {

            while (this._states.Count > 0)
            {
                this._states.Peek().Update();

                if (this._states.Peek().RequestEnd())
                {
                    this._states.Pop();
                }
            }

            Console.WriteLine("Ending game...");
        }
    }
}