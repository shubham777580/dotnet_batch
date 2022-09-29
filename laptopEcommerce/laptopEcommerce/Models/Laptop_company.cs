using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace laptopEcommerce.Models
{
    public class Laptop_company
    {
        //intializing variables
        [Key]
        public int Id { get; set; }

        //DisplayAttribute property added for index.html
        [Display(Name = "Logo")]
        public string Logo { get; set; }


        [Display(Name = "Name")]
        public string Name { get; set; }


        [Display(Name = "Description")]
        
        public string Description { get; set; }
        

        //Relationships
        public List<Laptop_specs> laptop_Specs { get; set; }


    }
}
