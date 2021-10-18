using ApiCatalogoJogos1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoJogos1.Repositories
{
    public class IJogoRepository: IDisposable
    {
        Task<List<Jogo>> Obter(int pagina, int quantidade);
        Task<Jogo> Obter(Guid id);
        Task<List<Jogo>> Obter(string nome, string produtora);
        Task Inserir(Jogo jogo);
        Task Atualizar(Jogo jogo);
        Task Remover(Guid id);

        /*internal Task Inserir(Jogo jogoInsert)
        {
            throw new NotImplementedException();
        }

        internal Task Atualizar(object entidadeJogo)
        {
            throw new NotImplementedException();
        }
        
        */
    }
}
