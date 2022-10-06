using System;
using System.Collections.Generic;
using System.Text;

namespace JogoDaVelha
{
    public class Jogador
    {
        public string Nome { get; private set; }
        public Peca PecaEscolhida { get; private set; }

        public Jogador(string nome, Peca pecaEscolhida)
        {
            Nome = nome;
            PecaEscolhida = pecaEscolhida;
        }

    }
}
