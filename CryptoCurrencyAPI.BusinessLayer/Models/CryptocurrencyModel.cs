using CryptoCurrencyAPI.BusinessLayer.Utilities;
using System;
using System.ComponentModel.DataAnnotations;

namespace CryptoCurrencyAPI.BusinessLayer.Models
{
    public class CryptocurrencyModel
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Symbol { get; set; }

        [Required]
        public DateTime DatePublished { get; set; }

        [Required]
        [Range(1, 100000)]
        public int Rank { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [Required]
        public CryptocurrencyType Type { get; set; }
    }
}
