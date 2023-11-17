namespace TarefaClube.Classes;

internal class Espaco(
    string nome,
    string tamanho,
    string dataConstrucao,
    int capacidade,
    bool locavel
)
{
    public string Nome { get; } = nome;
    public string Tamanho { get; } = tamanho;
    public string DataConstrucao { get; } = dataConstrucao;
    public int Capacidade { get; } = capacidade;
    public bool Locavel { get; } = locavel;
}
