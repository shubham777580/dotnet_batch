using laptopEcommerce.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace laptopEcommerce.Models
{
    public class Laptop_specs
    {
        //intializing variables
        [Key]
        public int Id { get; set; }

        public string Laptop_Name { get; set; }

        public string Laptop_Description { get; set; }
        //ram and rom to be added here
        
        public double price { get; set; }

        public string ImageUrl { get; set; }

        public string Laptop_cpu { get; set; }

        public string Laptop_gpu { get; set; }

        public LaptopCategory LaptopCategory { get; set; }

        //Relationship

        public int Laptop_company_id { get; set; }
        [ForeignKey("Laptop_company_id")]

        public Laptop_company Laptop_company { get; set; }



    }
}
