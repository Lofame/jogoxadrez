using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    internal class Pocisao
    {
        public int coluna { get; set; }
        public int linha { get; set; }

        public Pocisao(int linha, int coluna)
        {
            this.coluna = coluna;
            this.linha = linha;
        }
    }
}
