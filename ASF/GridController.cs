using System;
using System.Data;
using System.Drawing;

namespace ASF
{
    public class GridController : SourceGrid.Cells.Controllers.ControllerBase
    {
        private SourceGrid.Cells.Views.Cell MouseEnterView = new SourceGrid.Cells.Views.Cell();
        private SourceGrid.Cells.Views.Cell MouseLeaveView = new SourceGrid.Cells.Views.Cell();
        //protected DataTable DT;
        //protected string Key; //Найменування ключового поля
        //public GridController(DataTable dt, string key)

        //public GridController(DataTable dt, string key, Color BackColor)
        private void Constructor(Color BackColor)
        {
            MouseEnterView.BackColor = BackColor;
        }
        public GridController(Color BackColor)
        {
            Constructor(BackColor);
            //DT = dt;
            //Key = key;
        }
        public GridController()
        {
            Constructor(Color.LightGreen);
            //DT = dt;
            //Key = key;
        }
        public override void OnMouseEnter(SourceGrid.CellContext sender, EventArgs e)
        {
            base.OnMouseEnter(sender, e);
            sender.Cell.View = MouseEnterView;
            sender.Grid.InvalidateCell(sender.Position);
        }
        public override void OnMouseLeave(SourceGrid.CellContext sender, EventArgs e)
        {
            base.OnMouseLeave(sender, e);
            sender.Cell.View = MouseLeaveView;
            sender.Grid.InvalidateCell(sender.Position);
        }
    }

}