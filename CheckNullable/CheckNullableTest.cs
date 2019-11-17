// <copyright file="CheckNullableTest.cs" company="LearningCompany">
// Copyright (c) Company. All rights reserved.
// </copyright>
namespace CheckNullable
{
    using NUnit.Framework;

    /// <summary>
    /// The class testing CheckNullable class.
    /// </summary>
    public class CheckNullableTest
    {
        /// <summary>
        /// Method for testing CheckIsNull.
        /// </summary>
        [Test]
        public void CheckIsNullTest()
        {
            string name = null;
            int? i = null;
            Assert.AreEqual(CheckNullable.CheckIsNull("Kathy"), false);
            Assert.AreEqual(CheckNullable.CheckIsNull(name), true);
            Assert.AreEqual(CheckNullable.CheckIsNull(i), true);
        }
    }
}