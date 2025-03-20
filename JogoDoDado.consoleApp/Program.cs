namespace JogoDoDado.consoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int limiteLinhaDeChegada = 30;


            while (true)
            {
             int posicaoJogador = 0;
             bool jogoEmAndamento = true;

                while (jogoEmAndamento){




                    Console.Clear();
                    Console.WriteLine("==============");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Jogo De Dados");
                    Console.ResetColor();
                    Console.WriteLine("===========================");

                    Console.WriteLine("aperte ENTER para jogar o dado ");
                    Console.ReadLine();

                    Random gerador_de_numeros = new Random();

                    int Numero_gerado = gerador_de_numeros.Next(1, 7);

                    Console.WriteLine("==========================");
                    Console.WriteLine($"O numero sorteado foi {Numero_gerado}");

                    posicaoJogador += Numero_gerado;


                    Console.WriteLine($"voce esta na posicao {posicaoJogador} de {limiteLinhaDeChegada}");
                   
                        if (posicaoJogador==5 || posicaoJogador == 10|| posicaoJogador==15 || posicaoJogador==25)
                    {
                        Console.WriteLine("=======================");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("EVENTO ESÉCIAL: avanço extra de 3 casas ");
                        Console.ResetColor();

                        posicaoJogador += 3;
                        Console.WriteLine($"você avançou para posição {posicaoJogador}");
                    }
                    else if (posicaoJogador==7 || posicaoJogador==13 || posicaoJogador == 20)
                    {
                        Console.WriteLine("=======================");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("EVENTO ESÉCIAL: recuo de 2 casas ");
                        Console.ResetColor();

                        posicaoJogador -= 2;
                        Console.WriteLine($"você recuou para posição {posicaoJogador}");

                    }



                    if (posicaoJogador >= limiteLinhaDeChegada)
                    {
                        jogoEmAndamento = false;
                        Console.WriteLine("=================");
                        Console.WriteLine("parabens voce chegou a linha de chegada ");
                        Console.WriteLine("==================");
                    }
  
                    
                      
                        Console.ReadLine();
                    

                }
                        Console.WriteLine("você deseja continuar jogando s/n");
                    string continuar = (Console.ReadLine())!.ToUpper();
                    if (continuar != "S")
                    {
                        break;
                    }

                }
            
        }
    }
}
