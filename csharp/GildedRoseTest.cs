// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GildedRoseTest.cs" company="">
//   
// </copyright>
// <summary>
//   The gilded rose test.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GildedRose
{
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The gilded rose test.
    /// </summary>
    [TestClass]
    public class GildedRoseTest
    {
        #region Public Methods and Operators

        /// <summary>
        /// The foo.
        /// </summary>
        [TestMethod]
        public void Foo()
        {
            IList<Item> items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            var app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual("fixme", items[0].Name);
        }

        #endregion
    }
}