using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC479_A1
{
    public class Agent
    {
        private int _xpos;
        private int _ypos;
        private GridState _state;
        private GridState _virtState;

        public Agent(GridState state)
        {
            _state = state;
            _virtState = new GridState(_state);

            // Get x and y position from state
            _xpos = state.AgentXPos;
            _ypos = state.AgentYPos;
        }

        public bool MoveNorth()
        {

            return false;
        }

        public bool MoveSouth()
        {

            return false;
        }

        public bool MoveEast()
        {

            return false;
        }

        public bool MoveWest()
        {

            return false;
        }

        public bool CleanSq()
        {

            return false;
        }
    }
}
