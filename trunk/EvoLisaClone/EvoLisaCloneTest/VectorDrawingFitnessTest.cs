using EvoLisaClone;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;

namespace EvoLisaCloneTest
{
    
    
    /// <summary>
    ///This is a test class for VectorDrawingFitnessTest and is intended
    ///to contain all VectorDrawingFitnessTest Unit Tests
    ///</summary>
    [TestClass()]
    public class VectorDrawingFitnessTest
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
        ///A test for Original
        ///</summary>
        [TestMethod()]
        public void OriginalTest()
        {
            VectorDrawingFitness target = new VectorDrawingFitness();
            Bitmap expected = null;
            target.Original = expected;
            var actual = target.Original;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Distance
        ///</summary>
        [TestMethod()]
        public void DistanceTest1()
        {
            VectorDrawingFitness target = new VectorDrawingFitness();
            VectorDrawing vectorDrawing = null;
            long expected = 0;
            long actual;
            actual = target.CalculateDistance(vectorDrawing);
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
                VectorDrawingFitness target = new VectorDrawingFitness() { Original = bitmap };
                long expected = color.R + color.G + color.B;
                long actual;
                actual = target.CalculateDistance(vectorDrawing);
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
                VectorDrawingFitness target = new VectorDrawingFitness() { Original = bitmap };
                long expected = 0;
                long actual;
                actual = target.CalculateDistance(vectorDrawing);
                Assert.AreEqual(expected, actual);
            }
        }

        /// <summary>
        ///A test for VectorDrawingFitness Constructor
        ///</summary>
        [TestMethod()]
        public void VectorDrawingFitnessConstructorTest()
        {
            VectorDrawingFitness target = new VectorDrawingFitness();
        }
    }
}