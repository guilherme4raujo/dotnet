using System;

public class Intervalo
{
    // Propriedades de data/hora inicial e final 
    public DateTime DataHoraInicial { get; }
    public DateTime DataHoraFinal { get; }

    // Construtor para inicializar a data/hora inicial e final do intervalo
    public Intervalo(DateTime dataHoraInicial, DateTime dataHoraFinal)
    {
        if (dataHoraInicial > dataHoraFinal)
            throw new ArgumentException("A data/hora inicial não pode ser posterior à data/hora final.");

        DataHoraInicial = dataHoraInicial;
        DataHoraFinal = dataHoraFinal;
    }

    // Método que verifica se dois intervalos possuem interseção
    public bool TemIntersecao(Intervalo outro)
    {
        return DataHoraInicial < outro.DataHoraFinal && DataHoraFinal > outro.DataHoraInicial;
    }

    // Método para verificar se dois intervalos são exatamente iguais
    public bool EhIgual(Intervalo outro)
    {
        return DataHoraInicial == outro.DataHoraInicial && DataHoraFinal == outro.DataHoraFinal;
    }

    // Propriedade Duracao que retorna a duração do intervalo como TimeSpan
    public TimeSpan Duracao => DataHoraFinal - DataHoraInicial;
}
