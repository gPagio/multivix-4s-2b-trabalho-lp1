using _4s_1b_trabalho_lp1;

public class Menu{
    public static List<Bloco> blocos = new();
    public static void Main(String[] args)
    {
        bool rodarPrograma = true;

        do
        {
            int opcao;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Bem vindo ao Gerenciador de Blocos.\n");
                Console.WriteLine("1 - Cadastrar bloco");
                Console.WriteLine("2 - Listar blocos");
                Console.WriteLine("3 - Buscar bloco por código");
                Console.WriteLine("4 - Listar blocos por pedreira");
                Console.WriteLine("5 - Sair");
                opcao = Util.ObterInt("\nSelecione uma opção: ");

                if (opcao > 0 && opcao < 6)    //caso a opção seja válida, sai do loop
                {
                    Console.Clear();
                    break;
                }

                Console.Write("Opção inválida!");
                Thread.Sleep(1500); 
            }

            try
            {
                switch (opcao)
                {
                    case 1:
                        blocos.Add(CadastraBloco.CadastrarBloco());
                        Console.WriteLine("Bloco cadastrado com sucesso!");
                        Thread.Sleep(1500);
                        Console.Clear();
                        break;
                    case 2:
                        ListaBlocos.ListarBlocos(blocos);
                        break;
                    case 3:
                        BuscaBloco.BuscarBlocoPorCodigo(blocos);
                        break;
                    case 4:
                        ListaBlocosPorPedreira.ListarBlocosPorPedreira(blocos);
                        break;
                    case 5:
                        rodarPrograma = false;
                        break;
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Ocorreu um erro na execução do programa!");
                rodarPrograma = false;
            }

        } while (rodarPrograma);
    }
}