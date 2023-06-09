﻿using SFCredito.Dominio.Entidades;
using SFCredito.Dominio.Repositories.Interfaces;
using SFCredito.Dominio.Services.Interfaces;


namespace SFCredito.Dominio.Services
{
    public class EmpresaServices : IEmpresaServices
    {
        private readonly IEmpresaRepository _empresaRepository;
        private readonly INotificacaoService _notificacaoService;

        public EmpresaServices(IEmpresaRepository empresaRepository, INotificacaoService notificacaoService)
        {
            this._empresaRepository = empresaRepository;
            _notificacaoService = notificacaoService;
        }


        async Task<List<Empresa>>? GetAll()
        {
            var teste = await _empresaRepository.ListarTodos(0,0);

            return teste;
        }

        public Task<Empresa> ObterEmpresa(long id)
        {
            var empresa = _empresaRepository.ObterPorChave(id);

            _empresaRepository.Salvar();

            return empresa;
        }

        public async Task Adicionar(Empresa empresa, CancellationToken cancellationToken)
        {
            empresa.IdUsuario = 79;
            await _empresaRepository.Adicionar(empresa);

            await _empresaRepository.Salvar();

        }

         async  Task<List<Empresa>>? IEmpresaServices.GetAll()
        {
            var teste = await _empresaRepository.ListarTodos(0, 0);

            return teste;
        }

        public async Task Edite (Empresa empresa)
        {
            {
                empresa.IdUsuario = 79;

                await _empresaRepository.Alterar(empresa);

                await _empresaRepository.Salvar();

                
               
            }
            
        }
    }
}

