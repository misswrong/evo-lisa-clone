using System.Drawing;
using System.Linq;
using EvoLisaClone;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Drawing.Imaging;

namespace EvoLisaCloneTest
{
    
    
    /// <summary>
    ///This is a test class for BitmapClonerTest and is intended
    ///to contain all BitmapClonerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class BitmapClonerTest
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
        ///A test for Clone
        ///</summary>
        [TestMethod()]
        public void CloneTest1()
        {
            BitmapCloner target = new BitmapCloner();
            var width = 2;
            var height = 2;
            using (var bitmap = new Bitmap(width, height))
            {
                long distance = long.MaxValue;
                var actual = target.Clone(bitmap, distance);
                Assert.IsTrue(actual.Vectors.Any());
            }
        }

        /// <summary>
        ///A test for Clone
        ///</summary>
        [TestMethod()]
        public void CloneTest2()
        {
            BitmapCloner target = new BitmapCloner();
            var width = 2;
            var height = 2;
            using (var bitmap = new Bitmap(width, height))
            {
                long expectedDistance = 0L;
                var actual = target.Clone(bitmap, expectedDistance);
                var actualDistance = VectorDrawingGenetics.Instance.CalculateDistance(actual, bitmap);
                Assert.IsTrue(actualDistance <= expectedDistance);
            }
        }

        /// <summary>
        ///A test for Clone
        ///</summary>
        [TestMethod()]
        public void CloneTest3()
        {
            BitmapCloner target = new BitmapCloner();
            var width = 2;
            var height = 2;
            using (var bitmap = new Bitmap(width, height))
            {
                using (var graphics = Graphics.FromImage(bitmap))
                {
                    graphics.DrawLine(Pens.Orange, new Point(0, 0), new Point(1, 1));
                }
                long expectedDistance = 512;
                var actual = target.Clone(bitmap, expectedDistance);
                var actualDistance = VectorDrawingGenetics.Instance.CalculateDistance(actual, bitmap);
                Assert.IsTrue(actualDistance <= expectedDistance);
            }
        }

        /// <summary>
        ///A test for Clone
        ///</summary>
        [TestMethod()]
        public void CloneTest4()
        {
            BitmapCloner target = new BitmapCloner();
            var fileName = Path.Combine(testContextInstance.TestDeploymentDir, "smile.png");
            using (var bitmap = new Bitmap(fileName))
            {
                long expectedDistance = 1024 * 16;
                var actual = target.Clone(bitmap, expectedDistance);
                var actualDistance = VectorDrawingGenetics.Instance.CalculateDistance(actual, bitmap);
                Assert.IsTrue(actualDistance <= expectedDistance);
                using (var cloneBitmap = new Bitmap(bitmap.Width, bitmap.Height))
                {
                    using (var graphics = Graphics.FromImage(cloneBitmap))
                    {
                        GraphicsExtensions.RasterizeVectorDrawing(graphics, actual);
                    }
                    cloneBitmap.Save("smile.bmp", ImageFormat.Bmp);
                }
            }
        }

        /// <summary>
        ///A test for Clone
        ///</summary>
        [TestMethod()]
        public void CloneTest5()
        {
            BitmapCloner target = new BitmapCloner();
            var fileName = Path.Combine(testContextInstance.TestDeploymentDir, "smile.png");
            using (var bitmap = new Bitmap(fileName))
            {
                long expectedDistance = 1024 * 16;
                var actual = target.Clone(bitmap, expectedDistance, 2);
                var actualDistance = VectorDrawingGenetics.Instance.CalculateDistance(actual, bitmap);
                Assert.IsTrue(actualDistance <= expectedDistance);
                using (var cloneBitmap = new Bitmap(bitmap.Width, bitmap.Height))
                {
                    using (var graphics = Graphics.FromImage(cloneBitmap))
                    {
                        GraphicsExtensions.RasterizeVectorDrawing(graphics, actual);
                    }
                    cloneBitmap.Save("smile.bmp", ImageFormat.Bmp);
                }
            }
        }

        /// <summary>
        ///A test for BitmapCloner Constructor
        ///</summary>
        [TestMethod()]
        public void BitmapClonerConstructorTest()
        {
            BitmapCloner target = new BitmapCloner();
        }
    }
}