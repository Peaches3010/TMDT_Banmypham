using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TMDT_Banmypham.Models.DB;

namespace TMDT_Banmypham.Controllers
{
    public class SanphamsController : Controller
    {
        private readonly MYPHAMContext _context;

        public SanphamsController(MYPHAMContext context)
        {
            _context = context;
        }
        
        // GET: Sanphams
        public async Task<IActionResult> Index()
        {
            var mYPHAMContext = _context.Sanpham.Include(s => s.MaLspNavigation);
            return View(await mYPHAMContext.ToListAsync());
        }

        
        
    }
}
