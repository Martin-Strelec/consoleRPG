using System.Collections;

namespace consoleRPG
{
    class StateCharacterCreator : State
    {

        //Variables
        protected ArrayList _characterList;

        //Private methods

        private void CreateCharacter()
        {
            string name;
            string description;

            Gui.GetInput("Input character name");
            name = Console.ReadLine();
            Gui.GetInput("Input character description");
            description = Console.ReadLine();

            this._characterList.Add(new Character(name, description));

            Gui.Announcment("Character Created!");
        }

        //Public methods
        public StateCharacterCreator(Stack<State> states, ArrayList characterList) : base(states)
        {
            this._characterList = characterList;
        }

        public override void ProcessInput(int input)
        {
            switch (input)
            {
                case 1:
                    CreateCharacter();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    this._end = true;
                    break;
                default:
                    Console.WriteLine("Invalid Input!");
                    break;
            }
        }

        public override void Update()
        {
            Gui.Title("Character Creator");
            Gui.MenuTitle("Choose");
            Gui.MenuOption("Create Character","Edit Character","Delete Character", "Exit");

            this.ProcessInput(Gui.GetInputInt("Input"));
        }

    }
}