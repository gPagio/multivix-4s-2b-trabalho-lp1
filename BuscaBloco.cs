using _4s_1b_trabalho_lp1.exceptions;

namespace _4s_1b_trabalho_lp1;

public class BuscaBloco 
{
    //Percorre a lista de blocos, imprimindo o bloco com o código informado. Mostra mensagem de erro caso a lista esteja vazia
    //ou o código informado não exista na lista
    public static void BuscarBlocoPorCodigo(List<Bloco> blocos)
    {
        string codigo;
        bool codigoExiste;

        try
        {
            if (blocos.Count == 0)
            {
                throw new ListaDeBlocosVaziaException();
            }

            codigo = Util.ObterString("Digite o código do bloco a ser buscado: ");
            Console.Clear();

            codigoExiste = false;

            foreach (Bloco bloco in blocos)
            {
                if (codigo == bloco.GetCodigoDoBloco())
                {
                    Console.WriteLine(Util.DadosDoBloco(bloco));
                    Console.Write("Pressione qualquer tecla...");
                    Console.ReadKey();
                    codigoExiste = true;
                    break;
                }
            }

            if (!codigoExiste)
            {
                throw new CodigoNaoExisteException();  
            }
            Console.Clear();
        }
        catch (ListaDeBlocosVaziaException ex)
        {
            Console.WriteLine(ex.Message);
            Thread.Sleep(1500);
            return;
        }
        catch(CodigoNaoExisteException ex)
        {
            Console.WriteLine(ex.Message);
            Thread.Sleep(1500);
            return;
        }    
    }
}
