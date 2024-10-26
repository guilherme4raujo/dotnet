using System;

public class Pessoa
{
    // Propriedades
    public string Nome { get; }
    public CertidaoNascimento Certidao { get; private set; }

    // Construtor para inicializar o nome da pessoa
    public Pessoa(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome))
            throw new ArgumentException("O nome é obrigatório.", nameof(nome));

        Nome = nome;
    }

    // Método para associar uma certidão de nascimento à pessoa 
    public void RegistrarCertidao(CertidaoNascimento certidao)
    {
        if (Certidao != null)
            throw new InvalidOperationException("A pessoa já possui uma certidão de nascimento associada.");

        if (certidao.PessoaAssociada != this)
            throw new ArgumentException("A certidão não pertence a esta pessoa.");

        Certidao = certidao;
    }
}
