using System;
using System.Collections.Generic;
using System.Text;

namespace JogoDaVelha
{
    public class Jogo
    {
        public int Linhas = 3;
        public int Colunas = 3;
        public List<Jogador> Jogadores = new List<Jogador>();
        public Peca[,] Pecas;

        public void CriarJogo()
        {
            Pecas = new Peca[Linhas, Colunas];

            for (int i = 0; i < Linhas; i++)
            {
                for (int j = 0; j < Colunas; j++)
                {
                    Pecas[i, j] = new Peca();
                }
            }
        }

        private void Imprimir()
        {
            for (int i = 0; i < Linhas; i++)
            {
                for (   int j = 0; j < Colunas; j++)
                {
                    Pecas[i, j].Imprimir(); 
                }

                Console.WriteLine("");
            }
        }

        public void Jogar()
        {
            var jogador1 = CriarJogador(new Circulo());
            Jogadores.Add(jogador1);
            var jogador2 = CriarJogador(new Cruzado());
            Jogadores.Add(jogador2);
            Console.Clear();
            Imprimir();

            var jogadas = 1;
            while(true)
            {
                for (int i = 0; i < Linhas; i++)
                {
                    for (int j = 0; j < Colunas; j++)
                    {
                        Console.Write($"({i},{j}) ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                if (jogadas == 10)
                {
                    Console.WriteLine("VELHA!!");
                    break;
                }

                var jogadorAtual = jogadas % 2 == 0 ? 1 : 0;
                Console.WriteLine($"{Jogadores[jogadorAtual].Nome}, escolha sua jogada: ");
                string posicao = Console.ReadLine();
                int coluna = Convert.ToInt16(posicao.Substring(0, 1));
                int linha = Convert.ToInt16(posicao.Substring(2));

                if (VerificaPosicao(coluna, linha))
                {
                    Console.Clear();
                    GerarPeca(coluna, linha, Jogadores[jogadorAtual].PecaEscolhida);
                    Imprimir();
                    jogadas++;
                }

                if (VerificaVencedorLinha() || VerificaVencedorColuna() || VerificaVencedorDiagonal())
                {
                    Console.WriteLine();
                    Console.WriteLine($"{Jogadores[jogadorAtual].Nome} ganhou.");
                    break;
                }
            }
        }

        private Jogador CriarJogador(Peca tipo)
        {
            Console.WriteLine("Digite o nome do jogador: ");
            string nome = Console.ReadLine();
            var jogador = new Jogador(nome, tipo);
            Console.WriteLine();
            return jogador;
        }

        private bool GerarPeca(int coluna, int linha, Peca tipo)
        {
            Pecas[coluna, linha] = tipo;
            return true;
        }

        private bool VerificaPosicao(int coluna, int linha)
        {
            if (Pecas[coluna, linha].Verifica() == 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Já existe uma peça nessa posição");
                return false;
            }
        }

        private bool VerificaVencedorLinha()
        {
            if (Pecas[0, 0].Verifica() == 1 && Pecas[0, 1].Verifica() == 1 && Pecas[0, 2].Verifica() == 1 ||
                Pecas[1, 0].Verifica() == 1 && Pecas[1, 1].Verifica() == 1 && Pecas[1, 2].Verifica() == 1 ||
                Pecas[2, 0].Verifica() == 1 && Pecas[2, 1].Verifica() == 1 && Pecas[2, 2].Verifica() == 1 ||
                Pecas[0, 0].Verifica() == 2 && Pecas[0, 1].Verifica() == 2 && Pecas[0, 2].Verifica() == 2 ||
                Pecas[1, 0].Verifica() == 2 && Pecas[1, 1].Verifica() == 2 && Pecas[1, 2].Verifica() == 2 ||
                Pecas[2, 0].Verifica() == 2 && Pecas[2, 1].Verifica() == 2 && Pecas[2, 2].Verifica() == 2)
            {
                return true;
            }
            return false;
        }

        private bool VerificaVencedorColuna()
        {
            if (Pecas[0, 0].Verifica() == 1 && Pecas[1, 0].Verifica() == 1 && Pecas[2, 0].Verifica() == 1 ||
                Pecas[0, 1].Verifica() == 1 && Pecas[1, 1].Verifica() == 1 && Pecas[2, 1].Verifica() == 1 ||
                Pecas[0, 2].Verifica() == 1 && Pecas[1, 2].Verifica() == 1 && Pecas[2, 2].Verifica() == 1 ||
                Pecas[0, 0].Verifica() == 2 && Pecas[1, 0].Verifica() == 2 && Pecas[2, 0].Verifica() == 2 ||
                Pecas[0, 1].Verifica() == 2 && Pecas[1, 1].Verifica() == 2 && Pecas[2, 1].Verifica() == 2 ||
                Pecas[0, 2].Verifica() == 2 && Pecas[1, 2].Verifica() == 2 && Pecas[2, 2].Verifica() == 2)
            {
                return true;
            }
            return false;
        }

        private bool VerificaVencedorDiagonal()
        {
            if (Pecas[0, 0].Verifica() == 1 && Pecas[1, 1].Verifica() == 1 && Pecas[2, 2].Verifica() == 1 ||
                Pecas[0, 2].Verifica() == 1 && Pecas[1, 1].Verifica() == 1 && Pecas[2, 0].Verifica() == 1 ||
                Pecas[0, 2].Verifica() == 2 && Pecas[1, 1].Verifica() == 2 && Pecas[2, 0].Verifica() == 2 ||
                Pecas[0, 2].Verifica() == 2 && Pecas[1, 1].Verifica() == 2 && Pecas[2, 0].Verifica() == 2)
            {
                return true;
            }
            return false;
        }
    }
}
