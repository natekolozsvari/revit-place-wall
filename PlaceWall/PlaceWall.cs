using System;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace PlaceWall
{
    [Transaction(TransactionMode.Manual)]
    public class PlaceWall : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            Document doc = uiapp.ActiveUIDocument.Document;

            CoordsForm form = new CoordsForm();
            form.ShowDialog();

            try
            {
                string startXString = form.StartX;
                double startX = double.Parse(startXString);

                string startYString = form.StartY;
                double startY = double.Parse(startYString);

                string endXString = form.EndX;
                double endX = double.Parse(endXString);

                string endYString = form.EndY;
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
