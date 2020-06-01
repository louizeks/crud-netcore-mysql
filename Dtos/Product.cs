using System;
using System.ComponentModel.DataAnnotations;

namespace senac_api.Dtos
{
    public class Product
    {
        public Guid Id { get; set; }

        [Required]
        public string Sku { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int Quantity { get; set; }

        public string Url { get; set; }
    }
}
