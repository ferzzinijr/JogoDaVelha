using System;
using System.Collections.Generic;
using System.Text;

namespace JogoDaVelha
{
    public class Circulo : Peca
    {
        public override void Imprimir()
        {
            Console.Write(" O ");
        }

        public override int Verifica()
        {
            return 1;
        }
    }
}
