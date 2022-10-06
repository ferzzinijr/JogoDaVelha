using System;
using System.Collections.Generic;
using System.Text;

namespace JogoDaVelha
{
    public class Cruzado : Peca
    {
        public override void Imprimir()
        {
            Console.Write(" X ");
        }

        public override int Verifica()
        {
            return 2;
        }
    }
}
