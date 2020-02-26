// <copyright file="UnitTest1.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CloudToolsUnitTesting
{
    using System; // System based imports are always first
    using System.Collections.Generic;
    using NUnit.Framework; // Nuget based imports are second

    /// <summary>
    /// Generic test class to show how to document and run with pipeline.
    /// </summary>
    public class UnitTest1
    {
        /// <summary>
        /// Set up process for unit testing.
        /// </summary>
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// Test case 1 to be run.
        /// </summary>
        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        /// <summary>
        /// Example case using LINQ to do our math.
        /// </summary>
        [Test]
        public void LinqAddition()
        {
            // It is usually bad practice to generate random test data.
            var r = new Random();
            int result = 0;
            List<int> randomNumbers = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                var placeholder = r.Next(0, 100);
                randomNumbers.Add(placeholder);
                result += placeholder;
            }

            // Braces should be followed with a blank line.
            // comments should also be followed by code
            Console.WriteLine($"{LinqMath.Addition(randomNumbers)}:{result}");
            Assert.IsTrue(LinqMath.Addition(randomNumbers) == result);

            // Good practice would dictate testing known results e.g
            int[] numbers = new int[2] { 0, 1 };
            Assert.IsTrue(LinqMath.Addition(numbers) == 1);
            numbers = new int[3] { 0, 1, 2 };
            Assert.IsTrue(LinqMath.Addition(numbers) == 3);

            /* Tests should test for known Passing and known Failing conditions
             * Due to using IEnumerator, The method may use arrays and lists
             * And other itterable collection of int */
        }
    }
}