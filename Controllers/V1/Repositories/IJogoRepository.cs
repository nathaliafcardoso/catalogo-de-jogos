using Diojogos.Controllers.V1.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DioJogos.Controllers.V1.Repositories
{
   public interface IJogoRepository : IDisposable
    {
        Task<List<Jogo>> Obter(int pagina, int quantidade);
        Task<Jogo> Obter(Guid id);
        Task<List<Jogo>> Obter(string nome, string produtora);
        Task Inserir(Jogo jogo);
        Task Atualizar(Jogo jogo);
        Task Remover(Guid id);
    }
}