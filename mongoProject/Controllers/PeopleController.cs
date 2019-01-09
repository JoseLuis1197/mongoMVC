using MongoDB.Bson;
using MongoDB.Driver;
using mongoProject.App_Start;
using mongoProject.Models;
using System.Web.Mvc;

namespace mongoProject.Controllers
{
    public class PeopleController : Controller
    {
        MongoDBContext dbContext = new MongoDBContext();


        // GET: People
        public ActionResult Index()
        {  
            var document = dbContext.connection.Find(new BsonDocument()).ToList();

            return View(document);
        }


    
        

        // GET: People/Details/5
        public ActionResult Details(int id)
        {       
            return View();
        }

       

        // GET: People/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: People/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: People/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: People/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
