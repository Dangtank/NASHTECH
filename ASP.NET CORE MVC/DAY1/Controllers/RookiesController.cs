using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DAY1.Services;
using System.IO;

namespace DAY1.Controllers
{
    [Route("rookies")]
    [Route("nashtech/rookies")]
    public class RookiesController : Controller
    {
        private readonly ILogger<RookiesController> _logger;
        private readonly IPersonService _personService;

        public RookiesController(ILogger<RookiesController> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }

        [Route("/male-member")]   
        public IActionResult GetMaleMember()
        {
            var data = _personService.GetMale();
            return new JsonResult(data);
        }

        [Route("/oldest-member")]
        public IActionResult GetOldestMember()
        {
            var data = _personService.GetOldest();
            return new JsonResult(data);
        }

        [Route("fullname-member")]
        public IActionResult GetFullNameMember()
        {
            var data = _personService.GetFullName();
            return new JsonResult(data);
        }

        #region
        [Route("year-member")]
        public IActionResult GetMemberByBirthYear(int year)
        {
            var data = _personService.GetPeopleByBirthYear(year);
            return new JsonResult(data);
        }

        [Route("yeargreater-member")]
        public IActionResult GetMemberByBirthYearGreater(int year)
        {
            var data = _personService.GetPeopleByBirthYearGreater(year);
            return new JsonResult(data);
        }

        [Route("yearless-member")]
        public IActionResult GetMemberByBirthYearLess(int year)
        {
            var data = _personService.GetPeopleByBirthYearLess(year);
            return new JsonResult(data);
        }

        [Route("filter-member")]
        public IActionResult FilterMember(int year, string type)
        {
            switch (type)
            {
                case "=":
                    return RedirectToAction("GetMemberByBirthYear", new { year });
                case ">":
                    return RedirectToAction("GetMemberByBirthYearGreater", new { year });
                case "<":
                    return RedirectToAction("GetMemberByBirthYearLess", new { year });
                default:
                    return RedirectToAction("Index");
            }
        }
        #endregion
        [Route("export")]
        public IActionResult Export()
        {
            var buffer = _personService.GetDataStream();
            var stream = new MemoryStream(buffer);
            return new FileStreamResult(stream, "text/csv") { FileDownloadName = "members.csv" };
        }
    }
}
