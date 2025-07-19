using Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Gerador de Senhas Aleatórias");

        Console.Write("Digite o tamanho da senha: ");

        int tamanho = int.Parse(Console.ReadLine() ?? "8");

        Console.Write("Incluir letras maiúsculas? (s/n): ");
        bool incluirMaiusculas = Console.ReadLine()?.Trim().ToLower() == "s";

        Console.Write("Incluir números? (s/n): ");
        bool incluirNumeros = Console.ReadLine()?.Trim().ToLower() == "s";

        Console.Write("Incluir caracteres especiais? (s/n): ");
        bool incluirEspeciais = Console.ReadLine()?.Trim().ToLower() == "s";

        Senha senha = new Senha(tamanho, incluirMaiusculas, incluirNumeros, incluirEspeciais);

        string senhaGerada = senha.Gerar();

        Console.WriteLine($"\n Sua senha gerada: {senhaGerada}");
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}