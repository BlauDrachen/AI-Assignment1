using System;
using System.Collections;
using CSC479_A1.Helpers;

namespace CSC479_A1
{
    public class AppProcessor
    {
        // class data
        private readonly int _gridSize;
        private bool[,] _initState;
        private bool[,] _currentState;
        private Tuple<int, int> _agent_initPos;
        private Tuple<int, int> _agent_curPos;

        public AppProcessor(int gridSize, int agentXPos = -1, int agentYPos = -1)
        {
            // 
            _gridSize = gridSize;
            
        }

        private void CreateState()
        {
            // Get a random number of Dirty Cells
            int numDirty = RandomNumberHelper.RandomNumber(1, (_gridSize * _gridSize));

            // Set variables
            _initState = new bool[_gridSize, _gridSize];

            // Build stack of tuples (Usually more efficient than looping till the right cell is randomly chosen)
            ArrayList arrList = new ArrayList();
            for (int i = 0; i < _gridSize; i++)
            {
                for (int j = 0; j < _gridSize; j++)
                {
                    arrList.Add((i, j));
                }
            }

            // Loop until all dirty cells are selected
            while (arrList.Count > 0 && numDirty-- > 0)
            {
                // Get row,col tuple
                int nextIndex = RandomNumberHelper.RandomNumber(0, arrList.Count - 1);
                var nextTuple = (Tuple<int, int>)arrList[nextIndex];

                // Set state to dirty and remove row,col combo
                _initState[nextTuple.Item1, nextTuple.Item2] = true;
                arrList.RemoveAt(nextIndex);
            }
        }
    }
}