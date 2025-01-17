﻿namespace Shop.Web.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Models;

    public class Product : IEntity
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "{0} field must be less than {1} characters.")]
        [Required]
        public string Name { get; set; }

        public string ImageFullPath
        {
            get
            {
                if (string.IsNullOrEmpty(this.ImageUrl))
                {
                    return null;
                }

                return $"https://shopweb20190219113137.azurewebsites.net{this.ImageUrl.Substring(1)}";
            }
        }

        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }

        [Display(Name = "Image")]
        public string ImageUrl { get; set; }

        [Display(Name = "Last Purchase")]
        public DateTime? LastPurchase { get; set; }

        [Display(Name = "Last Sale")]
        public DateTime? LastSale { get; set; }

        [Display(Name = "Is Availabe?")]
        public bool IsAvailabe { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public double Stock { get; set; }

        public User User { get; set; }

    }
}
