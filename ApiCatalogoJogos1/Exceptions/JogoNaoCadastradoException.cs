using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoJogos1.Exceptions
{
    public class JogoNaoCadastradoException : Exception
    {
        public JogoJaCadastradoException()
            : base("Esse jogo não está cadastrado!")
        { }
    }
}
