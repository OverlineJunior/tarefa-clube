namespace TarefaClube.Classes;

internal class Pessoa(
    string nome,
    string celular,
    string email,
    string dataNascimento,
    string endereco,
    string complemento,
    string cidade,
    string rg,
    string cep
)
{
    public string Nome { get; } = nome;
    public string Celular { get; } = celular;
    public string Email { get; } = email;
    public string DataNascimento { get; } = dataNascimento;
    public string Endereco { get; } = endereco;
    public string Complemento { get; } = complemento;
    public string Cidade { get; } = cidade;
    public string RG { get; } = rg;
    public string CEP { get; } = cep;
}
