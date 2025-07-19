using System.Text;

namespace Models;

public class Senha
{

    public int Tamanho { get; set; }
    public bool IncluirMaiusculas { get; set; }
    public bool IncluirNumeros { get; set; }
    public bool IncluirEspeciais { get; set; }

    private const string LetrasMinusculas = "abcdefghijklmnopqrstuvwxyz";
    private const string LetrasMaiusculas = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private const string Numeros = "0123456789";
    private const string Especiais = "!@#$%&*?";
    private readonly Random _random = new Random();

    public Senha(int tamanho, bool incluirMaiusculas, bool incluirNumeros, bool incluirEspeciais)
    {
        Tamanho = tamanho;
        IncluirMaiusculas = incluirMaiusculas;
        IncluirNumeros = incluirNumeros;
        IncluirEspeciais = incluirEspeciais;
    }

    public string Gerar()
    {
        string conjuntoCaracteres = LetrasMinusculas;
        var senha = new StringBuilder();
        if (IncluirMaiusculas) conjuntoCaracteres += LetrasMaiusculas;
        if (IncluirNumeros) conjuntoCaracteres += Numeros;
        if (IncluirEspeciais) conjuntoCaracteres += Especiais;

        if (string.IsNullOrEmpty(conjuntoCaracteres))
        {
            throw new InvalidOperationException("Nenhum tipo de caractere selecionado");
        }

        for (int i = 0; i < Tamanho; i++)
        {
            int indice = _random.Next(conjuntoCaracteres.Length);
            senha.Append(conjuntoCaracteres[indice]);
        }

        return senha.ToString();


    }


}