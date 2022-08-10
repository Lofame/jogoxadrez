

namespace tabuleiro
{
     class Peca
    {
        public Pocisao pocisao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdMovimentos { get; protected set; }
        public Tabuleiro tab { get; set; }

        public Peca(Pocisao pocisao, Cor cor, Tabuleiro tab)
        {
            this.pocisao = pocisao;
            this.cor = cor;
            this.tab = tab;
        }

      

    }
}
