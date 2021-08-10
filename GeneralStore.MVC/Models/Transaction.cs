using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GeneralStore.MVC.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionID { get; set; }

        [Required]
        public int CustomerId { get; set; }
        [Required]
        public string ProductSku { get; set; }
        [Required]
        public int ItemCount { get; set; }
        public DateTime DateOfTransaction { get; set; }

    }
}
