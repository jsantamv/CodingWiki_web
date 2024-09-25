using CodingWiki_DataAccess.Data;
using CodingWiki_Model.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodingWiki_web.Controllers;

public class CategoryController(ApplicationDbContext db) : Controller
{
    private readonly ApplicationDbContext _db = db;

    public IActionResult Index()
    {
        var categories = _db.Categories.ToList();
        return View(categories);
    }
}