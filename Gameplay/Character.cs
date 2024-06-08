using System.Runtime.CompilerServices;

namespace consoleRPG
{
    class Character
    {

        //Core
        private string _name;
        private string _description;
        private int _level = 0;
        private int _skillPoints = 0;
        private int _exp = 0;
        private int _expMax = 100;

        //Attributes
        private int _vitality = 1;
        private int _strenght = 1;
        private int _dexterity = 1;
        private int _agility = 1;
        private int _intelligence = 1;

        //Stats
        private int _hp = 0;
        private int _hpMax = 10;
        private int _damage = 1;
        private int _damageMax = 1;
        private int _accuracy = 1;
        private int _defense = 1;

        //General 
        private int _gold = 100;
        
        //Getters & Setters

        public string Name
        {
            get { return this._name; }
        }
    
        private void CalculateExp() 
        {
            this._expMax = this._level * 100;
        }

        private void CalculateStats()
        {
            this._hp                =this._vitality * 10;
            this._damageMax         =this._strenght * 2;
            this._damage            =this._strenght;
            this._accuracy          =this._dexterity * 2;
            this._defense           =this._agility * 2; 
        }

        public Character(string name, string description)
        {
            this.CalculateStats();

            this._name = name;
            this._description = description;
            
        }

        public override string ToString()
        {
            string str = $"Name: \t\t\t{this._name}\n" +
                         $"Description: \t\t{this._description}\n" +
                         $"Skill points: \t\t{this._skillPoints}\n" +
                         $"Exp: \t\t\t{this._exp}/{this._expMax} {Gui.ProgressBar(this._exp, this._expMax,10)}\n\n";
            return str;
        }

        public string ToStringBanner()
        {
            string str = $"Name: {this._name} | Skill points: {this._skillPoints} | " +
                         $"EXP{Gui.ProgressBar(this._exp, this._expMax, 10)}";
                         
            return str;
        }
    }
}