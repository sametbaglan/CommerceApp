using CommerceApp.DbConnection;
using Microsoft.AspNetCore.Mvc;

namespace CommerceApp.Controllers
{
    public class CategoriaAttirbuteController : Controller
    {
        DataContext db = new DataContext();
        public IActionResult List()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CategoryAddAttirbute(int categoryid)
        {
            return View();
        }
    }
}
