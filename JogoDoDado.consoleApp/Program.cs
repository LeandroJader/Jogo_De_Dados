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
                int PosicaoComputador = 0;
             bool jogoEmAndamento = true;

                while (jogoEmAndamento){




                    Console.Clear();
                    Console.WriteLine("===========================");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Jogo De Dados");
                    Console.ResetColor();
                    Console.WriteLine("===========================");

                    Console.WriteLine("Rodada do usuário");
                    Console.WriteLine("===========================");



                    Console.WriteLine("aperte ENTER para jogar o dado ");
                    Console.ReadLine();



                    int resultadoJogador = sortearDado();

                    Console.WriteLine("===========================");
                    Console.WriteLine($"O numero sorteado foi {resultadoJogador}");

                    posicaoJogador += resultadoJogador;
                    Console.WriteLine($"voce esta na posicao {posicaoJogador} de {limiteLinhaDeChegada}");
                   
                        if (posicaoJogador == 5 || posicaoJogador == 10|| posicaoJogador==15 || posicaoJogador == 25)
                    {
                        Console.WriteLine("===========================");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("EVENTO ESÉCIAL: avanço extra de 3 casas ");
                        Console.ResetColor();

                        posicaoJogador += 3;
                        Console.WriteLine($"você avançou para posição {posicaoJogador}");
                    }
                    else if (posicaoJogador==7 || posicaoJogador == 13 || posicaoJogador == 20)
                    {
                        Console.WriteLine("===========================");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("EVENTO ESÉCIAL: recuo de 2 casas ");
                        Console.ResetColor();

                        posicaoJogador -= 2;
                        Console.WriteLine($"você recuou para posição {posicaoJogador}");

                    }

                    if (posicaoJogador >= limiteLinhaDeChegada)
                    {
                        jogoEmAndamento = false;
                        Console.WriteLine("===========================");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("parabens voce chegou a linha de chegada ");
                        Console.ResetColor();
                        Console.WriteLine("===========================");
                        continue;
                    }



                    Console.WriteLine("\n================================");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("precione ENTER para vizualizar a rodada do computador ");
                    Console.ResetColor();
                    Console.ReadLine();

                    int resultadoComputador = sortearDado();

                    Console.WriteLine("===========================");
                    Console.WriteLine($"O numero sorteado foi {resultadoComputador}");

                    PosicaoComputador += resultadoComputador;



                    Console.WriteLine($"O computador esta na posicao {PosicaoComputador} de {limiteLinhaDeChegada}");

                    if (PosicaoComputador == 5 || PosicaoComputador == 10 || PosicaoComputador == 15 || PosicaoComputador == 25)
                    {
                        Console.WriteLine("===========================");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("EVENTO ESÉCIAL: avanço extra de 3 casas ");
                        Console.ResetColor();

                        PosicaoComputador += 3;
                        Console.WriteLine($"você avançou para posição {PosicaoComputador}");
                    }
                    else if (PosicaoComputador == 7 || PosicaoComputador == 13 || PosicaoComputador == 20)
                    {
                        Console.WriteLine("===========================");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("EVENTO ESÉCIAL: recuo de 2 casas ");
                        Console.ResetColor();

                        PosicaoComputador -= 2;
                        Console.WriteLine($"você recuou para posição {PosicaoComputador}");

                    }
                    if (PosicaoComputador >= limiteLinhaDeChegada)
                    {
                        jogoEmAndamento = false;
                        Console.WriteLine("===========================");
                        Console.WriteLine("parabens voce chegou a linha de chegada ");
                        Console.WriteLine("===========================");
                        continue;
                    }
                    if (PosicaoComputador >= limiteLinhaDeChegada)
                    {
                        jogoEmAndamento = false;
                        Console.WriteLine("===========================");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" Que pena ! o computador alcançou a linha de chegada ");
                        Console.ResetColor();
                        Console.WriteLine("===========================");

                        continue;
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
        static int sortearDado()
        {
            Random gerador_de_numeros = new Random();

            int resultado = gerador_de_numeros.Next(1, 7);

            return resultado;

        }
    }
}
