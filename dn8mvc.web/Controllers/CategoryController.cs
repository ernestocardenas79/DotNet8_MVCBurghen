
using Microsoft.AspNetCore.Mvc;

namespace dn8mvc.web.Controllers;
public class CategoryController : Controller {
    public IActionResult Index(){
        return View();
    }
}