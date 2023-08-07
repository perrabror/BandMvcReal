using BandMvcReal.Models;
using Microsoft.AspNetCore.Mvc;

namespace BandMvcReal.Controllers
{
    public class BandsController : Controller
    {
        DataService dataService;
        public BandsController()
        {
            dataService = new DataService();
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            var model = dataService.GetAllBands();
            //return View(model);
            return View(model);
        }

        [HttpGet("Details/{id}")]
        public IActionResult Details(int id)
        {
            var band = dataService.GetBandById(id);

            return View(band);

        }
    }
}
