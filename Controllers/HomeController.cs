using Microsoft.AspNetCore.Mvc;
using ProAspNetCoreMvcRouting.Models;

namespace ProAspNetCoreMvcRouting.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("Resultado", new Resultado { Controller = nameof(HomeController), Action = nameof(Index) });
        }

        public ViewResult Seguimento()
        {
            Resultado resultado = new Resultado
            {
                Controller = nameof(HomeController),
                Action = nameof(Seguimento),
            };
            resultado.Data["id"] = RouteData.Values["id"];
            return View("Resultado", resultado);
        }
        public ViewResult Parametro(string id)
        {
            Resultado resultado = new Resultado
            {
                Controller = nameof(HomeController),
                Action = nameof(Seguimento),
            };
            resultado.Data["id"] = id;
            return View("Resultado", resultado);
        }

    }
}
