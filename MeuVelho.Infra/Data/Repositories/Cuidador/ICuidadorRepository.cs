﻿using MeuVelho.Domains;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MeuVelho.Infra.Data.Repositories
{
    public interface ICuidadorRepository
    {
        public Task<CuidadorDomain> Salvar(CuidadorDomain cuidador);
        public Task<List<CuidadorDomain>> Listar();
        public Task<CuidadorDomain> Pegar(Guid id);
        public void Desativar(Guid id);
    }
}
