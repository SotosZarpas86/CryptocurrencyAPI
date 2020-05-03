using CryptoCurrencyAPI.BusinessLayer.Utilities;
using System;
using System.ComponentModel.DataAnnotations;

namespace CryptoCurrencyAPI.BusinessLayer.Models
{
    public class CryptocurrencyModel
    {
        /// <summary>
        /// Unique Identifier
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Name of the cryptocurrency (e.g. Bitcoin)
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Symbol of the cryptocurrency (e.g. BTC)
        /// </summary>
        [Required]
        public string Symbol { get; set; }

        /// <summary>
        /// The date the cryptocurrency was published
        /// </summary>
        [Required]
        public DateTime DatePublished { get; set; }

        /// <summary>
        /// Rank of the cryptocurrency
        /// </summary>
        [Required]
        [Range(1, 100000)]
        public int Rank { get; set; }

        /// <summary>
        /// Denotes whether the cryptocurrecy is currently active
        /// </summary>
        [Required]
        public bool IsActive { get; set; }

        /// <summary>
        /// Type of the cryptocurrency (either coin or token)
        /// </summary>
        [Required]
        public CryptocurrencyType Type { get; set; }
    }
}
