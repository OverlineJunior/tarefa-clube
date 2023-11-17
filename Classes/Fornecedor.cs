namespace TarefaClube.Classes;

internal class Fornecedor(
    string nome,
    string celular,
    string email,
    string dataNascimento,
    string endereco,
    string complemento,
    string cidade,
    string rg,
    string cep,
    string razaoSocial
) : Pessoa(nome, celular, email, dataNascimento, endereco, complemento, cidade, rg, cep)
{
    public string RazaoSocial { get; } = razaoSocial;
}
