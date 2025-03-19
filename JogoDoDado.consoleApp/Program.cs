namespace JogoDoDado.consoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("==============");
                Console.WriteLine("Jogo De Dados");           
                Console.WriteLine("==============");

                Console.WriteLine("aperte ENTER para jogar o dado ");
                Console.ReadLine();

                Random gerador_de_numeros = new Random();
                
                int Numero_gerado = gerador_de_numeros.Next(1, 7);

                Console.WriteLine($" O numero sorteado foi {Numero_gerado}");
                
                Console.WriteLine("voce deseja sair do jogo s/n");
                string continuar =(Console.ReadLine())!.ToUpper();
                if (continuar != "S")
                {
                    break;
                }
                    }

        }
    }
}
