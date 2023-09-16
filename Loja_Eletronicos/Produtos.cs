public class Produtos
{
    public string Id { get; set; }
    public string Nome { get; set; }
    public double Valor { get; set; }
    public string DataFabr { get; set; }
    public int Quantidade { get; set; }
    public Produtos(string id, string nome, double valor, string dataFabr, int quantidade)
    {
        Id = id;
        Nome = nome;
        Valor = valor;
        DataFabr = dataFabr;
        Quantidade = quantidade;
    }
    public Produtos()
    {

    }
}