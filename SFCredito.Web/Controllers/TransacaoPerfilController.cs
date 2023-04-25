using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SFCredito.Dominio.Entidades;
using SFCredito.Dominio.Services;
using SFCredito.Dominio.Services.Interfaces;
using SFCredito.Web.Models;

namespace SFCredito.Web.Controllers
{
    public class TransacaoPerfilController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ITransacaoPerfilServices _transacaoperfilServices;
        private readonly INotificacaoService _notificacaoService;

        public TransacaoPerfilController(ILogger<TransacaoPerfilController> logger, ITransacaoPerfilServices transacaoperfilServices, IMapper mapper, INotificacaoService notificacaoService)
        {

            _mapper = mapper;
            _transacaoperfilServices = transacaoperfilServices;
            _notificacaoService = notificacaoService;
        }
        //public IActionResult Index()
        //{
        //    var usuario = transacaoperfilServices.GetAll();

        //    var usuarioModel = _mapper.Map<List<Usuario>, List<UsuarioModel>>(usuario);

        //    return View(usuarioModel);
        //}
    }
}
