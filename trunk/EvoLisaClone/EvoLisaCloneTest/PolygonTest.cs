using EvoLisaClone;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using System.Collections.Generic;

namespace EvoLisaCloneTest
{
    
    
    /// <summary>
    ///This is a test class for PolygonTest and is intended
    ///to contain all PolygonTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PolygonTest
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
        public void VerticesTest()
        {
            Polygon target = new Polygon(); // TODO: Initialize to an appropriate value
            PointF[] expected = null; // TODO: Initialize to an appropriate value
            PointF[] actual;
            target.Vertices = expected;
            actual = target.Vertices;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Polygon Constructor
        ///</summary>
        [TestMethod()]
        public void PolygonConstructorTest()
        {
            Polygon target = new Polygon();
        }

        /// <summary>
        ///A test for GetHashCode
        ///</summary>
        [TestMethod()]
        public void GetHashCodeTest1()
        {
            Polygon target = new Polygon();
            int expected = 0;
            int actual;
            actual = target.GetHashCode();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for GetHashCode
        ///</summary>
        [TestMethod()]
        public void GetHashCodeTest2()
        {
            Polygon target = new Polygon() { Vertices = new PointF[0] };
            int expected = 0;
            int actual;
            actual = target.GetHashCode();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for GetHashCode
        ///</summary>
        [TestMethod()]
        public void GetHashCodeTest3()
        {
            Polygon target = new Polygon() { Vertices = new PointF[] { new PointF(0f, 0f) } };
            int expected = 0; // 0f.GetHashCode() + 0f.GetHashCode()
            int actual;
            actual = target.GetHashCode();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Equals
        ///</summary>
        [TestMethod()]
        public void EqualsTest1()
        {
            var pointArray = new PointF[0];
            Polygon target = new Polygon() { Vertices = pointArray };
            object obj = new object();
            bool expected = false;
            var actual = target.Equals(obj);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Equals
        ///</summary>
        [TestMethod()]
        public void EqualsTest2()
        {
            var pointArray = new PointF[0];
            Polygon target = new Polygon() { Vertices = pointArray };
            object obj = new Polygon() { Vertices = pointArray };
            bool expected = true;
            var actual = target.Equals(obj);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for EqualsPolygon
        ///</summary>
        [TestMethod()]
        public void EqualsPolygonTest1()
        {
            var pointArray = new PointF[0];
            Polygon target = new Polygon() { Vertices = pointArray };
            Polygon other = new Polygon() { Vertices = pointArray };
            bool expected = true;
            var actual = target.Equals(other);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for EqualsPolygon
        ///</summary>
        [TestMethod()]
        public void EqualsPolygonTest2()
        {
            var point = new PointF(0, 0);
            var pointArrayA = new PointF[0];
            var pointArrayB = new PointF[] { point };
            Polygon target = new Polygon() { Vertices = pointArrayA };
            Polygon other = new Polygon() { Vertices = pointArrayB };
            bool expected = true;
            var actual = target.Equals(other);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for EqualsPolygon
        ///</summary>
        [TestMethod()]
        public void EqualsPolygonTest3()
        {
            var pointA = new PointF(0, 0);
            var pointB = new PointF(1, 0);
            var pointArrayA = new PointF[] { pointA };
            var pointArrayB = new PointF[] { pointB };
            Polygon target = new Polygon() { Vertices = pointArrayA };
            Polygon other = new Polygon() { Vertices = pointArrayB };
            bool expected = true;
            var actual = target.Equals(other);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for EqualsPolygon
        ///</summary>
        [TestMethod()]
        public void EqualsPolygonTest4()
        {
            var pointA = new PointF(0, 0);
            var pointB = new PointF(1, 0);
            var pointArrayA = new PointF[] { pointA, pointB };
            var pointArrayB = new PointF[] { pointB, pointA };
            Polygon target = new Polygon() { Vertices = pointArrayA };
            Polygon other = new Polygon() { Vertices = pointArrayB };
            bool expected = true;
            var actual = target.Equals(other);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for EqualsPolygon
        ///</summary>
        [TestMethod()]
        public void EqualsPolygonTest5()
        {
            var point = new PointF(0, 0);
            var pointArray = new PointF[] { point };
            Polygon target = new Polygon();
            Polygon other = new Polygon() { Vertices = pointArray };
            bool expected = true;
            var actual = target.Equals(other);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for EqualsPolygon
        ///</summary>
        [TestMethod()]
        public void EqualsPolygonTest6()
        {
            var pointA = new PointF(0, 0);
            var pointB = new PointF(1, 0);
            var pointArrayA = new PointF[] { pointA, pointB };
            Polygon target = new Polygon() { Vertices = pointArrayA };
            Polygon other = new Polygon();
            bool expected = true;
            var actual = target.Equals(other);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for EqualsPolygon
        ///</summary>
        [TestMethod()]
        public void EqualsPolygonTest7()
        {
            var pointA = new PointF(0, 0);
            var pointB = new PointF(1, 0);
            var pointArrayA = new PointF[] { pointA, pointB };
            Polygon target = new Polygon() { Vertices = pointArrayA };
            Polygon other = null;
            bool expected = true;
            var actual = target.Equals(other);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for EqualsPolygon
        ///</summary>
        [TestMethod()]
        public void EqualsPolygonTest8()
        {
            var pointA = new PointF(0, 0);
            var pointB = new PointF(1, 0);
            var pointC = new PointF(1, 1);
            var pointArrayA = new PointF[] { pointA, pointB, pointC };
            var pointArrayB = new PointF[] { pointC, pointA, pointB };
            Polygon target = new Polygon() { Vertices = pointArrayA };
            Polygon other = new Polygon() { Vertices = pointArrayB };
            bool expected = true;
            var actual = target.Equals(other);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for EqualsPolygon
        ///</summary>
        [TestMethod()]
        public void EqualsPolygonTest9()
        {
            var pointA = new PointF(0, 0);
            var pointB = new PointF(1, 0);
            var pointC = new PointF(1, 1);
            var pointArrayA = new PointF[] { pointA, pointB, pointC };
            var pointArrayB = new PointF[] { pointB, pointA, pointC };
            Polygon target = new Polygon() { Vertices = pointArrayA };
            Polygon other = new Polygon() { Vertices = pointArrayB };
            bool expected = true;
            var actual = target.Equals(other);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for EqualsPolygon
        ///</summary>
        [TestMethod()]
        public void EqualsPolygonTest10()
        {
            var pointA = new PointF(0, 0);
            var pointB = new PointF(1, 0);
            var pointC = new PointF(1, 1);
            var pointD = new PointF(0, 1);
            var pointArrayA = new PointF[] { pointA, pointB, pointC, pointD };
            var pointArrayB = new PointF[] { pointB, pointA, pointC, pointD };
            Polygon target = new Polygon() { Vertices = pointArrayA };
            Polygon other = new Polygon() { Vertices = pointArrayB };
            bool expected = false;
            var actual = target.Equals(other);
            Assert.AreEqual(expected, actual);
        }
    }
}