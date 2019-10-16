using Microsoft.AspNetCore.Mvc;
using ProAspNetCoreMvcRouting.Models;

namespace ProAspNetCoreMvcRouting.Controllers
{
    public class AdminController : Controller
    {
        public ViewResult Index()
        {
            return View("Resultado", new Resultado { Controller = nameof(AdminController), Action = nameof(Index) });
        }
    }
}
