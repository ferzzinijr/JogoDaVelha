using System;
using System.Collections.Generic;
using System.Text;

namespace JogoDaVelha
{
    public class Peca
    {
        public virtual void Imprimir()
        {
            Console.Write(" - ");
        }

        public virtual int Verifica()
        {
            return 0;
        }
    }
}
