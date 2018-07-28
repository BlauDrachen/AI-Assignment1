using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSC479_A1.Helpers;

namespace CSC479_A1
{
    public class GridState
    {
        // Properties
        public int GridSize { get; private set; }
        public bool[,] Dirty { get; private set; }
        public int AgentXPos { get; private set; }
        public int AgentYPos { get; private set; }
        
        // General Constructors
        public GridState() : this(0, -1, -1) { }
        public GridState(int gridSize, int agentXPos = -1, int agentYPos = -1, bool generateRandomState = true)
        {
            // Set state variables
            SetGridSize(gridSize);
            SetAgentPosition(agentXPos, agentYPos);

            // Initialize grid of data concerning dirty cells
            Dirty = new bool[GridSize, GridSize];

            // Check if a new state should be randomly generated
            if (generateRandomState)
            {
                GenerateRandomState();
            }
        }

        // Constructor to copy existing state
        public GridState(GridState toCopy)
        {
            // Copy Data from one class to another
            // assigning the class would result in a reference instead of value copy
            GridSize = toCopy.GridSize;
            AgentXPos = toCopy.AgentXPos;
            AgentYPos = toCopy.AgentYPos;

            // Initialize grid of data concerning dirty cells
            Dirty = new bool[GridSize, GridSize];

            // Copy State Grid
            CopyGrid(toCopy.Dirty);
        }

        // Build Random State
        private void GenerateRandomState()
        {
            // Get a random number of Dirty Cells
            int numDirty = RandomNumberHelper.RandomNumber(1, (GridSize * GridSize));
            
            // Build stack of tuples (Usually more efficient than looping till the right cell is randomly chosen)
            ArrayList arrList = new ArrayList();
            for (int i = 0; i < GridSize; i++)
            {
                for (int j = 0; j < GridSize; j++)
                {
                    arrList.Add((i, j));
                }
            }

            // Loop until all dirty cells are selected
            while (arrList.Count > 0 && numDirty-- > 0)
            {
                // Get row,col tuple
                int nextIndex = RandomNumberHelper.RandomNumber(0, arrList.Count - 1);
                var nextTuple = (ValueTuple<int, int>)arrList[nextIndex];

                // Set state to dirty and remove row,col combo
                Dirty[nextTuple.Item1, nextTuple.Item2] = true;
                arrList.RemoveAt(nextIndex);
            }
        }
        
        // Set Grid Size Property
        public void SetGridSize(int gridSize)
        {
            // Validate and set grid size
            GridSize = gridSize < 2 || gridSize > 4 ? 2 : gridSize;
        }

        // Set Agent Position Properties
        public void SetAgentPosition(int xpos, int ypos)
        {
            // if < 0 Set Random, if > gridsize set 0
            AgentXPos = xpos >= 0 ? (xpos >= GridSize ? 0 : xpos) : RandomNumberHelper.RandomNumber(0, GridSize);
            AgentYPos = ypos >= 0 ? (ypos >= GridSize ? 0 : ypos) : RandomNumberHelper.RandomNumber(0, GridSize);
        }

        public void CopyGrid(bool[,] dirtyGrid)
        {
            // Equivalent of foreach on each row then each column
            for (int i = 0; i < dirtyGrid.GetLength(0); i++)
            {
                for (int j = 0; j < dirtyGrid.GetLength(1); j++)
                {
                    Dirty[i, j] = dirtyGrid[i, j];
                }
            }
        }

        public void SetDirtyState(int xpos, int ypos, bool isDirty)
        {
            Dirty[xpos, ypos] = isDirty;
        }
    }
}
