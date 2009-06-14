using EvoLisaClone;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;

namespace EvoLisaCloneTest
{
    
    
    /// <summary>
    ///This is a test class for BrushGeneticsTest and is intended
    ///to contain all BrushGeneticsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class BrushGeneticsTest
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
            BrushGenetics actual;
            actual = BrushGenetics.Instance;
        }

        /// <summary>
        ///A test for Create
        ///</summary>
        [TestMethod()]
        public void CreateTest()
        {
            var target = BrushGenetics.Instance;
            var first = target.Create();
            var second = target.Create();
            Assert.AreNotEqual(first, second);
        }

        /// <summary>
        ///A test for BrushGenetics Constructor
        ///</summary>
        [TestMethod()]
        [DeploymentItem("EvoLisaClone.dll")]
        public void BrushGeneticsConstructorTest()
        {
            BrushGenetics_Accessor target = new BrushGenetics_Accessor();
        }
    }
}