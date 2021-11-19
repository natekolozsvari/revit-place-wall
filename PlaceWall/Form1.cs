using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace PlaceWall
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        private UIApplication uiApp;
        private UIDocument uiDoc;
        private Autodesk.Revit.ApplicationServices.Application app;
        private Document doc;

        public string startX;
        public string startY;
        public string endX;
        public string endY;

        public Form1(ExternalCommandData commandData)
        {
            InitializeComponent();

            uiApp = commandData.Application;
            uiDoc = uiApp.ActiveUIDocument;
            app = uiApp.Application;
            doc = uiDoc.Document;
        }

        private void startXTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void startYTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void endXTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void endYTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void placeButton_Click(object sender, EventArgs e)
        {
            startX = startXTextBox.Text;
            startY = startYTextBox.Text;
            endX = endXTextBox.Text;
            endY = endYTextBox.Text;

            placeButton.DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            cancelButton.DialogResult = DialogResult.Cancel;
        }
    }
}
