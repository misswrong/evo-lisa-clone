using EvoLisaClone;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;

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
            var heigth = 2;
            var first = target.Create(width, heigth);
            var second = target.Create(width, heigth);
            Assert.AreNotEqual(first, second);
        }
    }
}