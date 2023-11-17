namespace TarefaClube.Classes;

internal enum TipoVinculo { Pai, Mae, Filho, Filha }

internal class Dependente(
    string nome,
    string celular,
    string email,
    string dataNascimento,
    string endereco,
    string complemento,
    string cidade,
    string rg,
    string cep,
    TipoVinculo vinculo
) : Pessoa(nome, celular, email, dataNascimento, endereco, complemento, cidade, rg, cep)
{
    public TipoVinculo Vinculo { get; } = vinculo;
}
