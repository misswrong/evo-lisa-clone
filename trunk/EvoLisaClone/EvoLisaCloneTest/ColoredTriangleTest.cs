using EvoLisaClone;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;

namespace EvoLisaCloneTest
{
    
    
    /// <summary>
    ///This is a test class for ColoredTriangleTest and is intended
    ///to contain all ColoredTriangleTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ColoredTriangleTest
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
        ///A test for Vertices
        ///</summary>
        [TestMethod()]
        public void VerticesTest1()
        {
            ColoredTriangle target = new ColoredTriangle();
            Point[] input = null;
            var expected = input;
            target.Vertices = expected;
            var actual = target.Vertices;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Vertices
        ///</summary>
        [TestMethod()]
        public void VerticesTest2()
        {
            ColoredTriangle target = new ColoredTriangle();
            var input = new Point[] { new Point(0, 0), new Point(0, 1), new Point(1, 0) };
            var expected = input;
            target.Vertices = expected;
            var actual = target.Vertices;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Vertices
        ///Expected null because the three points are colinear
        ///</summary>
        [TestMethod()]
        public void VerticesTest3()
        {
            ColoredTriangle target = new ColoredTriangle();
            Point[] input = new Point[] { new Point(0, 0), new Point(0, 1), new Point(0, 2) };
            Point[] expected = null;
            target.Vertices = input;
            var actual = target.Vertices;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for ColoredTriangle Constructor
        ///</summary>
        [TestMethod()]
        public void ColoredTriangleConstructorTest()
        {
            ColoredTriangle target = new ColoredTriangle();
        }

        /// <summary>
        ///A test for Brush
        ///</summary>
        [TestMethod()]
        public void BrushTest()
        {
            ColoredTriangle target = new ColoredTriangle();
            Brush expected = null;
            Brush actual;
            target.Brush = expected;
            actual = target.Brush;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Equals
        ///</summary>
        [TestMethod()]
        public void EqualsTest()
        {
            ColoredTriangle target = new ColoredTriangle();
            object other = null;
            bool expected = false;
            bool actual;
            actual = target.Equals(other);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for EqualsColoredTriangle
        ///</summary>
        [TestMethod()]
        public void EqualsColoredTriangleTest1()
        {
            ColoredTriangle target = new ColoredTriangle();
            ColoredTriangle other = null;
            bool expected = false;
            bool actual;
            actual = target.Equals(other);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Equals
        ///</summary>
        [TestMethod()]
        public void EqualsColoredTriangleTest2()
        {
            ColoredTriangle target = new ColoredTriangle();
            ColoredTriangle other = new ColoredTriangle();
            bool expected = true;
            bool actual;
            actual = target.Equals(other);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Equals
        ///</summary>
        [TestMethod()]
        public void EqualsColoredTriangleTest3()
        {
            ColoredTriangle target = new ColoredTriangle() { Brush = Brushes.AliceBlue };
            ColoredTriangle other = new ColoredTriangle();
            bool expected = false;
            bool actual;
            actual = target.Equals(other);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Equals
        ///</summary>
        [TestMethod()]
        public void EqualsColoredTriangleTest4()
        {
            ColoredTriangle target = new ColoredTriangle() { Brush = Brushes.AliceBlue };
            ColoredTriangle other = new ColoredTriangle() { Brush = Brushes.AliceBlue };
            bool expected = true;
            bool actual;
            actual = target.Equals(other);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Equals
        ///</summary>
        [TestMethod()]
        public void EqualsColoredTriangleTest5()
        {
            ColoredTriangle target = new ColoredTriangle() { Vertices = new Point[] { new Point(0, 0), new Point(0, 1), new Point(1, 0) } };
            ColoredTriangle other = new ColoredTriangle();
            bool expected = false;
            bool actual;
            actual = target.Equals(other);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Equals
        ///</summary>
        [TestMethod()]
        public void EqualsColoredTriangleTest6()
        {
            ColoredTriangle target = new ColoredTriangle() { Vertices = new Point[] { new Point(0, 0), new Point(0, 1), new Point(1, 0) } };
            ColoredTriangle other = new ColoredTriangle() { Vertices = new Point[] { new Point(0, 0), new Point(0, 1), new Point(1, 0) } };
            bool expected = true;
            bool actual;
            actual = target.Equals(other);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Equals
        ///</summary>
        [TestMethod()]
        public void EqualsColoredTriangleTest7()
        {
            ColoredTriangle target = new ColoredTriangle() { Vertices = new Point[] { new Point(0, 1), new Point(1, 0), new Point(2, 3) } };
            ColoredTriangle other = new ColoredTriangle() { Vertices = new Point[] { new Point(0, 0), new Point(1, 1), new Point(2, 3) } };
            bool expected = false;
            bool actual;
            actual = target.Equals(other);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Equals
        ///</summary>
        [TestMethod()]
        public void EqualsColoredTriangleTest8()
        {
            ColoredTriangle target = new ColoredTriangle() { Vertices = new Point[] { new Point(0, 1), new Point(1, 1), new Point(0, 0) } };
            ColoredTriangle other = new ColoredTriangle() { Vertices = new Point[] { new Point(0, 2), new Point(1, 2), new Point(0, 0) } };
            bool expected = false;
            bool actual;
            actual = target.Equals(other);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Equals
        ///</summary>
        [TestMethod()]
        public void EqualsColoredTriangleTest9()
        {
            ColoredTriangle target = new ColoredTriangle() { Vertices = new Point[] { new Point(0, 1), new Point(1, 1), new Point(0, 0) } };
            ColoredTriangle other = target;
            bool expected = true;
            bool actual = target.Equals(other);
            Assert.AreEqual(expected, actual);
        }
    }
}