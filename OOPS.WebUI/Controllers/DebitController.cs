using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract;
using OOPS.BLL.Abstract.Employee;
using OOPS.DTO.Employee;

namespace OOPS.WebUI.Controllers
{
    public class DebitController : BaseController
    {
        private IDebitService service;
        private IEmployeeService employeeservice;
        public DebitController(IDebitService _service, IEmployeeService _employeeservice)
        {
            service = _service;
            employeeservice = _employeeservice;
        }

        //public IActionResult AddDebit()
        //{
        //    DebitDTO debit = new DebitDTO();
        //    return View(debit);
        //}

        [HttpPost]
        public IActionResult AddDebit(DebitDTO debit)
        {
            service.newDebit(debit);
            return RedirectToAction("Index","Home");
        }

        public IActionResult ListDebit()
        {
            List<DebitDTO> debit = service.getAllEmployeeDebits();
            return View(debit);
        }

        [HttpPost]
        public IActionResult ListDebit(DebitDTO debit)
        {

            service.getDebit(debit.EmployeeId);
            return RedirectToAction("Index");
        }
    }
}