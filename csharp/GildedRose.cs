// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GildedRose.cs" company="">
//   
// </copyright>
// <summary>
//   The gilded rose.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GildedRose
{
    using System.Collections.Generic;

    /// <summary>
    /// The gilded rose.
    /// </summary>
    internal class GildedRose
    {
        #region Fields

        /// <summary>
        /// The items.
        /// </summary>
        private readonly IList<Item> items;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="GildedRose"/> class.
        /// </summary>
        /// <param name="items">
        /// The items.
        /// </param>
        public GildedRose(IList<Item> items)
        {
            this.items = items;
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The update quality.
        /// </summary>
        public void UpdateQuality()
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                if (this.items[i].Name != "Aged Brie"
                    && this.items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (this.items[i].Quality > 0)
                    {
                        if (this.items[i].Name != "Sulfuras, Hand of Ragnaros")
                        {
                            this.items[i].Quality = this.items[i].Quality - 1;
                        }
                    }
                }
                else
                {
                    if (this.items[i].Quality < 50)
                    {
                        this.items[i].Quality = this.items[i].Quality + 1;

                        if (this.items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (this.items[i].SellIn < 11)
                            {
                                if (this.items[i].Quality < 50)
                                {
                                    this.items[i].Quality = this.items[i].Quality + 1;
                                }
                            }

                            if (this.items[i].SellIn < 6)
                            {
                                if (this.items[i].Quality < 50)
                                {
                                    this.items[i].Quality = this.items[i].Quality + 1;
                                }
                            }
                        }
                    }
                }

                if (this.items[i].Name != "Sulfuras, Hand of Ragnaros")
                {
                    this.items[i].SellIn = this.items[i].SellIn - 1;
                }

                if (this.items[i].SellIn < 0)
                {
                    if (this.items[i].Name != "Aged Brie")
                    {
                        if (this.items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (this.items[i].Quality > 0)
                            {
                                if (this.items[i].Name != "Sulfuras, Hand of Ragnaros")
                                {
                                    this.items[i].Quality = this.items[i].Quality - 1;
                                }
                            }
                        }
                        else
                        {
                            this.items[i].Quality = this.items[i].Quality - this.items[i].Quality;
                        }
                    }
                    else
                    {
                        if (this.items[i].Quality < 50)
                        {
                            this.items[i].Quality = this.items[i].Quality + 1;
                        }
                    }
                }
            }
        }

        #endregion
    }

    /// <summary>
    /// The item.
    /// </summary>
    public class Item
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the quality.
        /// </summary>
        public int Quality { get; set; }

        /// <summary>
        /// Gets or sets the sell in.
        /// </summary>
        public int SellIn { get; set; }

        #endregion
    }
}