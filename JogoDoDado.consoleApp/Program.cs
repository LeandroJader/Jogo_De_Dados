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
