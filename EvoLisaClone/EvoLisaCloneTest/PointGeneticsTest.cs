using EvoLisaClone;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using System;

namespace EvoLisaCloneTest
{
    
    
    /// <summary>
    ///This is a test class for PointGeneticsTest and is intended
    ///to contain all PointGeneticsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PointGeneticsTest
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
        ///A test for PointGenetics Constructor
        ///</summary>
        [TestMethod()]
        [DeploymentItem("EvoLisaClone.dll")]
        public void PointGeneticsConstructorTest()
        {
            PointGenetics_Accessor target = new PointGenetics_Accessor();
        }

        /// <summary>
        ///A test for Instance
        ///</summary>
        [TestMethod()]
        public void InstanceTest()
        {
            PointGenetics actual;
            actual = PointGenetics.Instance;
        }

        /// <summary>
        ///A test for Create
        ///</summary>
        [TestMethod()]
        public void CreateTest1()
        {
            PointGenetics target = PointGenetics.Instance;
            var width = 1;
            var height = 1;
            var expected = new Point(0, 0);
            var actual = target.Create(width, height);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Create
        ///</summary>
        [TestMethod()]
        public void CreateTest2()
        {
            PointGenetics target = PointGenetics.Instance;
            var width = 2;
            var height = 3;
            var actual = target.Create(width, height);
            Assert.IsTrue(actual.X < width);
            Assert.IsTrue(actual.Y < height);
        }

        /// <summary>
        ///A test for Create
        ///</summary>
        [TestMethod()]
        public void CreateTest3()
        {
            PointGenetics target = PointGenetics.Instance;
            var width = int.MaxValue;
            var height = int.MaxValue;
            var first = target.Create(width, height);
            var second = target.Create(width, height);
            Assert.AreNotEqual(first, second);
        }

        /// <summary>
        ///A test for Create
        ///</summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Argument 'width' must be greater than 0.")]
        public void CreateTest4()
        {
            PointGenetics target = PointGenetics.Instance;
            var width = 0;
            var height = 1;
            var actual = target.Create(width, height);
        }

        /// <summary>
        ///A test for Create
        ///</summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Argument 'height' must be greater than 0.")]
        public void CreateTest5()
        {
            PointGenetics target = PointGenetics.Instance;
            var width = 1;
            var height = 0;
            var actual = target.Create(width, height);
        }
    }
}
