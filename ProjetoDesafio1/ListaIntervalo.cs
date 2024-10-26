using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

public class ListaIntervalo
{
    // Lista interna para armazenar os intervalos
    private List<Intervalo> intervalos;

    
    public ListaIntervalo()
    {
        intervalos = new List<Intervalo>();
    }

    public bool Add(Intervalo novoIntervalo)
    {
        // Verifica se o novo intervalo tem interseção com algum intervalo existente
        foreach (var intervalo in intervalos)
        {
            if (intervalo.TemIntersecao(novoIntervalo))
                return false; // Retorna false se houver interseção
        }

        // Adiciona o intervalo se não houver interseção
        intervalos.Add(novoIntervalo);
        return true; // Retorna true indicando que o intervalo foi adicionado com sucesso
    }

    // Propriedade que retorna uma lista imutável de intervalos, ordenada por data/hora inicial
    public ReadOnlyCollection<Intervalo> Intervalos
    {
        get
        {
            return intervalos
                .OrderBy(intervalo => intervalo.DataHoraInicial) // Ordena por DataHoraInicial
                .ToList()
                .AsReadOnly(); // Retorna como uma lista somente leitura
        }
    }
}
