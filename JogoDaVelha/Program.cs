using System;

namespace JogoDaVelha
{
    public class Program
    {
        static void Main(string[] args)
        {
            var jogo = new Jogo();
            jogo.CriarJogo();
            jogo.Jogar();
        }
    }
}
