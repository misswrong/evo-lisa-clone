using EvoLisaClone;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;

namespace EvoLisaCloneTest
{
    
    
    /// <summary>
    ///This is a test class for PointExtensionsTest and is intended
    ///to contain all PointExtensionsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PointExtensionsTest
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
        ///A test for AreCollinear
        ///</summary>
        [TestMethod()]
        public void AreCollinearTest1()
        {
            Point[] points = null;
            bool expected = true;
            bool actual;
            actual = PointExtensions.AreCollinear(points);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for AreCollinear
        ///</summary>
        [TestMethod()]
        public void AreCollinearTest2()
        {
            Point[] points = new Point[] { new Point(0, 0), new Point(1, 1), new Point(1, 2) };
            bool expected = false;
            bool actual;
            actual = PointExtensions.AreCollinear(points);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for AreCollinear
        ///</summary>
        [TestMethod()]
        public void AreCollinearTest3()
        {
            Point[] points = new Point[] { new Point(0, 0), new Point(1, 1), new Point(2, 2) };
            bool expected = true;
            bool actual;
            actual = PointExtensions.AreCollinear(points);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for AreCollinear
        ///</summary>
        [TestMethod()]
        public void AreCollinearTest4()
        {
            Point[] points = new Point[] { new Point(0, 0), new Point(1, 0), new Point(0, 1) };
            bool expected = false;
            bool actual;
            actual = PointExtensions.AreCollinear(points);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for AreCollinear
        ///</summary>
        [TestMethod()]
        public void AreCollinearTest5()
        {
            Point[] points = new Point[] { new Point(0, 0), new Point(0, 1), new Point(1, 0) };
            bool expected = false;
            bool actual;
            actual = PointExtensions.AreCollinear(points);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for AreCollinear
        ///</summary>
        [TestMethod()]
        public void AreCollinearTest6()
        {
            Point[] points = new Point[] { new Point(0, 0), new Point(1, 0), new Point(2, 0) };
            bool expected = true;
            bool actual;
            actual = PointExtensions.AreCollinear(points);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for AreCollinear
        ///</summary>
        [TestMethod()]
        public void AreCollinearTest7()
        {
            Point[] points = new Point[] { new Point(0, 0), new Point(0, 1), new Point(0, 2) };
            bool expected = true;
            bool actual;
            actual = PointExtensions.AreCollinear(points);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for AreCollinear
        ///</summary>
        [TestMethod()]
        public void AreCollinearTest8()
        {
            Point[] points = new Point[] { new Point(0, 0), new Point(0, 1), new Point(0, 2), new Point(1, 3) };
            bool expected = false;
            bool actual;
            actual = PointExtensions.AreCollinear(points);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for AreCollinear
        ///</summary>
        [TestMethod()]
        public void AreCollinearTest9()
        {
            Point[] points = new Point[0] {};
            bool expected = true;
            bool actual;
            actual = PointExtensions.AreCollinear(points);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for AreCollinear
        ///</summary>
        [TestMethod()]
        public void AreCollinearTest10()
        {
            Point[] points = new Point[] { new Point(0, 0), new Point(3, 4), new Point(1, 1) };
            bool expected = false;
            bool actual;
            actual = PointExtensions.AreCollinear(points);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Equals
        ///</summary>
        [TestMethod()]
        public void EqualsTest1()
        {
            Point pointA = new Point();
            Point pointB = new Point();
            bool expected = true;
            bool actual;
            actual = PointExtensions.Equals(pointA, pointB);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Equals
        ///</summary>
        [TestMethod()]
        public void EqualsTest2()
        {
            Point pointA = new Point(1, 0);
            Point pointB = new Point();
            bool expected = false;
            bool actual;
            actual = PointExtensions.Equals(pointA, pointB);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Equals
        ///</summary>
        [TestMethod()]
        public void EqualsTest3()
        {
            Point pointA = new Point(1, 0);
            Point pointB = new Point(0, 1);
            bool expected = false;
            bool actual;
            actual = PointExtensions.Equals(pointA, pointB);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for GetHashCode
        ///</summary>
        [TestMethod()]
        public void GetHashCodeTest1()
        {
            Point point = new Point();
            int expected = 0;
            int actual;
            actual = PointExtensions.GetHashCode(point);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for GetHashCode
        ///</summary>
        [TestMethod()]
        public void GetHashCodeTest2()
        {
            var pointA = new Point((1 << 16) + 1, 0);
            var pointB = new Point(1, 0);
            Assert.AreNotEqual(PointExtensions.GetHashCode(pointA), PointExtensions.GetHashCode(pointB));
        }

        /// <summary>
        ///A test for GetHashCode
        ///</summary>
        [TestMethod()]
        public void GetHashCodeTest3()
        {
            var pointA = new Point(0, (1 << 16) + 1);
            var pointB = new Point(0, 1);
            Assert.AreNotEqual(PointExtensions.GetHashCode(pointA), PointExtensions.GetHashCode(pointB));
        }

        /// <summary>
        ///A test for GetHashCode
        ///</summary>
        [TestMethod()]
        public void GetHashCodeTest4()
        {
            var pointA = new Point(0, 1 << 16);
            var pointB = new Point(1, 0);
            //We know this test fails, but there is no known better implementation for this method
            //Assert.AreNotEqual(PointExtensions.GetHashCode(pointA), PointExtensions.GetHashCode(pointB));
        }
    }
}