using System.Drawing;
using System.Linq;
using EvoLisaClone;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EvoLisaCloneTest
{
    
    
    /// <summary>
    ///This is a test class for VectorDrawingGeneticsTest and is intended
    ///to contain all VectorDrawingGeneticsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class VectorDrawingGeneticsTest
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
        ///A test for Distance
        ///</summary>
        [TestMethod()]
        public void DistanceTest1()
        {
            VectorDrawingGenetics target = VectorDrawingGenetics.Instance;
            VectorDrawing vectorDrawing = null;
            long expected = 0;
            long actual;
            actual = target.CalculateDistance(vectorDrawing, null);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Distance
        ///</summary>
        [TestMethod()]
        public void DistanceTest2()
        {
            var color = Color.Orange;
            var vectorDrawing = new VectorDrawing()
            {
                Vectors = new ColoredTriangle[]
                    {
                        new ColoredTriangle()
                        {
                            Brush = new SolidBrush(color),
                            Vertices = new Point[]
                            {
                                new Point(-1,-1),
                                new Point(2,-1),
                                new Point(-1,2)
                            }
                        }
                    }
            };
            using (var bitmap = new Bitmap(1, 1))
            {
                VectorDrawingGenetics target = VectorDrawingGenetics.Instance;
                long expected = color.R + color.G + color.B;
                long actual;
                actual = target.CalculateDistance(vectorDrawing, bitmap);
                Assert.AreEqual(expected, actual);
            }
        }

        /// <summary>
        ///A test for Distance
        ///</summary>
        [TestMethod()]
        public void DistanceTest3()
        {
            var vectorDrawing = new VectorDrawing()
            {
                Vectors = new ColoredTriangle[]
                    {
                        new ColoredTriangle()
                        {
                            Brush = Brushes.Black,
                            Vertices = new Point[]
                            {
                                new Point(-1,-1),
                                new Point(2,-1),
                                new Point(-1,2)
                            }
                        }
                    }
            };
            using (var bitmap = new Bitmap(1, 1))
            {
                using (var graphics = Graphics.FromImage(bitmap))
                {
                    GraphicsExtensions.RasterizeVectorDrawing(graphics, vectorDrawing);
                }
                VectorDrawingGenetics target = VectorDrawingGenetics.Instance;
                long expected = 0;
                long actual;
                actual = target.CalculateDistance(vectorDrawing, bitmap);
                Assert.AreEqual(expected, actual);
            }
        }

        /// <summary>
        ///A test for VectorDrawingGenetics Constructor
        ///</summary>
        [TestMethod()]
        [DeploymentItem("EvoLisaClone.dll")]
        public void VectorDrawingGeneticsConstructorTest()
        {
            VectorDrawingGenetics_Accessor target = new VectorDrawingGenetics_Accessor();
        }

        /// <summary>
        ///A test for Create
        ///</summary>
        [TestMethod()]
        public void CreateTest()
        {
            var target = VectorDrawingGenetics.Instance;
            var width = 2;
            var height = 2;
            var length = 1;
            var first = target.Create(width, height, length);
            var second = target.Create(width, height, length);
            Assert.AreNotEqual(first, second);
        }

        /// <summary>
        ///A test for CrossOver
        ///</summary>
        [TestMethod()]
        public void CrossOverTest1()
        {
            var target = VectorDrawingGenetics.Instance;
            var width = 2;
            var height = 2;
            var length = 1;
            var drawingA = target.Create(width, height, length);
            var drawingB = target.Create(width, height, length);
            var actual = target.CrossOver(drawingA, drawingB);
            Assert.AreEqual(drawingA, actual);
        }

        /// <summary>
        ///A test for CrossOver
        ///</summary>
        [TestMethod()]
        public void CrossOverTest2()
        {
            var target = VectorDrawingGenetics.Instance;
            var width = 2;
            var height = 2;
            var length = 2;
            var drawingA = VectorDrawingGenetics.Instance.Create(width, height, length);
            var drawingB = VectorDrawingGenetics.Instance.Create(width, height, length);
            var actual = target.CrossOver(drawingA, drawingB);
            Assert.AreNotEqual(drawingA, actual);
            Assert.AreNotEqual(drawingB, actual);
            Assert.AreEqual(drawingA.Vectors.Count(), actual.Vectors.Count());
            Assert.AreEqual(drawingB.Vectors.Count(), actual.Vectors.Count());
            var intersection = actual.Vectors.Intersect(drawingA.Vectors.Union(drawingB.Vectors));
            Assert.IsTrue(intersection.SequenceEqual(actual.Vectors));
        }

        /// <summary>
        ///A test for CrossOver
        ///</summary>
        [TestMethod()]
        public void CrossOverTest3()
        {
            var target = VectorDrawingGenetics.Instance;
            var width = 2;
            var height = 2;
            var lengthA = 2;
            var lengthB = 3;
            var drawingA = VectorDrawingGenetics.Instance.Create(width, height, lengthA);
            var drawingB = VectorDrawingGenetics.Instance.Create(width, height, lengthB);
            var actual = target.CrossOver(drawingA, drawingB);
            Assert.IsTrue(actual.Vectors.Count() == Math.Max(lengthA, lengthB));
        }

        /// <summary>
        ///A test for Mutate
        ///</summary>
        [TestMethod()]
        public void MutateTest()
        {
            var target = VectorDrawingGenetics.Instance;
            var width = 2;
            var height = 2;
            var length = 2;
            var drawing = VectorDrawingGenetics.Instance.Create(width, height, length);
            var first = target.Mutate(drawing, width, height);
            var second = target.Mutate(first, width, height);
            Assert.IsNotNull(first);
            Assert.IsNotNull(second);
            Assert.AreNotEqual(drawing, first);
            Assert.AreNotEqual(first, second);
            Assert.AreNotEqual(drawing.Vectors.Count(), first.Vectors.Count());
            Assert.AreNotEqual(first.Vectors.Count(), second.Vectors.Count());
        }
    }
}