using NUnit.Framework;
using UmlDesigner.Figure.Forms;
using UmlDesigner.Figure.Arrows;
using System.Drawing;
using System.Collections;

namespace UmlDesigner.Tests.Figure
{
    class AbstractAllFigursTests
    {
        [TestCaseSource(typeof(IsInclude_WhenSetArrowAndPoint_ShoudReturnBoolTestSource))]
        public void IsInclude_WhenSetArrowAndPoint_ShoudReturnBool(RealizationArrow arrow, Point point, bool expected)
        {
            bool actual = arrow.IsInclude(point);

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(IsIncludeTests_WhenSetFormAndPoint_ShoudReturnBoolTestSource))]
        public void IsInclude_WhenSetFormAndPoint_ShoudReturnBool(FormClass form, Point point, bool expected)
        {
            bool actual = form.IsInclude(point);

            Assert.AreEqual(expected, actual);
        }

    }
    public class IsInclude_WhenSetArrowAndPoint_ShoudReturnBoolTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]            {
                new RealizationArrow(){StartPoint = new Point(0,0),EndPoint=new Point(200,200)},
                new Point(100,200),
                true
            };

            yield return new object[]            {
                new RealizationArrow(){StartPoint = new Point(400,0),EndPoint=new Point(0,400)},
                new Point(200,0),
                true
            };

            yield return new object[]            {
                new RealizationArrow(){StartPoint = new Point(500,500),EndPoint=new Point(250,250)},
                new Point(375,250),
                true
            };
        }
    }
    public class IsIncludeTests_WhenSetFormAndPoint_ShoudReturnBoolTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]            {
                new FormClass(){StartPoint=new Point(0,0), EndPoint=new Point(20,20)},
                new Point(10,10),
                true
            };

            yield return new object[]            {
                new FormClass(){StartPoint=new Point(50,50),  EndPoint=new Point(150,150)},
                new Point(51,51),
                true
            };

            yield return new object[]            {
                new FormClass(){StartPoint=new Point(50,50),  EndPoint=new Point(110,100)},
                new Point(100,100),
                true
            };
        }

    }


}
