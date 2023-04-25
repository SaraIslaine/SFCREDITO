using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SFCredito.Dominio.Entidades;
using SFCredito.Dominio.Services.Interfaces;
using SFCredito.Web.Models;


namespace SFCredito.Web.Controllers
{

    public class UsuarioController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IUsuarioServices _usuarioServices;
        private readonly IPerfilServices _perfilServices;
        private readonly INotificacaoService _notificacaoService;

        public UsuarioController(ILogger<UsuarioController> logger, IUsuarioServices usuarioServices, IPerfilServices perfilServices, IMapper mapper, INotificacaoService notificacaoService)
        {

            _mapper = mapper;
            _usuarioServices = usuarioServices;
            _notificacaoService = notificacaoService;
            _perfilServices= perfilServices;
        }

        public async Task<IActionResult> Index()
        {
            var usuario = await _usuarioServices.GetAll();

            var usuarioModel = _mapper.Map<List<Usuario>, List<UsuarioModel>>(usuario);

            return View(usuarioModel);

        }
        /// <summary>
        /// clique button
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Edit(long id)
        {
            var usuario = _usuarioServices.ObterUsuario(id).Result;

            var usuarioModel = _mapper.Map<Usuario, UsuarioModel>(usuario);

            return View(usuarioModel);
        }

        [HttpPost]
        public IActionResult Edit(UsuarioModel usuarioModel)
        {
            if (ModelState.IsValid)
            {
                var usuario = _mapper.Map<UsuarioModel, Usuario>(usuarioModel);

                _usuarioServices.Edite(usuario);

                return RedirectToAction("Index");
            }

            return View(usuarioModel);
        }

        public IActionResult Delete(long id)
        {
            var usuario = _usuarioServices.ObterUsuario(id).Result;

            var usuarioModel = _mapper.Map<Usuario, UsuarioModel>(usuario);

            return View(usuarioModel);
        }

        public IActionResult Deletar(long id)
        {
            _usuarioServices.Deletar(id);


            return RedirectToAction("Index");
        }
        public IActionResult Modal(long id)
        {
            var usuario = _usuarioServices.ObterUsuario(id).Result;

            var usuarioModel = _mapper.Map<Usuario, UsuarioModel>(usuario);

            return View(usuarioModel);
        }

        public IActionResult AlterarSenha(long id)
        {
            var usuario = _usuarioServices.ObterUsuario(id).Result;

            var usuarioModel = _mapper.Map<Usuario, UsuarioModel>(usuario);

            var usuarioNovaSenha = new UsuarioNovaSenhaModel { Usuario = usuarioModel };

            return View(usuarioNovaSenha);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AlterarSenha(UsuarioNovaSenhaModel usuarioNovaSenhaModel)
        {
            if (ModelState.IsValid)
            {

                if (usuarioNovaSenhaModel.Usuario.Senha != usuarioNovaSenhaModel.Senha)
                {
                    return Json(new
                    {
                        erro = false,
                        title = "OK",
                        message = "Senha antiga não confere com senha digitada!!!",
                        controller = "Usuario",
                        action = "Index",
                        tipoMensagem = "warning",
                        redirect = false,
                        notificacao = true
                    });

                }

                usuarioNovaSenhaModel.Usuario.Senha = usuarioNovaSenhaModel.NovaSenha;

                var usuario = _mapper.Map<UsuarioModel, Usuario>(usuarioNovaSenhaModel.Usuario);

                _usuarioServices.SenhaAlterada(usuario);

                return Json(new
                {
                    erro = false,
                    title = "OK",
                    message = "senha alterada com sucesso!!!", 
                    controller = "Usuario", 
                    action = "Index",
                    tipoMensagem = "success",
                    redirect = true,
                    notificacao = true
                });
            }

            return View(usuarioNovaSenhaModel);
        }
        [HttpGet]
        public  IActionResult Create()
        {
            var perfis =  _perfilServices.Listar();

            var modelUsuario = new UsuarioModel();

            ViewData["IdPerfil"] = new SelectList(perfis.Result.AsEnumerable(), "Id", "Descricao", modelUsuario.IdPerfil);
            return View(modelUsuario);
        }


        [HttpPost]
        public IActionResult Create(UsuarioModel usuarioModel)
        {
            if (ModelState.IsValid)
            {
                var usuario = _mapper.Map<UsuarioModel, Usuario>(usuarioModel);

                _usuarioServices.Adicionar(usuario);

                var notificacao = _notificacaoService.MostrarNotificacoes();

                return Json(new
                {
                    erro = notificacao.Erro,
                    title = notificacao.Titulo,
                    message = "Cadastrado com sucesso!!!",
                    controller = "Usuario",
                    action = "Create",
                    tipoMensagem = "success",
                    redirect = true,
                    notificacao = true
                });
                //{
                //    erro = false,
                //    title = "OK",
                //    message = "Cadastrado com sucesso!!!",
                //    controller = "Usuario",
                //    action = "Index",
                //    tipoMensagem = "success",
                //    redirect = true,
                //    notificacao = true
                //});
            }
            return PartialView("Create", usuarioModel);
        }

        }
    }

