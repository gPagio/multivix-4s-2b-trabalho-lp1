namespace _4s_1b_trabalho_lp1;

public class ExportaDadosDoBloco
{
    public static void SalvarBlocoEmArquivoTxt (Bloco bloco)
    {
        string diretorioDoExecutavel = Directory.GetCurrentDirectory();
        string diretorioDoProjeto = Directory.GetParent(diretorioDoExecutavel)!.Parent!.Parent!.FullName;
       
        if (!Directory.Exists(Path.Combine(diretorioDoProjeto, "txt")))
        {
            Directory.CreateDirectory(Path.Combine(diretorioDoProjeto, "txt"));
        }

        string caminhoDoArquivo = Path.Combine(diretorioDoProjeto, "txt", "blocos.txt");
        StreamWriter sw = new StreamWriter(caminhoDoArquivo, true);
        
        try
        {    
            sw.WriteLine(Util.DadosDoBloco(bloco));   
        }
        catch (Exception)
        {
            Console.WriteLine("Não foi possível transferir os dados do bloco para o arquivo .txt!");
        }
        finally
        {
            sw.Close();
        }
    }
}
