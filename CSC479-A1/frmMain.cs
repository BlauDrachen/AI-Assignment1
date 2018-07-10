using System;
using System.Windows.Forms;

namespace CSC479_A1
{
    public partial class FrmMain : Form
    {
        private int _gridSize;
        private int _timeDelay; // Time in milliseconds to wait between each state change (Default is zero)

        public FrmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Set Initial drop down boxes to use first item in list
            cbSizes.SelectedIndex = 0;
            cbDelay.SelectedIndex = 0;
        }

        private void cbSizes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Use first character of selected option to change size
            _gridSize = int.Parse(((ToolStripComboBox)sender).SelectedItem.ToString().Substring(0, 1));

            // Call helper methods
            SetPanelGridSize(tblCurrent);
            SetPanelGridSize(tblInitial);
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

        private void DFS_Initiator()
        {

        }
        
    }
}
