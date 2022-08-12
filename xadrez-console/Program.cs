using tabuleiro;
using xadrez;
using tabuleiro.Exceptions;
namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {

            try { 
            PartidaDeXadrez partidaDeXadrez = new PartidaDeXadrez();

                while (!partidaDeXadrez.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partidaDeXadrez.tab);

                    Console.WriteLine();               
                    Console.Write("Origem: ");
                    Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();

                    bool[,] posicoesPossiveis = partidaDeXadrez.tab.Peca(origem).MovimentosPossiveis();
                    
                    Console.Clear();
                    Tela.imprimirTabuleiro(partidaDeXadrez.tab,posicoesPossiveis);

                    Console.Write("Destino: ");
                    Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();

                    partidaDeXadrez.ExecutaMovimento(origem, destino);
                }
                

                
            }catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            PosicaoXadrez pos = new PosicaoXadrez('c', 1);
            Console.WriteLine();
            Console.WriteLine(pos);

            string teste = pos.ToPosicao().ToString();
            Console.WriteLine(teste);

            Console.ReadLine();

        }
    }
}