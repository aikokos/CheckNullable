// <copyright file="CheckNullable.cs" company="LearningCompany">
// Copyright (c) Company. All rights reserved.
// </copyright>
namespace CheckNullable
{
    /// <summary>
    /// The class implementing check whether parameter is null.
    /// </summary>
    public static class CheckNullable
    {
        /// <summary>
        /// Method for checking whether object is null.
        /// </summary>
        /// <param name="a">object for checking</param>
        /// <returns>Returns whether object is null or not</returns>
        public static bool CheckIsNull(object a)
        {
            if (a is null)
            {
                return true;
            }

            return false;
        }
    }
}
