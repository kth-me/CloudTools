using NUnit.Framework;

namespace CloudToolsUnitTesting
{
    /// <summary>
    /// Generic test class to show how to document and run with pipeline.
    /// </summary>
    public class Tests
    {
        /// <summary>
        /// Set up process for unit testing.
        /// </summary>
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// Test case 1 to be run
        /// </summary>
        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}