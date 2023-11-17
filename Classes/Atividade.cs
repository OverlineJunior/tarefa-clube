namespace TarefaClube.Classes;

internal class Atividade(
    string nome,
    Espaco espaco,
    Socio responsavel,
    Pessoa[] convidados,
    decimal valor,
    string dataInicio,
    string horaInicio,
    string dataFim,
    string horaFim
)
{
    public string Nome { get; } = nome;
    public Espaco Espaco_ { get; } = espaco;
    public Socio Responsavel { get; } = responsavel;
    public Pessoa[] Convidados { get; set; } = convidados;
    public decimal Valor { get; } = valor;
    public string DataInicio { get; } = dataInicio;
    public string HoraInicio { get; } = horaInicio;
    public string DataFim { get; } = dataFim;
    public string HoraFim { get; } = horaFim;
}
