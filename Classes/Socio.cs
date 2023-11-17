namespace TarefaClube.Classes;

internal enum TipoSocio
{
    Fundador,
    Proprietario,
    Cotista,
    Voluntario,
}

internal class Socio(
    string nome,
    string celular,
    string email,
    string dataNascimento,
    string endereco,
    string complemento,
    string cidade,
    string rg,
    string cep,
    TipoSocio tipo,
    Dependente[] dependentes
) : Pessoa(nome, celular, email, dataNascimento, endereco, complemento, cidade, rg, cep)
{
    public TipoSocio Tipo { get; } = tipo;
    public Dependente[] Dependentes { get; set; } = dependentes;
}
