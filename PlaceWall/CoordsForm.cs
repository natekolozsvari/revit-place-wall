using System;
using System.Windows.Forms;

namespace PlaceWall
{
    public partial class CoordsForm : Form
    {
        public string StartX { get; set; }
        public string StartY { get; set; }
        public string EndX { get; set; }
        public string EndY { get; set; }  

        public CoordsForm()
        {
            InitializeComponent();
        }

        private void placeButton_Click(object sender, EventArgs e)
        {
            StartX = startXTextBox.Text;
            StartY = startYTextBox.Text;
            EndX = endXTextBox.Text;
            EndY = endYTextBox.Text;

            placeButton.DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            cancelButton.DialogResult = DialogResult.Cancel;
        }
    }
}
