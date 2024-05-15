namespace consoleRPG
{
    class State
    {

        protected bool _end;
        protected Stack<State> _states;

        public State(Stack<State> states)
        {
            this._states = states;
        }

        public bool RequestEnd()
        {
            return this._end;
        }
        virtual public void Update()
        {

        }

        virtual public void ProcessInput(int input)
        {

        }
    }
}