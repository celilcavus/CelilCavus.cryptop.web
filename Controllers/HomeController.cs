using CelilCavus.cryptop.web.Entity;
using CelilCavus.cryptop.web.Models.Contexts;
using CelilCavus.cryptop.web.UnitofWork;
using System.Linq;
using System.Web.Mvc;

namespace CelilCavus.cryptop.web.Controllers
{
    public class HomeController : Controller
    {
        private readonly Uow _work;

        public HomeController()
        {
            _work = new Uow(new AppContext());
        }
        [HttpGet]
        public ActionResult Index()
        {
            var values = _work.GetRepository<Home>().GetAll().LastOrDefault();
            return View(values);
        }

        public PartialViewResult GetPartialHowItsWorks()
        {
            var getPartialworks = _work.GetRepository<Works>().GetAll();
            return PartialView("_PartialPageHowItsWorks",getPartialworks);
        }
        public PartialViewResult GetPartialAbout()
        {
            var getPartialAbout = _work.GetRepository<About>().GetAll().LastOrDefault();
            return PartialView("_PartialPageAbout", getPartialAbout);
        }
        public PartialViewResult GetPartialAutomatic()
        {
            var getAutoMatic = _work.GetRepository<StartAutoMatic>().GetAll().LastOrDefault();
            return PartialView("_PartialPageStartAutomatic",getAutoMatic);
        }
    }
}