using System;
using System.Collections.Generic;

namespace _09_Portfolio
{
    internal class Portfolio
    {
        public List<IAsset> stocks;
        public IAsset classInstance;

        public Portfolio()
        {
            stocks = new List<IAsset>();
        }

        public Portfolio(List<IAsset> stocks)
        {
            this.stocks = stocks;
        }

        public double GetTotalValue()
        {
            double totalv = 0;

            foreach (IAsset stock in stocks)

            {
                totalv += stock.GetValue();
            }

            return totalv;

        }

        public void AddAsset(IAsset classInstance)
        {
            stocks.Add(classInstance);
        }

        
    }
}