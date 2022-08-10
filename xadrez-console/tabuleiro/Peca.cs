

namespace tabuleiro
{
     class Peca
    {
        public Pocisao pocisao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdMovimentos { get; protected set; }
        public Tabuleiro tab { get; set; }

        public Peca( Tabuleiro tab, Cor cor)
        {
            this.pocisao = null;
            this.cor = cor;
            this.tab = tab;
            this.qtdMovimentos = 0;
        }

      

    }
}
