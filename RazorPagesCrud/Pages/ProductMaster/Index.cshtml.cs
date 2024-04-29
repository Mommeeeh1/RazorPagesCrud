using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesCrud.DAL;
using RazorPagesCrud.Models;

namespace RazorPagesCrud.Pages.ProductMaster
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesCrud.DAL.AppDbContext _context;

        public IndexModel(RazorPagesCrud.DAL.AppDbContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Product = await _context.Products.ToListAsync();
        }
    }
}
