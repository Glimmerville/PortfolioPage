using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Portfolio2016.Models;

namespace Portfolio2016.Controllers
{
    public class ProjectListModelsController : Controller
    {
        private Portfolio2016Context db = new Portfolio2016Context();

        // GET: ProjectListModels
        public ActionResult Index()
        {
            return View(db.ProjectListModels.ToList());
        }

        // GET: ProjectListModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectListModel projectListModel = db.ProjectListModels.Find(id);
            if (projectListModel == null)
            {
                return HttpNotFound();
            }
            return View(projectListModel);
        }

        // GET: ProjectListModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProjectListModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProjectID,ProjectName,ProjectMaterials,ProjectDescription,ProjectImage,ProjectSmlImage,ProjectRepo,ProjectURL")] ProjectListModel projectListModel)
        {
            if (ModelState.IsValid)
            {
                db.ProjectListModels.Add(projectListModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(projectListModel);
        }

        // GET: ProjectListModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectListModel projectListModel = db.ProjectListModels.Find(id);
            if (projectListModel == null)
            {
                return HttpNotFound();
            }
            return View(projectListModel);
        }

        // POST: ProjectListModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProjectID,ProjectName,ProjectMaterials,ProjectDescription,ProjectImage,ProjectSmlImage,ProjectRepo,ProjectURL")] ProjectListModel projectListModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(projectListModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(projectListModel);
        }

        // GET: ProjectListModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectListModel projectListModel = db.ProjectListModels.Find(id);
            if (projectListModel == null)
            {
                return HttpNotFound();
            }
            return View(projectListModel);
        }

        // POST: ProjectListModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProjectListModel projectListModel = db.ProjectListModels.Find(id);
            db.ProjectListModels.Remove(projectListModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
