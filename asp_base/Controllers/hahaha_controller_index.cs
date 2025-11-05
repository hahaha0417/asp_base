using Microsoft.AspNetCore.Mvc;

namespace asp_base.Controllers
{
    [Route("/")]
    public class hahaha_controller_index : Controller
    {
        // GET: hahaha_index_controller
        [HttpGet("")]
        public ActionResult Index()
        {

            return View("~/Views/home/index.cshtml");
        }

        [HttpGet("test")]
        public ActionResult Test()
        {
            return View("~/Views/home/test.cshtml");
        }

    }
}
