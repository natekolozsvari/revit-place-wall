using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;

namespace PlaceWall
{
    [Transaction(TransactionMode.Manual)]
    public class Class1 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            Document doc = uiapp.ActiveUIDocument.Document;

            Form1 form = new Form1(commandData);
            form.ShowDialog();

            try
            {
                string startXString = form.startX;
                double startX = double.Parse(startXString);

                string startYString = form.startY;
                double startY = double.Parse(startYString);

                string endXString = form.endX;
                double endX = double.Parse(endXString);

                string endYString = form.endY;
                double endY = double.Parse(endYString);

                XYZ start = new XYZ(startX, startY, 0);
                XYZ end = new XYZ(endX, endY, 0);

                Line line = Line.CreateBound(start, end);

                FilteredElementCollector levels = new FilteredElementCollector(doc).OfClass(typeof(Level));
                Level firstLevel = levels.FirstElement() as Level;
            
                Transaction transaction = new Transaction(doc);
                transaction.Start("PlaceWall");
                Wall.Create(doc, line, firstLevel.Id, true);
                transaction.Commit();

                return Result.Succeeded;
            }
            catch (Exception e)
            {
                message = e.Message;
                return Result.Failed;
            }
        }
    }
}
