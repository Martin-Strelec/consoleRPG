using System.Collections;
using System.Reflection.PortableExecutable;

namespace consoleRPG
{
    class StateMainMenu : State
    {
        //Variables
        protected ArrayList _characterList;
        protected Character _activeCharacter;

        //Public methods
        public StateMainMenu(Stack<State> states, ArrayList characterList) : base(states)
        {
            this._characterList = characterList;
            this._activeCharacter = null;
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
            if (this._activeCharacter == null)
            {
                Gui.Announcment("No ACTIVE character");
            }
            else
            {
                this._states.Push(new StateGame(this._states, this._activeCharacter));
            }
        }

        public void SelectCharacter()
        {
            for (int i = 0; i < this._characterList.Count; i++)
            {
                Gui.Announcment($"{i}:");
                Console.WriteLine($"{this._characterList[i].ToString()}");
            }

            while (this._activeCharacter == null)
            {
                int choice = (Gui.GetInputInt("Select character"));
                
                try
                {
                    this._activeCharacter = (Character)this._characterList[choice];
                }
                catch
                {
                    Gui.Announcment("Wrong option");
                }    
            }
            
            if (this._activeCharacter != null)
            {
                Gui.Announcment($"Character {this._activeCharacter.Name} is selected");    
            }
            
        }

        public override void Update()
        {
            //Gui.Title("Main Menu class");
            Gui.MenuTitle("Main Menu");
            if (this._activeCharacter != null)
            {
                Console.WriteLine(this._activeCharacter.ToStringBanner());
            }
            else
            {
                Gui.Error("No character selected!");
            }
            Gui.MenuOption("New Game","Create Character","Select Characters", "Exit");

            this.ProcessInput(Gui.GetInputInt("Input"));
        }
    }
}