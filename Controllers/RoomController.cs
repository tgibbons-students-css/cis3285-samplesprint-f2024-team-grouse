using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CIS3285_Unit3Sample_2024.Controllers
{
    public class RoomController : Controller
    {
        // GET: RoomController
        public ActionResult Index()
        {
            return View();
        }

        // GET: RoomController/Details/5
        public ActionResult Details(int id)
        {
            // Changes for Sprint # -- User Story -- Developer's Name
            // Changes Sprint 1, US-1A-1 -- As a message posting user, I want to create rooms for categorizing conversations. -- Zach Major

            return View();
        }

        // GET: RoomController/Create
        public ActionResult Create()
        {
            // Changes for Sprint # -- User Story -- Developer's Name
            // Changes Sprint 1, US-1A-1 -- As a message posting user, I want to create rooms for categorizing conversations. -- Zach Major
            return View();
        }

        // POST: RoomController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            // Changes for Sprint # -- User Story -- Developer's Name
            // Changes Sprint 2, US-2D-1 -- As a system admin, I want to be able to set a limit to the number of users in any one room. -- Zach Major

            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RoomController/Edit/5
        public ActionResult Edit(int id)
        {
            // Changes for Sprint # -- User Story -- Developer's Name
            // Changes Sprint 1, US-1A-2 -- As a message posting user, I want to create rooms for categorizing conversations. -- Zach Major
            return View();
        }

        // POST: RoomController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            // Changes for Sprint # -- User Story -- Developer's Name
            // Changes Sprint 2, US-2D-1 -- As a system admin, I want to be able to set a limit to the number of users in any one room. -- Zach Major

            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RoomController/Delete/5
        public ActionResult Delete(int id)
        {
            // Changes for Sprint # -- User Story -- Developer's Name
            // Changes Sprint 1, US-1A-2 -- As a message posting user, I want to create rooms for categorizing conversations. -- Zach Major
            return View();
        }

        // POST: RoomController/Delete/5
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
