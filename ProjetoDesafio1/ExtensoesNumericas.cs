using System;
using System.Linq;

public static class ExtensoesNumericas
{
    // Método de extensão para verificar se um número é de Armstrong
    public static bool IsArmstrong(this int numero)
    {
        // Converte o número para uma string e conta os dígitos
        string numeroStr = numero.ToString();
        int numeroDigitos = numeroStr.Length;

        // Calcula a soma de cada dígito elevado à potência do número de dígitos
        int soma = numeroStr
            .Select(digito => (int)Math.Pow(char.GetNumericValue(digito), numeroDigitos))
            .Sum();

        // Verifica se a soma é igual ao número original
        return soma == numero;
    }
}
