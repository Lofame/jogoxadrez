using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    internal class Posicao
    {
        public int coluna { get; set; }
        public int linha { get; set; }

        public Posicao(int linha, int coluna)
        {
            this.coluna = coluna;
            this.linha = linha;
        }

        public void DefinirValores(int linha, int coluna)
        {
            this.coluna = coluna;
            this.linha = linha;
        }


        public override string ToString()
        {
            return linha.ToString() + " , " + coluna.ToString();
        }
    }
}
