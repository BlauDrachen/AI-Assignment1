using System;
using System.Windows.Forms;

namespace CSC479_A1
{
    public partial class frmMain : Form
    {
        private int gridSize;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Set Initial Combo Size to 2x2 
            cbSizes.SelectedIndex = 0;
            gridSize = 2;
        }

        private void SetPanelGridSize(TableLayoutPanel tlp)
        {
            // Set Number of rows
            tlp.RowCount = gridSize;
            tlp.ColumnCount = gridSize;
            
            // Remove previous column and row styles
            tlp.RowStyles.Clear();
            tlp.ColumnStyles.Clear();

            // Set Columns and rows to be equal size 
            for (int i = 0; i < gridSize; i++)
            {
                tlp.RowStyles.Add(new RowStyle(SizeType.Percent, (float)Math.Round(1.0 / gridSize * 100.0)));
                tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, (float)Math.Round(1.0 / gridSize * 100.0)));
            }

        }

        private void cbSizes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Use first character of selected option to change size
            gridSize = int.Parse(((ToolStripComboBox)sender).SelectedItem.ToString().Substring(0, 1));

            SetPanelGridSize(tblCurrent);
            SetPanelGridSize(tblInitial);
        }
    }
}
