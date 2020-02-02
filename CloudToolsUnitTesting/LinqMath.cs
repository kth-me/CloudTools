// <copyright file="LinqMath.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CloudToolsUnitTesting
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// This is a Math class designed to fail at maths.
    /// Since it's operation on numbers, it does not need
    /// to be implemented but referenced as a static class.
    /// </summary>
    public static class LinqMath
    {
        /// <summary>
        /// Function is declared static as it's part of a static class
        /// Static classes can't have non-static methods.
        /// </summary>
        /// <param name="numbers">Array of numbers being parsed.</param>
        /// <returns>incorrect value.</returns>
        public static int Addition(IEnumerable<int> numbers)
        {
            var output = numbers.Sum();
            return output;
        }
    }
}