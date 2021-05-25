using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TechBytes.ApplicationLogic.Models;
using TechBytes.ApplicationLogic.Services;

namespace TechBytes.Controllers
{
    [Authorize(Roles = "Administrator, User")]
    public class PostsController : Controller
    {
        private readonly PostsService postsService;
        private readonly BlogsService blogsService;

        public PostsController(PostsService postsService, BlogsService blogsService)
        {
            this.postsService = postsService;
            this.blogsService = blogsService;
        }

        // GET: Posts
        public IActionResult Index()
        {
            return View(postsService.GetAll());
        }

        // GET: Posts/Details/5
        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = postsService.GetPostById(id.ToString());

            //var post = await _context.Posts
            //    .Include(p => p.Blog)
            //    .FirstOrDefaultAsync(m => m == id);

            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        // GET: Posts/Create
        public IActionResult Create()
        {
            ViewData["BlogID"] = blogsService.GetAll()
                .Select(c => new SelectListItem() { Text = c.Url, Value = c.ID.ToString() })
                .ToList();
            //    ViewData["BlogID"] = new SelectList(_context.Blogs, "ID", "ID");
            return View();
        }

        // POST: Posts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("ID,BlogID,Published,Modified,Title,Content")] Post post)
        {
            if (ModelState.IsValid)
            {
                post.ID = Guid.NewGuid();
                postsService.Add(post);
                return RedirectToAction(nameof(Index));
            }
            ViewData["BlogID"] = blogsService.GetAll()
                .Select(c => new SelectListItem() { Text = c.Url, Value = c.ID.ToString() })
                .ToList();
            //ViewData["BlogID"] = new SelectList(_context.Blogs, "ID", "ID", post.BlogID);
            return View(post);
        }

        // GET: Posts/Edit/5
        public IActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = postsService.GetPostById(id.ToString());
            if (post == null)
            {
                return NotFound();
            }
            ViewData["BlogID"] = blogsService.GetAll()
                .Select(c => new SelectListItem() { Text = c.Url, Value = c.ID.ToString() })
                .ToList();
            //ViewData["BlogID"] = new SelectList(_context.Blogs, "ID", "ID", post.BlogID);
            return View(post);
        }

        // POST: Posts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Guid id, [Bind("ID,BlogID,Published,Modified,Title,Content")] Post post)
        {
            if (id != post.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    postsService.Update(post);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PostExists(post.ID.ToString()))
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
            ViewData["BlogID"] = blogsService.GetAll()
                .Select(c => new SelectListItem() { Text = c.Url, Value = c.ID.ToString() })
                .ToList();
            //ViewData["BlogID"] = new SelectList(_context.Blogs, "ID", "ID", post.BlogID);
            return View(post);
        }

        // GET: Posts/Delete/5
        public IActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = postsService.GetPostById(id.ToString());

            //var post = await _context.Posts
            //    .Include(p => p.Blog)
            //    .FirstOrDefaultAsync(m => m.ID == id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        // POST: Posts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(string id)
        {
            var post = postsService.GetPostById(id);
            postsService.Delete(post);
            return RedirectToAction(nameof(Index));
        }

        private bool PostExists(string id)
        {
            return postsService.GetPostById(id) != null;
        }
    }
}