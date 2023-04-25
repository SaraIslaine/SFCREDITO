using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SFCredito.Dominio.Entidades;
using SFCredito.Dominio.Services.Interfaces;
using SFCredito.Web.Models;
using System.Diagnostics;

namespace SFCredito.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ILogger<ClienteController> _logger;
        private readonly IClienteServices _clienteServices;
        private readonly IMapper _mapper;

        public ClienteController(ILogger<ClienteController> logger, IClienteServices clienteServices, IMapper mapper)
        {
            _mapper = mapper;
            _logger = logger;
            _clienteServices = clienteServices;
        }

        public IActionResult Index()
        {
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
}