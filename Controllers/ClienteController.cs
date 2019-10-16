using Microsoft.AspNetCore.Mvc;
using ProAspNetCoreMvcRouting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProAspNetCoreMvcRouting.Controllers
{
    public class ClienteController : Controller
    {
        public ViewResult Index()
        {
            return View("Resultado", new Resultado { Controller = nameof(ClienteController), Action = nameof(Index) });
        }
        public ViewResult List()
        {
            return View("Resultado", new Resultado { Controller = nameof(ClienteController), Action = nameof(List) });
        }
    }
}
