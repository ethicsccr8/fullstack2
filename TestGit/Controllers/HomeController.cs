using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TestGit.Models;

namespace TestGit.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //Enrique Comentando
        //Aqui es que va el comentario
        //Este es un comentario para hacer commit desde vs 
        //Este es un comentario para hacer commit desde la consola
        // Gabriel's comment
        return View();
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
