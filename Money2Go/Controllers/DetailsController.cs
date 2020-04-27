using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Money2Go.Data;
using Money2Go.Models;

namespace Money2Go.Controllers
{
    public class DetailsController : Controller
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public DetailsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }


        [HttpGet]
        public async Task<IActionResult> Viewproject(int ?id)
        {
           Project project = _context.Projectdb.Find(id);

            if(project != null)
            {

               // var commentWithUser = _context.Comm entdb.Include(u => u.owner).FirstOrDefault();
                var projectWithCommentsWithUser = _context.Projectdb.Where(p=> p.ProjectId == id).Include(u => u.user).Include(c => c.comments).ThenInclude(u => u.owner).FirstOrDefaultAsync();

                return View(await projectWithCommentsWithUser);
            }
               

            return RedirectToAction("Index","Home");
        }


    }
}