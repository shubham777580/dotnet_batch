using laptopEcommerce.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace laptopEcommerce.Controllers
{
    public class LaptopSpecsController : Controller
    {
        //Getting all data via AppDbcontext
        private readonly AppDbContext _context;

        //for using AppDbcontext data
        public LaptopSpecsController(AppDbContext context)
        {
            _context = context;
        }

        //getting laptop specs details from laptop_Specs
        public async Task<IActionResult> Index()
        {
            //used include so that we can get the name of laptop comapny from laptop table
            var allLaptopSpecs = await _context.laptop_Specs.Include(n => n.Laptop_company).ToListAsync();
            return View(allLaptopSpecs);
        }
    }
}

