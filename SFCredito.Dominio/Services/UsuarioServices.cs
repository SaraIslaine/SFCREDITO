using SFCredito.Dominio.Entidades;
using SFCredito.Dominio.Repositories.Interfaces;
using SFCredito.Dominio.Services.Interfaces;
using SFCredito.Shared.ObjetosAuxiliares;

namespace SFCredito.Dominio.Services
{
    public class UsuarioServices : IUsuarioServices
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly INotificacaoService _notificacaoService;

        public UsuarioServices(IUsuarioRepository usuarioRepository, INotificacaoService notificacaoService)
        {
            this._usuarioRepository = usuarioRepository;
            _notificacaoService = notificacaoService;
        }

        public void Adicionar(Usuario usuario)
        {
            Notificacao notificacao = new Notificacao();

            try
            {
      
                usuario.DataCadastro = DateTime.Now;
                usuario.DataAtualizacao = null;
                usuario.Ativo = true;

                _usuarioRepository.Adicionar(usuario);

                _usuarioRepository.Salvar();


                #region Montando Notificação
                notificacao.Acao = true;
                notificacao.Erro = true;
                notificacao.Descricao = $"Usuário incluido com sucesso.";
                notificacao.Titulo = "OK";
                notificacao.TipoMensagem = "success";
                #endregion

                _notificacaoService.Notificacoes(notificacao);

            }
            catch (Exception ex)
            {
                notificacao.Acao = false;
                notificacao.Erro = false;
                notificacao.TipoMensagem = "error";
                notificacao.Descricao = "Erro interno";
                _notificacaoService.Notificacoes(notificacao);
            }     
        }

        public async void Deletar(long id)
        {
            var usuario =   _usuarioRepository.ObterPorChave(Convert.ToInt32(id));

            _usuarioRepository.Excluir(usuario.Result);

            _usuarioRepository.Salvar();
        }

        public Usuario Edite(Usuario usuario)
        {
            usuario.DataAtualizacao = DateTime.Now;

            _usuarioRepository.Alterar(usuario);

            _usuarioRepository.Salvar();

            return usuario;
        }
        public Usuario SenhaAlterada(Usuario usuario)
        {
            Notificacao notificacao = new Notificacao();
            try
            {

                _usuarioRepository.Alterar(usuario);

                _usuarioRepository.Salvar();
            }
            catch (Exception)
            {
                notificacao.Acao = false;
                notificacao.Erro = false;
                notificacao.TipoMensagem = "error";
                notificacao.Descricao = "Erro interno";
                _notificacaoService.Notificacoes(notificacao); throw;
            }
         

            return usuario;
        }

        public Task<List<Usuario>>? GetAll()
        {
            var teste = _usuarioRepository.ListarTodos(0,0);

            return teste;
        }

        public Task<Usuario> ObterUsuario(long id)
        {
            var usuario =  _usuarioRepository.ObterPorChave(Convert.ToInt32(id));

            _usuarioRepository.Salvar();

            return usuario;
        }
    }
}