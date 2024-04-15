using System.Text.Json;

namespace Teste.Modelos;
internal class Pessoa
{
    public Pessoa(string nome, int idade, string email)
    {
        Nome = nome;
        Idade = idade;
        Email = email;
    }

    public string Nome { get; }
    public int Idade { get; }
    public string Email { get; }
}



