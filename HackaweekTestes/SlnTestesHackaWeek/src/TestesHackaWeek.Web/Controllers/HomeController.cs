using ConvertHTMLtoXML.Classes;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.IO;
using TestesHackaWeek.Web.Models;

namespace TestesHackaWeek.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ConvertHTMLtoXMLClass _converter;

    public HomeController(ILogger<HomeController> logger, ConvertHTMLtoXMLClass converter)
    {
        _logger = logger;
        _converter = converter;
    }

    public IActionResult Index()
    {
        return View(_converter.ConverterHTML());
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
