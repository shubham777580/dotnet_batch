using laptopEcommerce.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace laptopEcommerce.Controllers
{
    public class LaptopCompanyController : Controller
    {
        //Getting all data via AppDbcontext
        private readonly AppDbContext _context;

        //for using AppDbcontext data
        public LaptopCompanyController(AppDbContext context)
        {
            _context = context;
        }

        //getting laptop campany details from laptop_company_variable
        public async Task<IActionResult> Index()
        {
            var allLaptopCompany = await _context.laptop_company_variable.ToListAsync();
            return View(allLaptopCompany);
        }
    }
}
