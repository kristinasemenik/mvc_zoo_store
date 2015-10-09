using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;


namespace MvcZooStore.Models
{
   //[Bind(Exclude = "PetID")]
    public class Pet
    {
        [ScaffoldColumn(false)]
        public int PetID { get; set; }

        [DisplayName("Kind")]
        public int KindID { get; set; }

       [DisplayName("Company")]
        public int CompanyID { get; set; }

       [Required(ErrorMessage = "An Pet Title is required")]
       [StringLength(160)]
        public string Title { get; set; }

        public string Description { get; set; }

       [Required(ErrorMessage = "Price is required")]
       [Range(0.01, 100.00, ErrorMessage="Price must be between 0.01 and 100.00")]
        public decimal Price { get; set; }

       [DisplayName("Pet Art URL")]
       [StringLength(1024)]
        public string PetArtUrl { get; set; }

        public virtual Kind Kind { get; set; }
        public virtual Company Company { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}