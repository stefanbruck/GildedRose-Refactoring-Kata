// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApprovalTest.cs" company="">
//   
// </copyright>
// <summary>
//   The approval test.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GildedRoseTests
{
    using System;
    using System.IO;
    using System.Text;

    using GildedRose;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The approval test.
    /// </summary>
    [TestClass]
    public class ApprovalTest
    {
        #region Public Methods and Operators

        /// <summary>
        /// The thirty days.
        /// </summary>
        [TestMethod]
        public void ThirtyDays()
        {
            var fakeoutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeoutput));
            Console.SetIn(new StringReader("a\n"));

            Program.Main(new string[] { });
            string output = fakeoutput.ToString();

            // Approvals.Verify(output);
        }

        #endregion
    }
}