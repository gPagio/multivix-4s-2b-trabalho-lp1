class Util
{
    //função utilizada para impedir entrada de quaisquer dados que não sejam do tipo int
    public static int ObterInt(string mensagem)
    {
        string resposta;
        int resultado;

        while (true)
        {
            Console.Write(mensagem);
            resposta = Console.ReadLine()!;

            if (int.TryParse(resposta, out resultado) && resultado > 0)
            {
                break;
            }

            Console.Write("Entrada inválida de dados!\n");
            Thread.Sleep(1500);
            //Console.Clear();
        }

        return resultado;
    }

    //função utilizada para impedir entrada de quaisquer dados que não sejam do tipo double
    public static double ObterDouble(string mensagem)
    {
        string resposta;
        double resultado;

        while (true)
        {
            Console.Write(mensagem);
            resposta = Console.ReadLine()!;

            if (double.TryParse(resposta, out resultado) && resultado > 0)
            {
                break;
            }

            Console.Write("Entrada inválida de dados!");
            Thread.Sleep(1500);
            Console.Clear();
        }

        return resultado;
    }

    //função utilizada para impedir entrada de strings vazias
    public static string ObterString(string mensagem)
    {
        string resultado;

        while (true)
        {
            Console.Write(mensagem);
            resultado = Console.ReadLine()!;

            if (!string.IsNullOrEmpty(resultado))
            {
                break;
            }

            Console.Write("Entrada inválida de dados!");
            Thread.Sleep(1500);
            Console.Clear();
        }

        return resultado;
    }

    //imprime os dados do bloco de forma organizada e formatada
    public static string DadosDoBloco (Bloco bloco)
    {   
        return $"{"Código:".PadRight(25)} {bloco.GetCodigoDoBloco()} \n" +
               $"{"Número:".PadRight(25)} {bloco.GetNumero()} \n" +
               $"{"Medida (M³):".PadRight(25)} {bloco.GetMedidaMetroCubico()} \n" +
               $"{"Descrição:".PadRight(25)} {bloco.GetDescricao()} \n" +
               $"{"Material:".PadRight(25)} {bloco.GetTipoDoMaterial()} \n" +
               $"{"Valor de compra:".PadRight(25)} {bloco.GetValorDeCompra().ToString("C")} \n" +
               $"{"Valor de venda:".PadRight(25)} {bloco.GetValorDeVenda().ToString("C")} \n" +
               $"{"Pedreira de origem:".PadRight(25)} {bloco.GetPedreira()} \n";
    }

    //retorna true se não houver blocos na lista, e false se houver
    public static bool NaoHaBlocos (List <Bloco> blocos)
    {
        if (blocos.Count == 0)
        {
            Console.WriteLine("Não há blocos cadastrados!");
            Thread.Sleep(1500);
            return true;
        }
        return false;
    }
}