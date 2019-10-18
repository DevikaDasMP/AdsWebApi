using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static OnlineAdsApp.Advertisement;

namespace OnlineAdsApp1API.Controllers
{
    public class AdvertisementViewModel
    {
        [Required]
        public int Id { get; set; }

        [Column(TypeName = "varchar")]
        [Required(ErrorMessage = "Title is Required")]
        public string Title { get; set; }
        [Column(TypeName = "varchar")]
        [Required(ErrorMessage = "Description is Required")]
        public string Description { get; set; }
        [EnumDataType(typeof(City))]
        public City Location { get; set; }
        [Required]

        public double MinSellingPrice { get; set; }
        [Required]

        public double MaxSellingPrice { get; set; }

        public DateTime CreationDate { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime ExpirationDate { get; set; }
    }
}