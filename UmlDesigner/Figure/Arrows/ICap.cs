using System.Drawing.Drawing2D;


namespace UmlDesigner.Figure.Arrows
{
    public interface ICap
    {
         CustomLineCap GetCustomLineCap(GraphicsPath hPath);
    }
}
