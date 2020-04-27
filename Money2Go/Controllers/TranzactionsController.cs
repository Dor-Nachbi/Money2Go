using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Money2Go.Data;
using Money2Go.Models;
using Money2Go.Roles;

namespace Money2Go.Controllers
{

    [Authorize]
    public class TranzactionsController : Controller
    {


        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public TranzactionsController(ApplicationDbContext context,UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }


        [Authorize(Roles = Permission.AdminUser)]
        // GET: Tranzactions
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tranzactiondb.ToListAsync());
        }

        //**********************************************************//
        //**********************************************************//
        //******************** Index Area Strat ********************//
        //**********************************************************//
        //**********************************************************//


        [HttpGet, ActionName("Project")]
        // GET: Tranzactions of specific project.
        public async Task<IActionResult> ByProject(int id)
        {

            //find the user id, for the user who send the request and check if is Admin
            var _userId = _userManager.GetUserId(User);
            bool _userRole = User.IsInRole(Permission.AdminUser);

            //Check if the project is Exist at the DB
            var ProjectValidation = await _context.Projectdb.FindAsync(id);


            //if the project dont exist at the DB throw Not Found.
            if (ProjectValidation == null)
                return NotFound();

            //if user isn't Admin Check if he is the Owner Of The project.
            if (!_userRole)
            {

                //if the user isn't Admin Or The Project Owner Throw Access Denied.
                if (ProjectValidation.UserId != _userId)
                    throw new AccessViolationException();
            }

            //if the user is admin or is Owner find all the project transactions.
            var transactions = await _context.Tranzactiondb.Where(i => i.project.ProjectId == id).ToListAsync();
            
            //return View with all relevant transaction+
            return View("Index",transactions);
        }


        [HttpGet, ActionName("User")]
        // GET: Tranzactions of specific *User*.
        public async Task<IActionResult> ByUser()
        {

            //find the user id
            var _userId = _userManager.GetUserId(User);

            //Check if the user is Exist at the DB
            var UserValudation = await _context.appUserdb.FindAsync(_userId);


            //if the User dont exist at the DB throw Not Found.
            if (UserValudation == null)
                return NotFound();

            //find all the user transaction to list
            var transactions = await _context.Tranzactiondb.Where(i => i.User.Id == _userId).ToListAsync();

            //return View with all relevant transaction+
            return View("Index",transactions);
        }

        //**********************************************************//
        //**********************************************************//
        //****************** Details Area Strat ********************//
        //**********************************************************//
        //**********************************************************//

        // GET: Tranzactions/Details/5
        //See transaction Details Only if is Admin ask Or the project Manager Ask Or The User Ask.
        public async Task<IActionResult> Details(int? id)
        {
            //check if id is Vaild Parameter.
            if (id == null)
            {
                return NotFound();
            }

            //find the user id, for the user who send the request and check if is Admin
            var _userId = _userManager.GetUserId(User);
            bool _userRole = User.IsInRole(Permission.AdminUser);

            //Check if the transaction is exist at the DB.
            var tranzaction = await _context.Tranzactiondb.Include(i=> i.User).Include(i=> i.project)
                .FirstOrDefaultAsync(m => m.TranzactionId == id);

            //if the transaction dosent exist throw NotFound.
            if (tranzaction == null)
            {
                return NotFound();
            }

            //check if the user is Admin
            if (!_userRole)
            {
                //if the user isn't Admin Check if the user is who made the Request Or The User is The Project Owner.
                if (_userId != tranzaction.User.Id && _userId != tranzaction.project.UserId)
                    throw new AccessViolationException();
            }

            //if all Ok return the transaction to the View.
            return View(tranzaction);
        } 

        [HttpPost]
        public async Task<IActionResult> BackProject(string amount, int projectId)
        {
            try
            {
                int IntAmount = int.Parse(amount);
                if (!ModelState.IsValid)
                {
                    return NotFound();
                }
                var _userId = _userManager.GetUserId(User);
                var userValidation = await _context.appUserdb.FindAsync(_userId);
                if (userValidation == null)
                    return NotFound();
                if (userValidation.Credit == null || userValidation.Credit == "")
                    return Json("Please update your credit card!");
                var project = await _context.Projectdb.FindAsync(projectId);
                if (project == null)
                    return NotFound();
                Tranzaction backer = new Tranzaction
                {
                    UserId = _userId,
                    User = userValidation,
                    ProjectId = projectId,
                    project = project,
                    DateT = DateTime.Now,
                    Amount = IntAmount
                };

                _context.Add(backer);
                await _context.SaveChangesAsync();
                var sum = CalculateCurrentSum(projectId);
                TempData["SumMoney"] = sum.Result;
                return Json("Thank you for " + amount + "$!!");
            }
            catch
            {
                return Json("Wrong amount!");
            }
        }
        public async Task<int> CalculateCurrentSum(int? projectId)
        {
            var project = await _context.Projectdb.Include(t => t.tranzaction)
                .FirstOrDefaultAsync(m => m.ProjectId == projectId);
            var backers = project.tranzaction.ToArray();
            int sum = 0;
            foreach (Tranzaction b in backers)
            {
                sum += b.Amount;
            }
            return sum;
        }

        
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //find the user id, for the user who send the request and check if is Admin
            var _userId = _userManager.GetUserId(User);
            bool _userRole = User.IsInRole(Permission.AdminUser);

            var tranzaction = await _context.Tranzactiondb
                .FirstOrDefaultAsync(m => m.TranzactionId == id);

            //if transaction isnt exist -> throw not found.
            if (tranzaction == null)
            {
                return NotFound();
            }

            //if transaction is exsit check if the user is admin or is the owner of the transaction
            if (!_userRole)
            {
                //not admin. check if the usee is the owner of the transaction
                if (_userId != tranzaction.User.Id)
                    throw new AccessViolationException();
            }


            return View(tranzaction);
        }

        // POST: Tranzactions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            //if id isn't vaild
            if (id == 0)
                return NotFound();


            //find the user id, for the user who send the request and check if is Admin
            var _userId = _userManager.GetUserId(User);
            bool _userRole = User.IsInRole(Permission.AdminUser);
            //find the transaction
            var tranzaction = await _context.Tranzactiondb.FindAsync(id);

            //the transaction dosent exist at the Database.
            if (tranzaction == null)
                return NotFound();

            //if transaction is exsit check if the user is admin or is the owner of the transaction
            if (!_userRole)
            {
                //not admin. check if the usee is the owner of the transaction
                if (_userId != tranzaction.User.Id)
                    throw new AccessViolationException();
            }

            //All ok remove the transaction from Database.
            _context.Tranzactiondb.Remove(tranzaction);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TranzactionExists(int id)
        {
            return _context.Tranzactiondb.Any(e => e.TranzactionId == id);
        }
    }
}
