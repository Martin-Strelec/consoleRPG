using System.Collections;
using System.Reflection.PortableExecutable;

namespace consoleRPG
{
    class StateMainMenu : State
    {
        //Variables
        protected ArrayList _characterList;

        //Public methods
        public StateMainMenu(Stack<State> states, ArrayList characterList) : base(states)
        {
            this._characterList = characterList;
        }

        public override void ProcessInput(int input)
        {
            switch (input)
            {
                case 1:
                    StartGame();
                    break;
                case 2:
                    this._states.Push(new StateCharacterCreator(this._states, this._characterList));
                    break;
                case 3:
                    SelectCharacter();
                    break;
                case 4:
                    this._end = true;
                    break;
                default:
                    Console.WriteLine("Invalid Input!");
                    break;
            }
        }

        public void StartGame()
        {
            
        }

        public void SelectCharacter()
        {
            foreach (var character in this._characterList)
            {
                Console.WriteLine(character.ToString());
            }
        }

        public override void Update()
        {

            Gui.Title("Main Menu class");
            Gui.MenuTitle("Main Menu");
            Gui.MenuOption("New Game","Create Character","Select Characters", "Exit");

            this.ProcessInput(Gui.GetInputInt("Input"));
        }
    }
}