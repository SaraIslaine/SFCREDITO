using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SFCredito.Dominio.Entidades;
using SFCredito.Dominio.Services;
using SFCredito.Dominio.Services.Interfaces;
using SFCredito.Web.Models;

namespace SFCredito.Web.Controllers
{
    public class EmpresaController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IEmpresaServices _empresaServices;
        private readonly INotificacaoService _notificacaoService;

        public EmpresaController(ILogger<EmpresaController> logger, IEmpresaServices empresaServices, IMapper mapper, INotificacaoService notificacaoService)
        {

            _mapper = mapper;
            _empresaServices = empresaServices;
            _notificacaoService = notificacaoService;
           
        }
        public async Task<IActionResult> Index()
        {
            
                var empresa = await _empresaServices.GetAll();

                var empresaModel = _mapper.Map<List<Empresa>, List<EmpresaModel>>(empresa);

                return View(empresaModel); 
           
        }

        public IActionResult Edit(long id)
        {
            var empresa = _empresaServices.ObterEmpresa(id).Result;

            var empresaModel = _mapper.Map<Empresa, EmpresaModel>(empresa);

            return View(empresaModel);
        }

        [HttpPost]
        public IActionResult Edit(EmpresaModel empresaModel)
        {
            if (ModelState.IsValid)
            {
                var empresa = _mapper.Map<EmpresaModel, Empresa>(empresaModel);

                _empresaServices.Edite(empresa);

                return RedirectToAction("Index");
            }

            return View(empresaModel);
        }

        [HttpGet]
        public IActionResult Create(long id)
        {
            var empresa = _empresaServices.ObterEmpresa(id).Result;

            var empresaModel = _mapper.Map<Empresa, EmpresaModel>(empresa);

            return View(empresaModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(EmpresaModel empresaModel)
    {
        if (ModelState.IsValid)
    {
        var empresa = _mapper.Map<EmpresaModel, Empresa>(empresaModel);

        _empresaServices.Adicionar(empresa, default);

    }
        return PartialView("Create", empresaModel);
    }

  }
    }