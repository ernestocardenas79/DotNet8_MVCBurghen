
using dn8mvc.web.Data;
using Microsoft.AspNetCore.Mvc;

namespace dn8mvc.web.Controllers;
public class CategoryController : Controller {
    private readonly ApplicationContext ApplicationDbContext;

    public CategoryController(ApplicationContext applicationDbContext)
    {
        ApplicationDbContext = applicationDbContext;
    }

    public IActionResult Index(){

        var categories = ApplicationDbContext.Categories.ToList();
        return View(categories);
    }
}