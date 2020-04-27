using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Money2Go.Data;
using Money2Go.Models;
using Money2Go.Roles;
using unirest_net.http;
using unirest_net.request;

namespace Money2Go.Controllers
{
    
    public class HomeController : Controller
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var arrayProjects = await _context.Projectdb.Include(u => u.user).ToListAsync();
            //var arrayProjects = _context.Projectdb.ToList();
            TempData["list"] = getLast3();


            return View(arrayProjects);
        }

        [Authorize]
        public IActionResult Profile()
        {
            var userId =_userManager.GetUserId(User);
            var userDetails = _context.appUserdb.Include(p => p.projects).FirstOrDefault(i => i.Id == userId);
            if (User.IsInRole(Permission.AdminUser))
            {
                TempData["users"] = getUsers();
                TempData["projects"] = getProjects();
            }
            return View(userDetails);
        }


        [Authorize(Roles = Permission.AdminUser)]
        public List<ApplicationUser> getUsers()
        {
            var users = _context.appUserdb.ToList();
            return users;
        }
        [Authorize(Roles = Permission.AdminUser)]
        public List<Project> getProjects()
        {
            var projects = _context.Projectdb.ToList();
            return projects;
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> UpdateDetails([Bind("FirstName,LastName,PhoneNumber,Email,Credit")]ApplicationUser user, string password, bool updatePassword)
        {
            var _userId = _userManager.GetUserId(User);
            
            if(ModelState.IsValid)
            {


                ApplicationUser theUser = _context.appUserdb.Find(_userId);

                theUser.FirstName = user.FirstName;
                theUser.LastName = user.LastName;
                theUser.PhoneNumber = user.PhoneNumber;
                theUser.Credit = user.Credit;

                if (updatePassword)
                {
                    var newPassword = _userManager.PasswordHasher.HashPassword(theUser, password);
                    theUser.PasswordHash = newPassword;


                }
                _context.Update(theUser);
                await _context.SaveChangesAsync();
                return Json("OK!");
            }

            return Json("ERROR!");  

              


        }
        public async Task<List<Project>> getLast3()
        {
            var last3 = await _context.Projectdb.OrderByDescending(d => d.DateProject).Take(3).ToListAsync();
            return last3;
        }



        public async Task<IActionResult> Piechart()
        {
              ViewBag.sunday = await _context.Commentdb
                .Where(a => a.dateSubmit.DayOfWeek == DayOfWeek.Sunday)
                .GroupBy(a => a.dateSubmit)
                .Select(b => b.Count())
                .ToListAsync();

            ViewBag.monday = await _context.Commentdb
               .Where(a => a.dateSubmit.DayOfWeek == DayOfWeek.Monday)
               .GroupBy(a => a.dateSubmit)
               .Select(b => b.Count())
               .ToListAsync();

            ViewBag.tuesday = await _context.Commentdb
               .Where(a => a.dateSubmit.DayOfWeek == DayOfWeek.Tuesday)
               .GroupBy(a => a.dateSubmit)
               .Select(b => b.Count())
               .ToListAsync();

            ViewBag.wednesday = await _context.Commentdb
               .Where(a => a.dateSubmit.DayOfWeek == DayOfWeek.Wednesday)
               .GroupBy(a => a.dateSubmit)
               .Select(b => b.Count())
               .ToListAsync();

            ViewBag.thursday = await _context.Commentdb
               .Where(a => a.dateSubmit.DayOfWeek == DayOfWeek.Thursday)
               .GroupBy(a => a.dateSubmit)
               .Select(b => b.Count())
               .ToListAsync();

            ViewBag.friday = await _context.Commentdb
               .Where(a => a.dateSubmit.DayOfWeek == DayOfWeek.Friday)
               .GroupBy(a => a.dateSubmit)
               .Select(b => b.Count())
               .ToListAsync();

            ViewBag.saturday = await _context.Commentdb
               .Where(a => a.dateSubmit.DayOfWeek == DayOfWeek.Saturday)
               .GroupBy(a => a.dateSubmit)
               .Select(b => b.Count())
               .ToListAsync();


            var data = _context.Tranzactiondb.ToList().Select(a => new { a.Amount, a.DateT });

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
