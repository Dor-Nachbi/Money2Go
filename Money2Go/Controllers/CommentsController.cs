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
using Money2GoML.Model;

namespace Money2Go.Controllers
{
    public class CommentsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public CommentsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }

        //**********************************************************//
        //**********************************************************//
        //******************** Index Area Strat ********************//
        //**********************************************************//
        //**********************************************************//

        [Authorize(Roles = Permission.AdminUser)]
        // GET: All comments that have at the website -> Only Admin Can See.
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Commentdb.Include(c => c.owner);
            return View(await applicationDbContext.ToListAsync());
        }

        [HttpGet,ActionName("User")]
        [Authorize]
        // GET: All comments By Specipic User -> Only the specific user can see or Admin
        public async Task<IActionResult> ByUse(string id="Null")
        {
            //find user id, check if the user is Admin
            var _userId = _userManager.GetUserId(User);
            bool _userRole = User.IsInRole(Permission.AdminUser);


            //if the request made for the log-in user and not for other user
            if (id == "Null" || id == _userId)
            {
                //Check that the user Exist.
                var UserValidation = await _context.appUserdb.FindAsync(_userId);

                //if the user dosent exist at the Database => Throw not found.
                if (UserValidation == null)
                    return NotFound();

                //The User is not admin Display only the user id Comments.
                return View("Index",await _context.Commentdb.Where(i => i.OwnerId == _userId).ToListAsync());

            }
            else
            {

                //if the request made for another user
                //Check that the user Exist.
                var UserValidation = await _context.appUserdb.FindAsync(id);

                //if the user dosent exist at the Database => Throw not found.
                if (UserValidation == null)
                    return NotFound();

                if (!_userRole)
                {
                    //The User is not admin => Access Denied
                    throw new AccessViolationException();
                }
                else
                {
                    //The user is Admin Display Only The User ID comments.
                    return View("Index",await _context.Commentdb.Where(i => i.OwnerId == id).ToListAsync());
                }
            }

        }


        //**********************************************************//
        //**********************************************************//
        //******************** Detail Area Strat *******************//
        //**********************************************************//
        //**********************************************************//

        [HttpGet, ActionName("Project")]
        // GET: All comments By Specipic Project -> All Can See Or if Id == null that only Admin Can See.
        public async Task<IActionResult> ByProject(int? id)
        {
            if (id == null)
            {
                //find user id, check if the user is Admin
                bool _userRole = User.IsInRole(Permission.AdminUser);

                if (_userRole)
                {
                    //Get All Comments Ever.
                    return View("Index",await _context.Commentdb.ToListAsync());
                }
            }
            var ProjectValidation = await _context.Projectdb.FindAsync(id);

            //If The Project Dosent exist at the Database => throw Not Found.
            if (ProjectValidation == null)
                return NotFound();

            return View("Index",await _context.Commentdb.Where(i => i.ProjectId == id).ToListAsync());

        }


        //Specific Comments details => all can see.
        // GET: Comments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comment = await _context.Commentdb
                .Include(c => c.owner)
                .FirstOrDefaultAsync(m => m.commentId == id);
            if (comment == null)
            {
                return NotFound();
            }

            return View(comment);
        }

        //**********************************************************//
        //**********************************************************//
        //******************** Create Area Strat *******************//
        //**********************************************************//
        //**********************************************************//



        // GET: Comments/Create -> Only login user can create comment.
        //Create Comment For Specific Project
        [Authorize] 
        public async Task<IActionResult> Create(int id)
        {
            var ProjectValidation = await _context.Projectdb.FindAsync(id);

            //The Project dosent exist at the database.
            if (ProjectValidation == null)
                return NotFound();

            Comment newComment = new Comment
            {
                project = ProjectValidation,
                ProjectId = id
            };


            ViewData["OwnerId"] = new SelectList(_context.appUserdb, "Id", "Id");
            return View(newComment);
        }

    

        // POST: Comments/Create
        // only log-in users can create comment
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("commentId,OwnerId,ProjectId,theComment,dateSubmit")] Comment comment)
        {
            //Find User Id
           
            var _userId = _userManager.GetUserId(User);

            var ProjectValidation = await _context.Projectdb.FindAsync(comment.ProjectId);
            var UserValidation = await _context.appUserdb.FindAsync(_userId);


            //if user or project dosent exist at the database
            if (UserValidation == null || ProjectValidation == null)
                return NotFound();

            comment.project = await _context.Projectdb.FindAsync(comment.ProjectId);
            comment.owner = await _context.appUserdb.FindAsync(_userId);
            comment.OwnerId = _userId;
            comment.dateSubmit = DateTime.Now;

            var input = new ModelInput();
            input.Comment = comment.theComment;
            ModelOutput result = ConsumeModel.Predict(input);
            if (result.Prediction)
                comment.RudeComment = true;
            else
                comment.RudeComment = false;


            //If The Comments State Is Not Vaild.
            if (!ModelState.IsValid)
            {

                return View(comment);
            }

            Project project = comment.project;
            project.comments.Add(comment);

            _context.Add(comment);
            //_context.Add(project);
            await _context.SaveChangesAsync();
            return RedirectToAction("viewproject", "Details",new {id = project.ProjectId});
            
        }
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AjaxComment(int ProjectId, string theComment)
        {
            //Find User Id
            var _userId = _userManager.GetUserId(User);
            var ProjectValidation = await _context.Projectdb.FindAsync(ProjectId);
            var UserValidation = await _context.appUserdb.FindAsync(_userId);
            //if user or project dosent exist at the database
            if (UserValidation == null || ProjectValidation == null)
                return NotFound();
            Comment comment = new Comment
            {
                project = await _context.Projectdb.FindAsync(ProjectId),
                owner = await _context.appUserdb.FindAsync(_userId),
                OwnerId = _userId,
                theComment = theComment,
                dateSubmit = DateTime.Now
            };
            var input = new ModelInput();
            input.Comment = theComment;
            ModelOutput result = ConsumeModel.Predict(input);
            if (result.Prediction)
                comment.RudeComment = true;
            else
                comment.RudeComment = false;
            //If The Comments State Is Not Vaild.
            if (!ModelState.IsValid)
            {

                return View(comment);
            }
            Project project = comment.project;
            project.comments.Add(comment);
            _context.Add(comment);
            //_context.Add(project);
            await _context.SaveChangesAsync();
            return Json("OK!");
        }
        //**********************************************************//
        //**********************************************************//
        //******************** Edit Area Strat *********************//
        //**********************************************************//
        //**********************************************************//

        // GET: Comments/Edit/5
        //Comment Can Edit only description.
        [Authorize] //Only Log In User Can Edit Comment.
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var CommentValidation = await _context.Commentdb.FindAsync(id);

            //the comment dosent exist at the database.
            if (CommentValidation == null)
                return NotFound();

            //find user id, check if the user is Admin
            var _userId = _userManager.GetUserId(User);
            bool _userRole = User.IsInRole(Permission.AdminUser);



            //If User dosent Admin => check if he is the Onwer of the Comment.
            if (!_userRole)
            {
                //user id not the owner of the Comment.
                if (_userId != CommentValidation.OwnerId)
                    throw new AccessViolationException();
            }


            return View(CommentValidation);
        }

        // POST: Comments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("commentId,OwnerId,ProjectId,theComment,dateSubmit")] Comment comment)
        {
            if (id != comment.commentId)
            {
                throw new AccessViolationException();
            }


            var CommentValidation = await _context.Commentdb.FindAsync(id);

            //if the Comment dosent exist at the Database.
            if (CommentValidation == null)
                return NotFound();

            if (!ModelState.IsValid)
                return View(comment);

            //find user id, check if the user is Admin
            var _userId = _userManager.GetUserId(User);
            bool _userRole = User.IsInRole(Permission.AdminUser);

            if (!_userRole)
            {
                //if the user is not admin =>check if the user is the owner
                if (_userId != CommentValidation.OwnerId)
                    throw new AccessViolationException();
            }

            CommentValidation.theComment = comment.theComment;
            _context.Update(CommentValidation);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(User));
        }

        //**********************************************************//
        //**********************************************************//
        //******************** Delete Area Strat *******************//
        //**********************************************************//
        //**********************************************************//
    

        
        // GET: Comments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comment = await _context.Commentdb
                .Include(c => c.owner)
                .FirstOrDefaultAsync(m => m.commentId == id);
            if (comment == null)
            {
                return NotFound();
            }

            return View(comment);
        }
        

        // POST: Comments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var CommentValidation = await _context.Commentdb.FindAsync(id);

            //if the Comment dosent exist at the Database.
            if (CommentValidation == null)
                return NotFound();

            //find user id, check if the user is Admin
            var _userId = _userManager.GetUserId(User);
            bool _userRole = User.IsInRole(Permission.AdminUser);

            if (!_userRole)
            {
                //if the user is not admin =>check if the user is the owner
                if (_userId != CommentValidation.OwnerId)
                    throw new AccessViolationException();
            }

            _context.Commentdb.Remove(CommentValidation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(User));
        }

        private bool CommentExists(int id)
        {
            return _context.Commentdb.Any(e => e.commentId == id);
        }
    }
}
