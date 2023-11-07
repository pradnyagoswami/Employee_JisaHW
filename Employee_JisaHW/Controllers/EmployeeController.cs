using Employee_JisaHW.Models;
using Employee_JisaHW.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Employee_JisaHW.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService service;

        public EmployeeController(IEmployeeService service)
        {
            this.service = service;
        }

        // GET: EmployeeController
        public ActionResult Index()
        {
            return View(service.GetEmployes());
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            var model = service.GetEmployeById(id);
            return View();
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            try
            {
                int result = service.AddEmploye(employee);
                if (result >= 1)
                {
                    return RedirectToAction(nameof(Index));
                }

                else
                {
                    return View();
                }

            }
            catch (Exception ex)
            {
                ViewBag.error = ex.Message;
                return View();
            }
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            var employee = service.GetEmployeById(id);
            return View();
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee employee)
        {
            try
            {
                int result = service.UpdateEmploye(employee);
                if (result >= 1)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View();
                }

            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            var employee = service.GetEmployeById(id);
            return View();
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            try
            {
                int result = service.DeleteEmploye(id);
                if (result >= 1)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View();
                }

            }
            catch
            {
                return View();
            }
        }
    }
}
