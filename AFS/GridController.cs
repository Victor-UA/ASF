using System;
using System.Data;
using System.Drawing;

namespace AFS
{
    public class GridController : SourceGrid.Cells.Controllers.ControllerBase
    {
        private SourceGrid.Cells.Views.Cell MouseEnterView = new SourceGrid.Cells.Views.Cell();
        private SourceGrid.Cells.Views.Cell MouseLeaveView = new SourceGrid.Cells.Views.Cell();
        protected DataTable DT;
        protected string Key;
        public GridController(DataTable dt, string key)
        {
            MouseEnterView.BackColor = Color.LightGreen;
            DT = dt;
            Key = key;
        }
        public GridController(DataTable dt, string key, Color BackColor)
        {
            MouseEnterView.BackColor = BackColor;
            DT = dt;
            Key = key;
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