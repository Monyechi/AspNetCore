using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AspNetCore.Data;
namespace AspNetCore.Controllers
{
    public class SuperHeroesController : Controller
    {
        ApplicationDbContext context;
        public SuperHeroesController(ApplicationDbContext context)
        {
            this.context = context;
        }
        // GET: SuperHeroes
        public ActionResult Index()
        {
            var superHeroes = context.superHeroes.ToList();
            return View(superHeroes);
        }

        // GET: SuperHeroes/Details/5
        public ActionResult Details(int id)
        {
            var superheroInDb = context.superHeroes.Where(s => s.Id == id).FirstOrDefault();
            return View(superheroInDb);
        }

        // GET: SuperHeroes/Create
        public ActionResult Create()
        {
            SuperHero superHero = new SuperHero();
            return View(superHero);
        }

        // POST: SuperHeroes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SuperHero superHero)
        {
            try
            {
                // TODO: Add insert logic here
                context.superHeroes.Add(superHero);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(superHero);
            }
        }

        // GET: SuperHeroes/Edit/5
        public ActionResult Edit(int id)
        {
            var superheroInDb = context.superHeroes.Where(s => s.Id == id).FirstOrDefault();
            return View(superheroInDb);
        }

        // POST: SuperHeroes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, SuperHero superHero)
        {
            try
            {
                // TODO: Add update logic here
                var superheroInDb = context.superHeroes.Where(s => s.Id == id).FirstOrDefault();
                context.superHeroes.Remove(superheroInDb);
                context.superHeroes.Add(superHero);
                context.SaveChanges();
                return View (superHero);
            }
            catch
            {
                return View(superHero);
            }
        }

        // GET: SuperHeroes/Delete/5
        public ActionResult Delete(int id)
        {
            var superheroInDb = context.superHeroes.Where(s => s.Id == id).FirstOrDefault();
            return View(superheroInDb);
        }

        // POST: SuperHeroes/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(SuperHero superHero)
        {
            try
            {
                // TODO: Add delete logic here
                context.Remove(superHero);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}