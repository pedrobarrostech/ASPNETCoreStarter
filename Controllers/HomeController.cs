using Microsoft.AspNetCore.Mvc;
using WebApplication.Data;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {

        [RouteAttribute("/")]
        public JsonResult Index()
        {
            var vehicle = new Vehicle{Name="Audi A8", Wheels= 4, Engine= "V8"};
            return Json(vehicle);
        }
    }
}
