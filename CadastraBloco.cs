namespace _4s_1b_trabalho_lp1;

public class CadastraBloco
{
    //Retorna um objeto Bloco com os atributos escritos pelo usuário.
    //Utiliza funções da classe Uteis para impedir entrada incorreta
    //de dados.
    public static Bloco CadastrarBloco()
    {
        string codigoDoBloco;
        do
        {
            codigoDoBloco = Util.ObterString("Digite o codigo do bloco: ");
        } 
        while (CodigoJaExiste(Menu.blocos, codigoDoBloco));        
            
        int numero = Util.ObterInt("Digite o numero do bloco: ");
        double medidaMetroCubico = Util.ObterDouble("Digite a medida do bloco (m^3): ");
        string descricao = Util.ObterString("Digite a descrição do bloco: ");

        string tipoDoMaterial;
        do
        {
            tipoDoMaterial = Util.ObterString("Digite o material do bloco: ");
        } 
        while (MaterialInvalido(tipoDoMaterial));

        double valorDeCompra = Util.ObterDouble("Digite o valor de compra: ");
        double valorDeVenda = Util.ObterDouble("Digite o valor de venda: ");
        string pedreira = Util.ObterString("Digite a pedreira de origem do bloco: ");

        Bloco bloco = new Bloco(codigoDoBloco, numero, medidaMetroCubico, descricao, tipoDoMaterial, valorDeCompra, valorDeVenda, pedreira);

        ExportaDadosDoBloco.SalvarBlocoEmArquivoTxt(bloco);

        return bloco;
    }

    //retorna true caso o código informado no cadastro já exista, e false caso contrário
    private static bool CodigoJaExiste(List<Bloco> blocos, string codigo)
    {
        foreach (Bloco bloco in blocos)
        {
            if (bloco.GetCodigoDoBloco() == codigo)
            {
                Console.WriteLine("O código informado já existe!");
                Thread.Sleep(1500);
                Console.Clear();
                return true;
            }
        }
        return false;
    }

    //retorna true caso o material informado não seja mármore ou granito, e false caso contrário
    private static bool MaterialInvalido (string material)
    {
        if (material.Equals("Mármore", StringComparison.OrdinalIgnoreCase) || material.Equals("Granito", StringComparison.OrdinalIgnoreCase))
        {
            return false;
        }
        else if (material.Equals("Marmore", StringComparison.OrdinalIgnoreCase))
        {
            return false;
        }
        else
        {
            Console.WriteLine("Material inválido. Apenas 'Mármore' ou 'Granito' são permitidos.");
            Thread.Sleep(2000);
            Console.Clear();
            return true;
        }
    }
}
