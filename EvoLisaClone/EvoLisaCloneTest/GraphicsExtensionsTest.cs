using EvoLisaClone;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;

namespace EvoLisaCloneTest
{
    
    
    /// <summary>
    ///This is a test class for GraphicsExtensionsTest and is intended
    ///to contain all GraphicsExtensionsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class GraphicsExtensionsTest
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
        ///A test for FillColoredTriangle
        ///</summary>
        [TestMethod()]
        public void FillColoredTriangleTest1()
        {
            var expected = Color.Orange;
            ColoredTriangle coloredTriangle = new ColoredTriangle()
            {
                Brush = new SolidBrush(expected),
                Vertices = new Point[]
                {
                    new Point(-1,-1),
                    new Point(-1,2),
                    new Point(2,-1)
                }
            };
            using (var bitmap = new Bitmap(1, 1))
            {
                using (var graphics = Graphics.FromImage(bitmap))
                {
                    GraphicsExtensions.FillColoredTriangle(graphics, coloredTriangle);
                }
                var actual = bitmap.GetPixel(0, 0);
                Assert.AreEqual(expected.R, actual.R);
                Assert.AreEqual(expected.G, actual.G);
                Assert.AreEqual(expected.B, actual.B);
            }
        }
    }
}
