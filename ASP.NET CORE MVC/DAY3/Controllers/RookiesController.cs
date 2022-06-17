using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DAY3.Services;
using System.IO;
using DAY3.Models;
using Microsoft.AspNetCore.Http;

namespace DAY3.Controllers
{
    // [Route("rookies")]
    // [Route("nashtech/rookies")]
    public class RookiesController : Controller
    {
        private readonly ILogger<RookiesController> _logger;
        private readonly IPersonService _personService;

        public RookiesController(ILogger<RookiesController> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }

        public IActionResult Index()
        {
            var data = _personService.GetAll();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person model)
        {
            var result = _personService.Create(model);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int index)
        {
            ViewData["index"] = index;
            var person = _personService.GetOne(index);

            return View();
        }

        [HttpPost]
        public IActionResult Update(int index, Person model)
        {
            var current = _personService.GetOne(index);
            current.FirstName = model.FirstName;
            current.LastName = model.LastName;
            current.Gender = model.Gender;

            var result = _personService.Update(index, model);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int index)
        {
            _personService.Delete(index);

            return RedirectToAction("Index");
        }

        public IActionResult Details(int index)
        {
            ViewData["Index"] = index;
            var person = _personService.GetOne(index);

            return View(person);
        }

        [HttpPost]
        public IActionResult DeleteAndRedirectToResultPage(int index)
        {
            var person = _personService.GetOne(index);
            HttpContext.Session.SetString("DELETED_MEMBER_FULLNAME", person.FullName);
            _personService.Delete(index);

            return RedirectToAction("DeleteResult", new { name = person.FullName });
        }

        public IActionResult DeleteResult()
        {
            return View();
        }
    }
}
