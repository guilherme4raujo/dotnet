using System;
using System.Globalization;
using System.Text.RegularExpressions;

public class ValidacaoDadosCliente
{
    public static void Main()
    {
        string nome = SolicitarNome();
        string cpf = SolicitarCPF();
        DateTime dataNascimento = SolicitarDataNascimento();
        float rendaMensal = SolicitarRendaMensal();
        char estadoCivil = SolicitarEstadoCivil();
        int dependentes = SolicitarDependentes();

        Console.WriteLine("\nDados do Cliente:");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"CPF: {cpf}");
        Console.WriteLine($"Data de Nascimento: {dataNascimento:dd/MM/yyyy}");
        Console.WriteLine($"Renda Mensal: R$ {rendaMensal:F2}");
        Console.WriteLine($"Estado Civil: {estadoCivil}");
        Console.WriteLine($"Dependentes: {dependentes}");
    }

    public static string SolicitarNome()
    {
        while (true)
        {
            Console.Write("Digite o nome (mínimo 5 caracteres): ");
            string nome = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(nome) && nome.Length >= 5)
                return nome;
            Console.WriteLine("Erro: O nome deve ter pelo menos 5 caracteres.");
        }
    }

    public static string SolicitarCPF()
    {
        while (true)
        {
            Console.Write("Digite o CPF (somente números): ");
            string cpf = Console.ReadLine();

            // Validação básica do CPF
            if (Regex.IsMatch(cpf, @"^\d{11}$") && ValidarCPF(cpf))
                return cpf;

            Console.WriteLine("Erro: CPF inválido. O CPF deve conter 11 dígitos numéricos.");
        }
    }

    public static DateTime SolicitarDataNascimento()
    {
        while (true)
        {
            Console.Write("Digite a data de nascimento (DD/MM/AAAA): ");
            string entrada = Console.ReadLine();

            if (DateTime.TryParseExact(entrada, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataNascimento))
            {
                int idade = DateTime.Now.Year - dataNascimento.Year;
                if (dataNascimento > DateTime.Now.AddYears(-idade)) idade--; // Ajuste para idade

                if (idade >= 18)
                    return dataNascimento;

                Console.WriteLine("Erro: O cliente deve ter pelo menos 18 anos.");
            }
            else
            {
                Console.WriteLine("Erro: A data de nascimento deve estar no formato DD/MM/AAAA.");
            }
        }
    }

    public static float SolicitarRendaMensal()
    {
        while (true)
        {
            Console.Write("Digite a renda mensal (ex: 1234,56): ");
            string entrada = Console.ReadLine().Replace(".", ",");

            if (float.TryParse(entrada, NumberStyles.AllowDecimalPoint, CultureInfo.CurrentCulture, out float renda) && renda >= 0)
                return (float)Math.Round(renda, 2);

            Console.WriteLine("Erro: A renda mensal deve ser um valor decimal positivo com duas casas decimais.");
        }
    }

    public static char SolicitarEstadoCivil()
    {
        while (true)
        {
            Console.Write("Digite o estado civil (C, S, V, D): ");
            string entrada = Console.ReadLine().ToUpper();

            if (entrada.Length == 1 && "CSVDC".Contains(entrada[0]))
                return entrada[0];

            Console.WriteLine("Erro: Estado civil inválido. Use C, S, V ou D.");
        }
    }

    public static int SolicitarDependentes()
    {
        while (true)
        {
            Console.Write("Digite o número de dependentes (0 a 10): ");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out int dependentes) && dependentes >= 0 && dependentes <= 10)
                return dependentes;

            Console.WriteLine("Erro: O número de dependentes deve ser um inteiro entre 0 e 10.");
        }
    }

    
    public static bool ValidarCPF(string cpf)
    {
        
        if (new string(cpf[0], cpf.Length) == cpf)
            return false;

        // Lógica de validação dos dígitos verificadores do CPF (apenas exemplo simples)
        int[] multiplicadores1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        int[] multiplicadores2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

        string tempCpf = cpf.Substring(0, 9);
        int soma = 0;

        for (int i = 0; i < 9; i++)
            soma += int.Parse(tempCpf[i].ToString()) * multiplicadores1[i];

        int resto = soma % 11;
        int digito1 = resto < 2 ? 0 : 11 - resto;

        tempCpf += digito1;
        soma = 0;

        for (int i = 0; i < 10; i++)
            soma += int.Parse(tempCpf[i].ToString()) * multiplicadores2[i];

        resto = soma % 11;
        int digito2 = resto < 2 ? 0 : 11 - resto;

        return cpf.EndsWith(digito1.ToString() + digito2.ToString());
    }
}
