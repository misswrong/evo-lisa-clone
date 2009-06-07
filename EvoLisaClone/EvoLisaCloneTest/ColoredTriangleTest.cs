﻿using EvoLisaClone;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;

namespace EvoLisaCloneTest
{
    
    
    /// <summary>
    ///This is a test class for ColoredTriangleTest and is intended
    ///to contain all ColoredTriangleTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ColoredTriangleTest
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
        ///A test for Vertices
        ///</summary>
        [TestMethod()]
        public void VerticesTest1()
        {
            ColoredTriangle target = new ColoredTriangle();
            Point[] input = null;
            Point[] expected = input;
            Point[] actual;
            target.Vertices = expected;
            actual = target.Vertices;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Vertices
        ///</summary>
        [TestMethod()]
        public void VerticesTest2()
        {
            ColoredTriangle target = new ColoredTriangle();
            Point[] input = new Point[] { new Point(0, 0), new Point(0, 1), new Point(1, 0) };
            Point[] expected = input;
            Point[] actual;
            target.Vertices = expected;
            actual = target.Vertices;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Vertices
        ///Expected null because the three points are colinear
        ///</summary>
        [TestMethod()]
        public void VerticesTest3()
        {
            ColoredTriangle target = new ColoredTriangle();
            Point[] input = new Point[] { new Point(0, 0), new Point(0, 1), new Point(0, 2) };
            Point[] expected = null;
            Point[] actual;
            target.Vertices = input;
            actual = target.Vertices;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for ColoredTriangle Constructor
        ///</summary>
        [TestMethod()]
        public void ColoredTriangleConstructorTest()
        {
            ColoredTriangle target = new ColoredTriangle();
        }
    }
}