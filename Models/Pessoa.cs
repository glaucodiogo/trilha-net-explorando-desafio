namespace DesafioProjetoHospedagem.Models;

public class Pessoa
{
    public Pessoa() { }

    public Pessoa(string nome)
    {
        Nome = nome;
        Validar();
    }

    public Pessoa(string nome, string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;
        Validar();
    }

    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

    public override string ToString()
    {
        return NomeCompleto;
    }

    public void  Validar()
    {
        if (string.IsNullOrEmpty(this.Nome))
        {
            throw new ArgumentException("Nome não pode ser nulos ou vazios.");
        }
    }
}