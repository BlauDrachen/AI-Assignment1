using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CSC479_A1.Helpers;
using CSC479_A1.Properties;

namespace CSC479_A1
{
    public partial class FrmMain : Form
    {
        private GridState _initialState;
        private GridState _currentState;
        
        private int _gridSize;
        private int _timeDelay; // Time in milliseconds to wait between each state change (Default is zero)
        private int agentCol;
        private int agentRow;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Set Initial drop down boxes to use first item in list
            cbSizes.SelectedIndex = 0;
            cbDelay.SelectedIndex = 0;

            // Set Initial Agent location
            agentCol = 0;
            agentRow = 0;
        }

        private void SetupStates(int gridSize, int agentXPos = -1, int agentYPos = -1)
        {
            _initialState = new GridState(gridSize);
            _currentState = new GridState(_initialState);
        }

        private void cbSizes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Use first character of selected option to change size
            _gridSize = int.Parse(((ToolStripComboBox)sender).SelectedItem.ToString().Substring(0, 1));

            // Reset Controls
            tblCurrent.Controls.Clear();
            tblInitial.Controls.Clear();

            // Call helper methods
            SetPanelGridSize(tblCurrent);
            SetPanelGridSize(tblInitial);

            // Add controls to all grid panels
            for (int i = 0; i < _gridSize; i++)
            {
                for (int j = 0; j < _gridSize; j++)
                {
                    AddCellControls(tblInitial, i, j, true);
                    AddCellControls(tblCurrent, i, j);                    
                }
            }

            // Build new state to start system with
            SetupStates(_gridSize, agentRow, agentCol);
            UpdateCellControls(_currentState, _initialState);
        }

        private void cbDelay_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If the delay box selection index changes adjust based on selection
            if (cbDelay.SelectedItem.ToString() == "No Delay")
            {
                _timeDelay = 0;
            }
            else
            {
                // Convert any numeric value at beginning of selected item text to a number of milliseconds
                _timeDelay = (int)(float.Parse(cbDelay.SelectedItem.ToString().Split(' ')[0]) * 1000);
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Build new state
            SetupStates(_gridSize, agentRow, agentCol);
            UpdateCellControls(_currentState, _initialState);
        }

        private void SetPanelGridSize(TableLayoutPanel tlp)
        {
            // Set Number of rows
            tlp.RowCount = _gridSize;
            tlp.ColumnCount = _gridSize;

            // Remove previous column and row styles
            tlp.RowStyles.Clear();
            tlp.ColumnStyles.Clear();

            // Set Columns and rows to be equal size 
            for (int i = 0; i < _gridSize; i++)
            {
                tlp.RowStyles.Add(new RowStyle(SizeType.Percent, (float)Math.Round(1.0 / _gridSize * 100.0)));
                tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, (float)Math.Round(1.0 / _gridSize * 100.0)));
            }
        }

        private void AddCellControls(TableLayoutPanel tlpParent, int row, int col, bool isInitial = false)
        {
            // Add inner Table Layout Panel
            TableLayoutPanel tlp = new TableLayoutPanel();
            tlp.Name = $"tlp_{row}_{col}";
            tlp.AutoSize = true;
            tlp.Dock = DockStyle.Fill;
            tlp.RowCount = 2;
            tlp.ColumnCount = 2;
            tlp.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
            tlp.BackColor = System.Drawing.Color.Transparent;
            tlp.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlp.RowStyles.Add(new RowStyle());
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));

            // Row 0
            Label lblState = new Label();
            lblState.Name = $"lblState{(isInitial ? "_init" : "")}_{row}_{col}";
            lblState.Text = $@"{row},{col}";
            lblState.Font = new Font(lblState.Font, FontStyle.Bold);

            // Row 1
            // Add Agent Picture Box
            PictureBox pbAgent = new PictureBox();
            pbAgent.Name = $"pbAgent{(isInitial ? "_init" : "")}_{row}_{col}";
            pbAgent.SizeMode = PictureBoxSizeMode.CenterImage;
            pbAgent.Dock = DockStyle.Fill;
            pbAgent.Image = Resources.agent;
            pbAgent.Visible = false;

            // Add Dirt Picture Box
            PictureBox pbDirt = new PictureBox();
            pbDirt.Name = $"pbDirt{(isInitial ? "_init" : "")}_{row}_{col}";
            pbDirt.SizeMode = PictureBoxSizeMode.CenterImage;
            pbDirt.Dock = DockStyle.Fill;
            pbDirt.Image = Resources.dirt;
            pbDirt.Visible = false;

            // Add Controls to tlp
            tlp.Controls.Add(lblState, 0, 0);
            tlp.Controls.Add(pbAgent, 0, 1);
            tlp.Controls.Add(pbDirt, 1, 1);

            // Add tlp to main TableLayoutPanel
            tlpParent.Controls.Add(tlp, col, row);
        }

        private void UpdateCellControls(GridState state, GridState initState = null)
        {
            for (int i = 0; i < _gridSize; i++)
            {
                for (int j = 0; j < _gridSize; j++)
                {
                    PictureBox pbDirt = (PictureBox)Controls.Find($"pbDirt_{i}_{j}", true)[0];
                    pbDirt.Visible = (state.Dirty[i, j]);

                    PictureBox pbAgent = (PictureBox)Controls.Find($"pbAgent_{i}_{j}", true)[0];
                    pbAgent.Visible = (state.AgentXPos == i && state.AgentYPos == j);

                    if (initState != null)
                    {
                        PictureBox pbInitDirt = (PictureBox)Controls.Find($"pbDirt_init_{i}_{j}", true)[0];
                        pbInitDirt.Visible = (initState.Dirty[i, j]);

                        PictureBox pbInitAgent = (PictureBox)Controls.Find($"pbAgent_init_{i}_{j}", true)[0];
                        pbInitAgent.Visible = (initState.AgentXPos == i && state.AgentYPos == j);
                    }
                }
            }
        }

        private void DFS_Initiator()
        {

        }
        
    }
}
