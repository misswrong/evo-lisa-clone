using EvoLisaClone;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
namespace EvoLisaCloneTest
{
    
    
    /// <summary>
    ///This is a test class for VectorDrawingTest and is intended
    ///to contain all VectorDrawingTest Unit Tests
    ///</summary>
    [TestClass()]
    public class VectorDrawingTest
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
        ///A test for Vectors
        ///</summary>
        [TestMethod()]
        public void VectorsTest()
        {
            VectorDrawing target = new VectorDrawing();
            ColoredTriangle[] expected = null;
            target.Vectors = expected;
            var actual = target.Vectors;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for GetHashCode
        ///</summary>
        [TestMethod()]
        public void GetHashCodeTest()
        {
            VectorDrawing target = new VectorDrawing();
            int expected = 0;
            int actual;
            actual = target.GetHashCode();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Equals
        ///</summary>
        [TestMethod()]
        public void EqualsTest()
        {
            VectorDrawing target = new VectorDrawing();
            object obj = null;
            bool expected = false;
            bool actual;
            actual = target.Equals(obj);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Equals
        ///</summary>
        [TestMethod()]
        public void EqualsVectorDrawingTest1()
        {
            VectorDrawing target = new VectorDrawing() { Vectors = new ColoredTriangle[] { new ColoredTriangle() { Brush = Brushes.Black, Vertices = new Point[] { new Point(0, 0), new Point(1, 1), new Point(0, 1) } } } };
            VectorDrawing other = null;
            bool expected = false;
            bool actual;
            actual = target.Equals(other);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Equals
        ///</summary>
        [TestMethod()]
        public void EqualsVectorDrawingTest2()
        {
            VectorDrawing target = new VectorDrawing() { Vectors = new ColoredTriangle[] { new ColoredTriangle() { Brush = Brushes.Black, Vertices = new Point[] { new Point(0, 0), new Point(1, 1), new Point(0, 1) } } } };
            VectorDrawing other = new VectorDrawing() { Vectors = new ColoredTriangle[] { new ColoredTriangle() { Brush = Brushes.Black, Vertices = new Point[] { new Point(0, 0), new Point(1, 1), new Point(0, 1) } } } };
            bool expected = true;
            bool actual;
            actual = target.Equals(other);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Equals
        ///</summary>
        [TestMethod()]
        public void EqualsVectorDrawingTest3()
        {
            VectorDrawing target = new VectorDrawing() { Vectors = new ColoredTriangle[] { new ColoredTriangle() { Brush = Brushes.Black, Vertices = new Point[] { new Point(0, 0), new Point(1, 1), new Point(0, 1) } } } };
            VectorDrawing other = new VectorDrawing() { Vectors = new ColoredTriangle[] { new ColoredTriangle() { Brush = Brushes.Black, Vertices = new Point[] { new Point(0, 0), new Point(1, 1), new Point(1, 0) } } } };
            bool expected = true;
            bool actual;
            actual = target.Equals(other);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Equals
        ///</summary>
        [TestMethod()]
        public void EqualsVectorDrawingTest4()
        {
            VectorDrawing target = new VectorDrawing() { Vectors = new ColoredTriangle[] { new ColoredTriangle() { Brush = Brushes.Black, Vertices = new Point[] { new Point(0, 0), new Point(1, 1), new Point(0, 1) } } } };
            VectorDrawing other = new VectorDrawing() { Vectors = new ColoredTriangle[] { new ColoredTriangle() { Brush = Brushes.Gray, Vertices = new Point[] { new Point(0, 0), new Point(1, 1), new Point(0, 1) } } } };
            bool expected = false;
            bool actual;
            actual = target.Equals(other);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Equals
        ///</summary>
        [TestMethod()]
        public void EqualsVectorDrawingTest5()
        {
            VectorDrawing target = new VectorDrawing() { Vectors = new ColoredTriangle[] { new ColoredTriangle() { Brush = Brushes.Black, Vertices = new Point[] { new Point(0, 0), new Point(1, 1), new Point(0, 1) } } } };
            VectorDrawing other = new VectorDrawing() { Vectors = new ColoredTriangle[] { new ColoredTriangle() { Brush = Brushes.Black, Vertices = new Point[] { new Point(0, 0), new Point(1, 1), new Point(0, 1) } }, new ColoredTriangle() { Brush = Brushes.Black, Vertices = new Point[] { new Point(0, 0), new Point(1, 1), new Point(0, 1) } }, new ColoredTriangle() { Brush = Brushes.Black, Vertices = new Point[] { new Point(0, 0), new Point(1, 1), new Point(0, 1) } } } };
            bool expected = false;
            bool actual;
            actual = target.Equals(other);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Equals
        ///</summary>
        [TestMethod()]
        public void EqualsVectorDrawingTest6()
        {
            VectorDrawing target = new VectorDrawing() { Vectors = new ColoredTriangle[] { new ColoredTriangle() { Brush = Brushes.Black, Vertices = new Point[] { new Point(0, 0), new Point(1, 1), new Point(0, 1) } } } };
            VectorDrawing other = target;
            bool expected = true;
            bool actual;
            actual = target.Equals(other);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for VectorDrawing Constructor
        ///</summary>
        [TestMethod()]
        public void VectorDrawingConstructorTest()
        {
            VectorDrawing target = new VectorDrawing();
        }
    }
}
