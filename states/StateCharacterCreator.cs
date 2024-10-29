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

            Console.Clear();
            Gui.GetInput("Input character name");
            name = Console.ReadLine();
            Console.Clear();
            Gui.Announcment($"Character name: {name}");
            Gui.GetInput("Input character description");
            description = Console.ReadLine();

            this._characterList.Add(new Character(name, description));

            Gui.Announcment("Character Created");
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
            Console.Clear();
            Gui.Title("Character Creator");
            Gui.MenuTitle("Choose");
            Gui.MenuOption("Create Character","Edit Character","Delete Character", "Exit");

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