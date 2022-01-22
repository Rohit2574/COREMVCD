using COREMVCD.Models;
using COREMVCD.Models.Respository.Contract;
using Microsoft.AspNetCore.Mvc;
namespace COREMVCD.Controllers
{
    public class EmployeeController : Controller
    {
        public IEmployee EmployeeService { get; }
        public EmployeeController(IEmployee _employeeService)
        {
            EmployeeService = _employeeService;
        }


        public IActionResult Index()
        {
            var emps = EmployeeService.GetEmployees();
            return View(emps);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            EmployeeService.CreateEmployee(employee);
            return RedirectToAction("Index");
        }
    }
}


