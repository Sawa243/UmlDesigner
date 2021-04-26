using System.Drawing;


namespace UmlDesigner.Figure.Action
{
    public interface IMoveable
    {
        bool IsItYou(Point point);

        void Move(int deltaX, int deltaY);
    }
}
