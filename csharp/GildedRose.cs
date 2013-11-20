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
        private readonly IList<Item> Items;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="GildedRose"/> class.
        /// </summary>
        /// <param name="Items">
        /// The items.
        /// </param>
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The update quality.
        /// </summary>
        public void UpdateQuality()
        {
            for (int i = 0; i < this.Items.Count; i++)
            {
                if (this.Items[i].Name != "Aged Brie"
                    && this.Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (this.Items[i].Quality > 0)
                    {
                        if (this.Items[i].Name != "Sulfuras, Hand of Ragnaros")
                        {
                            this.Items[i].Quality = this.Items[i].Quality - 1;
                        }
                    }
                }
                else
                {
                    if (this.Items[i].Quality < 50)
                    {
                        this.Items[i].Quality = this.Items[i].Quality + 1;

                        if (this.Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (this.Items[i].SellIn < 11)
                            {
                                if (this.Items[i].Quality < 50)
                                {
                                    this.Items[i].Quality = this.Items[i].Quality + 1;
                                }
                            }

                            if (this.Items[i].SellIn < 6)
                            {
                                if (this.Items[i].Quality < 50)
                                {
                                    this.Items[i].Quality = this.Items[i].Quality + 1;
                                }
                            }
                        }
                    }
                }

                if (this.Items[i].Name != "Sulfuras, Hand of Ragnaros")
                {
                    this.Items[i].SellIn = this.Items[i].SellIn - 1;
                }

                if (this.Items[i].SellIn < 0)
                {
                    if (this.Items[i].Name != "Aged Brie")
                    {
                        if (this.Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (this.Items[i].Quality > 0)
                            {
                                if (this.Items[i].Name != "Sulfuras, Hand of Ragnaros")
                                {
                                    this.Items[i].Quality = this.Items[i].Quality - 1;
                                }
                            }
                        }
                        else
                        {
                            this.Items[i].Quality = this.Items[i].Quality - this.Items[i].Quality;
                        }
                    }
                    else
                    {
                        if (this.Items[i].Quality < 50)
                        {
                            this.Items[i].Quality = this.Items[i].Quality + 1;
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