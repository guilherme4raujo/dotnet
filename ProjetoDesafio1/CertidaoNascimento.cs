using System;

public class CertidaoNascimento
{
    // Propriedades
    public DateTime DataEmissao { get; }
    public Pessoa PessoaAssociada { get; }

    // Construtor para inicializar a data de emissão e a pessoa associada
    public CertidaoNascimento(DateTime dataEmissao, Pessoa pessoa)
    {
        DataEmissao = dataEmissao;
        PessoaAssociada = pessoa ?? throw new ArgumentNullException(nameof(pessoa), "Uma certidão deve estar associada a uma pessoa.");
    }
}
