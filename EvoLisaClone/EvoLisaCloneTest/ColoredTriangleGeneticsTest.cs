using System.Linq;
using EvoLisaClone;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace EvoLisaCloneTest
{
    
    
    /// <summary>
    ///This is a test class for ColoredTriangleGeneticsTest and is intended
    ///to contain all ColoredTriangleGeneticsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ColoredTriangleGeneticsTest
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
        ///A test for Instance
        ///</summary>
        [TestMethod()]
        public void InstanceTest()
        {
            ColoredTriangleGenetics actual;
            actual = ColoredTriangleGenetics.Instance;
        }

        /// <summary>
        ///A test for Create
        ///</summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Argument 'width' must be greater than 1.")]
        public void CreateTest1()
        {
            var target = ColoredTriangleGenetics.Instance;
            int width = 1;
            int height = 2;
            var actual = target.Create(width, height);
        }

        /// <summary>
        ///A test for Create
        ///</summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Argument height' must be greater than 1.")]
        public void CreateTest2()
        {
            var target = ColoredTriangleGenetics.Instance;
            int width = 2;
            int height = 1;
            var actual = target.Create(width, height);
        }

        /// <summary>
        ///A test for Create
        ///</summary>
        [TestMethod()]
        public void CreateTest3()
        {
            var target = ColoredTriangleGenetics.Instance;
            int width = 2;
            int height = 2;
            ColoredTriangle actual;
            actual = target.Create(width, height);
            Assert.AreEqual(3, actual.Vertices.Count());
            Assert.IsNotNull(actual.Brush);
        }

        /// <summary>
        ///A test for ColoredTriangleGenetics Constructor
        ///</summary>
        [TestMethod()]
        [DeploymentItem("EvoLisaClone.dll")]
        public void ColoredTriangleGeneticsConstructorTest()
        {
            ColoredTriangleGenetics_Accessor target = new ColoredTriangleGenetics_Accessor();
        }
    }
}
