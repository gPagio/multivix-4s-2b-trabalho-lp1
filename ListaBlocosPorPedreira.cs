using _4s_1b_trabalho_lp1.exceptions;

namespace _4s_1b_trabalho_lp1;

public class ListaBlocosPorPedreira
{   
    //Percorre a lista de blocos, imprimindo os blocos origindos na pedreira informada. Mostra mensagem de erro caso a lista esteja vazia
    //ou a pedreira informada não exista na lista
    public static void ListarBlocosPorPedreira(List<Bloco> blocos)
    {
        try
        {
            if (blocos.Count == 0)
            {
                throw new ListaDeBlocosVaziaException();
            }

            string pedreira = Util.ObterString("Digite a pedreira de origem para listar os blocos: ");
            Console.Clear();

            bool pedreiraExiste = false;

            foreach (Bloco bloco in blocos)
            {
                if (pedreira == bloco.GetPedreira())
                {
                    Console.WriteLine(Util.DadosDoBloco(bloco));
                    pedreiraExiste = true;
                }
            }

            if (!pedreiraExiste)
            {
                throw new PedreiraNaoListadaException();
            }

        }
        catch(ListaDeBlocosVaziaException ex)
        {
            Console.WriteLine(ex.Message);
            Thread.Sleep(1500);
            return;
        }
        catch (PedreiraNaoListadaException ex)
        {
            Console.WriteLine(ex.Message);
            Thread.Sleep(1500);
            return;
        }

        Console.Write("Pressione qualquer tecla...");
        Console.ReadKey();
        Console.Clear();
    }
}
