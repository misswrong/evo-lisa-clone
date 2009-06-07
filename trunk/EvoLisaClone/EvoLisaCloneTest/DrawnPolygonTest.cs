using EvoLisaClone;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;

namespace EvoLisaCloneTest
{
    
    
    /// <summary>
    ///This is a test class for DrawnPolygonTest and is intended
    ///to contain all DrawnPolygonTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DrawnPolygonTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Countour
        ///</summary>
        [TestMethod()]
        public void CountourTest()
        {
            DrawnPolygon target = new DrawnPolygon(); // TODO: Initialize to an appropriate value
            Polygon expected = null; // TODO: Initialize to an appropriate value
            Polygon actual;
            target.Countour = expected;
            actual = target.Countour;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Brush
        ///</summary>
        [TestMethod()]
        public void BrushTest()
        {
            DrawnPolygon target = new DrawnPolygon(); // TODO: Initialize to an appropriate value
            Brush expected = null; // TODO: Initialize to an appropriate value
            Brush actual;
            target.Brush = expected;
            actual = target.Brush;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for DrawnPolygon Constructor
        ///</summary>
        [TestMethod()]
        public void DrawnPolygonConstructorTest()
        {
            DrawnPolygon target = new DrawnPolygon();
        }

        /// <summary>
        ///A test for Equals DrawnPolygon
        ///</summary>
        [TestMethod()]
        public void EqualsTestDrawnPolygon1()
        {
            var polygon = new Polygon() { Vertices = new PointF[0] };
            var brush = Brushes.AliceBlue;
            DrawnPolygon target = new DrawnPolygon() { Brush = brush, Countour = polygon };
            DrawnPolygon other = null;
            bool expected = false;
            var actual = target.Equals(other);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Equals DrawnPolygon
        ///</summary>
        [TestMethod()]
        public void EqualsTestDrawnPolygon2()
        {
            var polygon = new Polygon() { Vertices = new PointF[0] };
            var brush = Brushes.AliceBlue;
            DrawnPolygon target = new DrawnPolygon() { Brush = brush, Countour = polygon };
            DrawnPolygon other = new DrawnPolygon() { Brush = brush, Countour = polygon };
            bool expected = true;
            var actual = target.Equals(other);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Equals DrawnPolygon
        ///</summary>
        [TestMethod()]
        public void EqualsTestDrawnPolygon3()
        {
            var polygon = new Polygon() { Vertices = new PointF[0] };
            var brush1 = Brushes.AliceBlue;
            var brush2 = Brushes.AntiqueWhite;
            DrawnPolygon target = new DrawnPolygon() { Brush = brush1, Countour = polygon };
            DrawnPolygon other = new DrawnPolygon() { Brush = brush2, Countour = polygon };
            bool expected = false;
            var actual = target.Equals(other);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Equals DrawnPolygon
        ///</summary>
        [TestMethod()]
        public void EqualsTestDrawnPolygon4()
        {
            var polygon1 = new Polygon() { Vertices = new PointF[0] };
            var polygon2 = new Polygon() { Vertices = new PointF[] { new PointF(0, 0) } };
            var brush = Brushes.AliceBlue;
            DrawnPolygon target = new DrawnPolygon() { Brush = brush, Countour = polygon1 };
            DrawnPolygon other = new DrawnPolygon() { Brush = brush, Countour = polygon2 };
            bool expected = false;
            var actual = target.Equals(other);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Equals
        ///</summary>
        [TestMethod()]
        public void EqualsTest1()
        {
            DrawnPolygon target = new DrawnPolygon(); // TODO: Initialize to an appropriate value
            object obj = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.Equals(obj);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Equals
        ///</summary>
        [TestMethod()]
        public void EqualsTest2()
        {
            DrawnPolygon target = new DrawnPolygon(); // TODO: Initialize to an appropriate value
            object obj = new DrawnPolygon();
            bool expected = true;
            bool actual;
            actual = target.Equals(obj);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for GetHashCode
        ///</summary>
        [TestMethod()]
        public void GetHashCodeTest()
        {
            DrawnPolygon target = new DrawnPolygon(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.GetHashCode();
            Assert.AreEqual(expected, actual);
        }
    }
}
