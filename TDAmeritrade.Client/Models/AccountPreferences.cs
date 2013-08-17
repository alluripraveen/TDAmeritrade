﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AccountPreferences.cs" company="KriaSoft LLC">
//   Copyright © 2013 Konstantin Tarkus, KriaSoft LLC. See LICENSE.txt
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace TDAmeritrade.Client.Models
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents the preference options for the given account.
    /// </summary>
    public class AccountPreferences
    {
        /// <summary>
        /// Gets a value indicating whether the user has selected Express Trading option on the web site (does not affect API).
        /// </summary>
        public bool ExpressTrading { get; internal set; }

        /// <summary>
        /// Gets a value indicating whether the account is enabled for direct routing options orders.
        /// </summary>
        public bool OptionDirectRouting { get; internal set; }

        /// <summary>
        /// Gets a value indicating whether the account is enabled for direct routing stock orders.
        /// </summary>
        public bool StockDirectRouting { get; internal set; }

        /// <summary>
        /// Action used to pre-populate the stock order ticket
        /// </summary>
        public string DefaultStockAction { get; internal set; }

        /// <summary>
        /// Type of order to pre-populate the stock order ticket
        /// </summary>
        public string DefaultStockOrderType { get; internal set; }

        /// <summary>
        /// Number of shares to pre-populate into the stock order ticket
        /// </summary>
        public string DefaultStockQuantity { get; internal set; }

        /// <summary>
        /// Expiration used to pre-populate the stock order ticket
        /// </summary>
        public string DefaultStockExpiration { get; internal set; }

        /// <summary>
        /// Instructions used to pre-populate the stock order ticket
        /// </summary>
        public string DefaultStockSpecialInstructions { get; internal set; }

        /// <summary>
        /// Routing destination used to pre-populate the stock order ticket
        /// </summary>
        public string DefaultStockRouting { get; internal set; }

        /// <summary>
        /// Display size used with INET direct routing
        /// </summary>
        public string DefaultStockDisplaySize { get; internal set; }

        /// <summary>
        /// Tax lot methodology used when selling shares
        /// </summary>
        public string StockTaxLotMethod { get; internal set; }

        /// <summary>
        /// Tax lot methodology used when selling options
        /// </summary>
        public string OptionTaxLotMethod { get; internal set; }

        /// <summary>
        /// Tax lot methodology used when selling mutual funds
        /// </summary>
        public string MutualFundTaxLotMethod { get; internal set; }

        /// <summary>
        /// Advanced tool launched when logging into the Ameritrade website.
        /// </summary>
        public string DefaultAdvancedToolLaunch { get; internal set; }
    }
}
