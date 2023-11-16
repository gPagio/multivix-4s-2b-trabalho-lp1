using _4s_1b_trabalho_lp1.ExcecoesCustomizadas;

namespace _4s_1b_trabalho_lp1;

public class ListaBlocos
{
    //Recebe uma List<Blocos> e percorre essa lista, mostrando todos os objetos contidos nela.
    //Caso não haja nada, mostra uma mensagem de aviso.
    public static void ListarBlocos(List<Bloco> blocos)
    {
        try
        {
            if (blocos.Count == 0)
            {
                throw new ListaDeBlocosVaziaException();
            }

            foreach (Bloco bloco in blocos)
            {
                Console.WriteLine(Util.DadosDoBloco(bloco));
            }
        }
        catch (ListaDeBlocosVaziaException ex)
        {
            Console.WriteLine(ex.Message);
            Thread.Sleep(1500);
            return;
        }

        Console.Write("Fim da lista de blocos. Pressione qualquer tecla...");
        Console.ReadKey();
        Console.Clear();
    }
}
