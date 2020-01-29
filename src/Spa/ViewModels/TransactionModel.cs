namespace Spa.ViewModels
{
    using System;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Transaction.
    /// </summary>
    public sealed class TransactionModel
    {
        public TransactionModel(decimal amount, string description, DateTime transactionDate)
        {
            Amount = amount;
            Description = description;
            TransactionDate = transactionDate;
        }

        /// <summary>
        /// Gets Amount.
        /// </summary>
        [Required]
        public decimal Amount { get; }

        /// <summary>
        /// Gets Description.
        /// </summary>
        [Required]
        public string Description { get; }

        /// <summary>
        /// Gets Transaction Date.
        /// </summary>
        [Required]
        public DateTime TransactionDate { get; }
    }
}
