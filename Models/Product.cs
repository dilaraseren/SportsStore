using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SportsStore.Models {

    public class Product {
        public long ProductID { get; set; }

        [Required(ErrorMessage = "Please enter a content")]
        public string İcerik { get; set; }

        [Required(ErrorMessage = "Please enter a categories")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Please enter a Ozet")]
        public string Ozet { get; set; }

        public string ResimYol { get; set; }
       

        
    }
}
