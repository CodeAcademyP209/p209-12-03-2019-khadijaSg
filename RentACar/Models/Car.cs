using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RentACar.Models
{
    public class Car
    {
        
        public int Id { get; set; }

        [StringLength(100)]
        [Required]
        public string CarBrand { get; set; }

        [StringLength(100)]
        [Required]
        public string CarModel { get; set; }

        [StringLength(100)]
        [Required]
        public string CarYear { get; set; }

        [StringLength(100)]
        [Required]
        public string EngineVolume { get; set; }

        [StringLength(100)]
        [Required]
        public string HorsePower { get; set; }

        [StringLength(100)]
        [Required]
        public string TypeOfEngine { get; set; }

        [StringLength(100)]
        [Required]
        public string MilageVolume { get; set; }

        [StringLength(300)]
        public string Image { get; set; }

        [NotMapped]
        public HttpPostedFileBase Photo { get; set; }

    }
}