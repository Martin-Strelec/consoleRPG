using System.Collections;

namespace consoleRPG
{
    class StateGame : State
    {

        //Variables
        protected ArrayList _characterList;

        //Public methods
        public StateGame(Stack<State> states, ArrayList characterList) : base(states)
        {
            this._characterList = characterList;
        }

        public override void ProcessInput(int input)
        {
            switch (input)
            {
                case 1:
                    this._states.Push(new StateCharacterCreator(this._states, this._characterList));
                    break;
                case 2:
                    Console.WriteLine(this._characterList.Count);
                    break;
                case 3:
                    this._end = true;
                    break;
                default:
                    Console.WriteLine("Invalid Input!");
                    break;
            }
        }

        public override void Update()
        {
            Gui.Title("Game");
            Gui.MenuTitle("Main Menu");
            Gui.MenuOption("Create Character","List Characters", "Exit");
            
            this.ProcessInput(Gui.GetInputInt("Input"));
        }
    }
}