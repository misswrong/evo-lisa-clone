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
        ///A test for GetHashCode
        ///</summary>
        [TestMethod()]
        public void GetHashCodeTest()
        {
            PointF point = new PointF();
            int expected = 0;
            int actual;
            actual = PointExtensions.GetHashCode(point);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for AreEqual
        ///</summary>
        [TestMethod()]
        public void AreEqualTest1()
        {
            PointF pointA = new PointF();
            PointF pointB = new PointF();
            bool expected = true;
            bool actual;
            actual = PointExtensions.AreEqual(pointA, pointB);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for AreEqual
        ///</summary>
        [TestMethod()]
        public void AreEqualTest2()
        {
            PointF pointA = new PointF(1f, 0f);
            PointF pointB = new PointF();
            bool expected = false;
            bool actual;
            actual = PointExtensions.AreEqual(pointA, pointB);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for AreEqual
        ///</summary>
        [TestMethod()]
        public void AreEqualTest3()
        {
            PointF pointA = new PointF(0f, 1f);
            PointF pointB = new PointF();
            bool expected = false;
            bool actual;
            actual = PointExtensions.AreEqual(pointA, pointB);
            Assert.AreEqual(expected, actual);
        }
    }
}
