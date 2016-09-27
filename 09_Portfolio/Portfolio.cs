using System;
using System.Collections.Generic;

namespace _09_Portfolio
{
    internal class Portfolio
    {
        private List<IAsset> stocks;

        public Portfolio(List<IAsset> stocks)
        {
            this.stocks = stocks;
        }

        public Portfolio()
        {
            stocks = new List<IAsset>();
        }

        internal double GetTotalValue()
        {
            double result = 0;
            foreach (var Asset in stocks)
            {
                result += Asset.GetValue();
            }
            return result; 
        }

        internal void AddAsset(IAsset asset)
        {
            stocks.Add(asset);
        }

    }
}