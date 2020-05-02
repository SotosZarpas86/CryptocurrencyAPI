using CryptoCurrencyAPI.DataLayer.Utilities;
using System;

namespace CryptoCurrencyAPI.DataLayer.Entities
{
    public class Cryptocurrency
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Symbol { get; set; }

        public DateTime DatePublished { get; set; }

        public int Rank { get; set; }

        public bool IsActive { get; set; }

        public CryptocurrencyType Type { get; set; }
    }
}
