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
    
    public class ProjectsController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public ProjectsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }

        public async Task<List<Project>> suggestion(string category)
        {
            //var projectsSameCategory = await _context.Projectdb
            //    .Include(c=>c.comments)
            //    .Where(c=>c.Category==category).ToListAsync();
            var comments = await _context.Commentdb
                .Include(p=>p.project)
                .Where(c => c.project.Category == category)
                .Where(c => c.RudeComment == false)
                .GroupBy(p => p.ProjectId)
                .OrderByDescending(c=>c.Count())
                .Take(3)
                .ToListAsync();
            List<Project> list = new List<Project>();
            for (int i = 0; i < comments.Count(); i++)
            {
                list.Add(_context.Projectdb.Find(comments[i].ToArray().First().ProjectId));
            }
            
            return list;
        }
        // GET: Projects
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var _userId = _userManager.GetUserId(User);
            bool _userRole = User.IsInRole(Permission.AdminUser);

            if (_userRole)
            {
                var applicationDbContext = _context.Projectdb.Include(p => p.user);
                return View(await applicationDbContext.ToListAsync());
            }
            else
            {
                var applicationDbContext = _context.Projectdb.Where(i => i.UserId == _userId).Include(p => p.user);
                return View(await applicationDbContext.ToListAsync());
            }

        }

        // GET: Projects/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            Project project = _context.Projectdb.Find(id);

            if (project != null)
            {
                var projectWithCommentsWithUser = _context.Projectdb
                    .Where(p => p.ProjectId == id)
                    .Include(u => u.user)
                    .Include(c => c.comments)
                    .ThenInclude(u => u.owner).FirstOrDefaultAsync();
                var sum = CalculateCurrentSum(id);
                TempData["SumMoney"] = sum.Result;
                TempData["Suggestion"] = suggestion(projectWithCommentsWithUser.Result.Category).Result.ToList();
                return View(await projectWithCommentsWithUser);
            }


            return RedirectToAction("Index", "Home");


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
        // GET: Projects/Create
        [Authorize]
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.appUserdb, "Id", "Id");
            return View();
        }

        // POST: Projects/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Create([Bind("ProjectId,UserId,ProjectName,Description,pic_path,vid_path,goal,Category")] Project project)
        {
            if (ModelState.IsValid)
            {
                var _userId = _userManager.GetUserId(User);
                project.UserId = _userId;
                project.DateProject = DateTime.Now.AddDays(60);
                _context.Add(project);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.appUserdb, "Id", "Id", project.UserId);
            return View(project);
        }

        [HttpPost]
        public async Task<IActionResult> Search(DateTime date, int amount, string category)
        {
            bool withDate = true;
            bool withAmount = true;
            bool withCategory = true;

            if (date.ToString("yyyy-MM-dd") != "0001-01-01")
                TempData["date"] = date.ToString("yyyy-MM-dd");
            else
                withDate = false;
            if (amount > 0)
                TempData["amount"] = amount;
            else
                withAmount = false;
            if (category != null && category != "Select Category")
                TempData["category"] = category;
            else
                withCategory = false;

            var projects = await _context.Projectdb
               .Where(a => a.Category == category || !withCategory)
               .Where(d => d.DateProject >= date || !withDate)
               .Where(a => a.goal <= amount || !withAmount).ToListAsync();




            return View("../Home/Index", projects);
        }

        // GET: Projects/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var _userId = _userManager.GetUserId(User);
            bool _userRole = User.IsInRole(Permission.AdminUser);

            var project = await _context.Projectdb.FindAsync(id);

            if (project == null)
                return RedirectToAction(nameof(Index));

            if (!_userRole)
            {
                if (!(project.UserId == _userId))
                {
                    return RedirectToAction(nameof(Index));
                }
            }

            if (project == null)
            {
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.appUserdb, "Id", "Id", project.UserId);
            return View(project);
        }

        // POST: Projects/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit(int id, [Bind("ProjectId,UserId,ProjectName,Description,pic_path,vid_path,goal,Category")] Project project)
        {
            if (id != project.ProjectId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(project);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectExists(project.ProjectId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.appUserdb, "Id", "Id", project.UserId);
            return View(project);
        }

        // GET: Projects/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {


            if (id == null)
            {
                return NotFound();
            }

            var project = await _context.Projectdb
               .Include(p => p.user)
               .FirstOrDefaultAsync(m => m.ProjectId == id);

            if (project == null)
            {
                return NotFound();
            }

            var myId = _userManager.GetUserId(User);

            var ownerId = (_context.Projectdb.FindAsync(id)).Result.UserId;


            if (myId != ownerId)
                return RedirectToAction(nameof(Index));


            return View(project);
        }

        // POST: Projects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var project = await _context.Projectdb.FindAsync(id);
            _context.Projectdb.Remove(project);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjectExists(int id)
        {
            return _context.Projectdb.Any(e => e.ProjectId == id);
        }
    }
}
