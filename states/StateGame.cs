using System.Collections;

namespace consoleRPG
{
    class StateGame : State
    {

        //Variables
        protected Character _character;

        //Public methods
        public StateGame(Stack<State> states, Character activeCharacter) : base(states)
        {
            this._character = activeCharacter;
        }

        public override void ProcessInput(int input)
        {
            switch (input)
            {
                case 1:
                    Console.WriteLine(this._character.ToString());
                    break;
                case 2:
                    this._end = true;
                    break;
                default:
                    Console.WriteLine("Invalid Input!");
                    break;
            }
        }

        public override void Update()
        {
            Console.Clear();
            Gui.Title("Game");
            Gui.MenuTitle("Main Menu");
            Gui.MenuOption("Character Stats", "Exit");

            int input = Gui.GetInputInt("Input");
            if (input == -1)
            {
                Update();
            }
            else
            {
                ProcessInput(input);
            }
        }
    }
}