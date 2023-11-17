public class Bloco {
    private string codigoDoBloco;   
    private int numero;            
    private double medidaMetroCubico;
    private string descricao;
    private string tipoDoMaterial;
    private double valorDeCompra;
    private double valorDeVenda;
    private string pedreira;

    public Bloco(string codigoDoBloco, int numero, double medidaMetroCubico, string descricao, string tipoDoMaterial, double valoreDeCompra, double valorDeVenda, string pedreira)
    {
        this.codigoDoBloco = codigoDoBloco;
        this.numero = numero;
        this.medidaMetroCubico = medidaMetroCubico;
        this.descricao = descricao;
        this.tipoDoMaterial = tipoDoMaterial;
        this.valorDeCompra = valoreDeCompra;
        this.valorDeVenda = valorDeVenda;
        this.pedreira = pedreira;
    }

    public string GetCodigoDoBloco()
    {
        return this.codigoDoBloco;
    }

    public int GetNumero()
    {    
        return this.numero;
    }

    public double GetMedidaMetroCubico()
    {
        return this.medidaMetroCubico;
    }

    public string GetDescricao()
    {
        return this.descricao;
    }

    public string GetTipoDoMaterial()
    {
        return this.tipoDoMaterial;
    }

    public double GetValorDeCompra()
    {
        return this.valorDeCompra;
    }

    public double GetValorDeVenda()
    {
        return this.valorDeVenda;
    }

    public string GetPedreira()
    {
        return this.pedreira;
    }

    public void SetCodigoDoBloco(string codigoDoBloco)
    {
        this.codigoDoBloco = codigoDoBloco;
    }

    public void SetNumero(int numero)
    { 
        this.numero = numero;
    }

    public void SetMedidaMetroCubico(double medidaMetroCubico)
    {
        this.medidaMetroCubico = medidaMetroCubico;
    }

    public void SetDescricao(string descricao)
    {
        this.descricao = descricao;
    }

    public void SetTipoDoMaterial(string tipoDoMaterial)
    {
        this.tipoDoMaterial = tipoDoMaterial;
    }

    public void SetValoreDeCompra(double valoreDeCompra)
    {
        this.valorDeCompra = valoreDeCompra;
    }

    public void SetValorDeVenda(double valorDeVenda)
    {
        this.valorDeVenda = valorDeVenda;
    }

    public void SetPedreira(string pedreira)
    {
        this.pedreira = pedreira;
    }
}
