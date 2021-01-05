using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialMedia.Data;
using SocialMedia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Controllers
{

   
    public class PrivateMessageController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PrivateMessageController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: PrivateMessageController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PrivateMessageController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        [HttpGet]
        //public IActionResult MakeGroup()
        //{

        //    PrivateGroup privateGroup = new PrivateGroup();

        //    return View(privateGroup);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> MakeGroup(PrivateGroup privateGroup)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        //_context.Add(address);


        //        var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
        //        var movieWatcher = _context.MovieWatchers.Where(m => m.IdentityUserId == userId).First();
        //        Random rand = new Random();
        //        int value = rand.Next(100000, 999999);
        //        privateGroup.Pin = value;
        //        //_context.PrivateGroups.Add(privateGroup);
        //        //_context.SaveChanges();
        //        movieWatcher.MyPrivateGroup = privateGroup;
        //        _context.MovieWatchers.Update(movieWatcher);
        //        await _context.SaveChangesAsync();


        //        return RedirectToAction("GetMovies", "PrivateGroups");
        //    }
        //    return View(privateGroup);
        //}
        // GET: PrivateMessageController/Create
        public ActionResult Create()
        {
            PrivateMessage privateMessage = new PrivateMessage();
            return View(privateMessage);
        }

        // POST: PrivateMessageController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PrivateMessage privateMessage)
        {
            _context.Add(privateMessage);
            
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PrivateMessageController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PrivateMessageController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PrivateMessageController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PrivateMessageController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
