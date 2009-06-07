using EvoLisaClone;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using System.Collections.Generic;

namespace EvoLisaCloneTest
{
    
    
    /// <summary>
    ///This is a test class for VectorImageTest and is intended
    ///to contain all VectorImageTest Unit Tests
    ///</summary>
    [TestClass()]
    public class VectorImageTest
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
            VectorImage target = new VectorImage(); // TODO: Initialize to an appropriate value
            IEnumerable<DrawnPolygon> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<DrawnPolygon> actual;
            target.Vectors = expected;
            actual = target.Vectors;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Merge
        ///</summary>
        [TestMethod()]
        public void MergeTest()
        {
            VectorImage imageA = null; // TODO: Initialize to an appropriate value
            VectorImage imageB = null; // TODO: Initialize to an appropriate value
            VectorImage expected = null; // TODO: Initialize to an appropriate value
            VectorImage actual;
            actual = VectorImage.Merge(imageA, imageB);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for VectorImage Constructor
        ///</summary>
        [TestMethod()]
        public void VectorImageConstructorTest()
        {
            VectorImage target = new VectorImage();
        }

        /// <summary>
        ///A test for Equals VectorImage
        ///</summary>
        [TestMethod()]
        public void EqualsTestVectorImage1()
        {
            VectorImage target = new VectorImage();
            VectorImage other = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.Equals(other);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Equals VectorImage
        ///</summary>
        [TestMethod()]
        public void EqualsTestVectorImage2()
        {
            VectorImage target = new VectorImage();
            VectorImage other = new VectorImage();
            bool expected = true;
            bool actual;
            actual = target.Equals(other);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Equals VectorImage
        ///</summary>
        [TestMethod()]
        public void EqualsTestVectorImage3()
        {
            VectorImage target = new VectorImage() { Vectors = new DrawnPolygon[0] };
            VectorImage other = new VectorImage();
            bool expected = true;
            bool actual;
            actual = target.Equals(other);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Equals VectorImage
        ///</summary>
        [TestMethod()]
        public void EqualsTestVectorImage4()
        {
            VectorImage target = new VectorImage() { Vectors = new DrawnPolygon[] { new DrawnPolygon() } };
            VectorImage other = new VectorImage();
            bool expected = true;
            bool actual;
            actual = target.Equals(other);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Equals VectorImage
        ///</summary>
        [TestMethod()]
        public void EqualsTestVectorImage5()
        {
            VectorImage target = new VectorImage() { Vectors = new DrawnPolygon[] { new DrawnPolygon() { Brush = Brushes.AntiqueWhite, Countour = new Polygon() { Vertices = new PointF[] { new PointF(0f, 0f), new PointF(1f, 0f) } } } } };
            VectorImage other = new VectorImage() { Vectors = new DrawnPolygon[] { new DrawnPolygon() { Brush = Brushes.AntiqueWhite, Countour = new Polygon() { Vertices = new PointF[] { new PointF(0f, 0f), new PointF(1f, 0f) } } } } };
            bool expected = true;
            bool actual;
            actual = target.Equals(other);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Equals VectorImage
        ///</summary>
        [TestMethod()]
        public void EqualsTestVectorImage6()
        {
            VectorImage target = new VectorImage() { Vectors = new DrawnPolygon[] { new DrawnPolygon() { Brush = Brushes.AntiqueWhite, Countour = new Polygon() { Vertices = new PointF[] { new PointF(0f, 0f), new PointF(1f, 0f) } } } } };
            VectorImage other = new VectorImage();
            bool expected = false;
            bool actual;
            actual = target.Equals(other);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Draw
        ///</summary>
        [TestMethod()]
        public void DrawTest1()
        {
            VectorImage target = new VectorImage();
            using (var image = new Bitmap(1, 1))
            {
                using (var canvas = Graphics.FromImage(image))
                {
                    target.Draw(canvas);
                }
                var expected = Color.FromArgb(0, 0, 0, 0);
                var actual = image.GetPixel(0, 0);
                Assert.AreEqual(expected, actual);
            }
        }

        /// <summary>
        ///A test for Draw
        ///</summary>
        [TestMethod()]
        public void DrawTest2()
        {
            var brush = Brushes.Gray;
            VectorImage target = new VectorImage()
            {
                Vectors = new DrawnPolygon[]
                {
                    new DrawnPolygon()
                    {
                         Brush = brush
                        ,Countour = new Polygon()
                        {
                            Vertices = new PointF[]
                            {
                                  new PointF( -1f, -1f)
                                , new PointF( 1f, -1f)
                                , new PointF( 1f, 1f)
                                , new PointF( -1f, 1f)
                            }
                        }
                    }
                }
            };
            using (var image = new Bitmap(1, 1))
            {
                using (var canvas = Graphics.FromImage(image))
                {
                    target.Draw(canvas);

                }
                var expected = new Pen(brush).Color;
                var actual = image.GetPixel(0, 0);
                Assert.AreEqual(expected, actual);
            }
        }

        /// <summary>
        ///A test for Equals
        ///</summary>
        [TestMethod()]
        public void EqualsTest()
        {
            VectorImage target = new VectorImage(); // TODO: Initialize to an appropriate value
            object obj = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
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
            VectorImage target = new VectorImage(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.GetHashCode();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
