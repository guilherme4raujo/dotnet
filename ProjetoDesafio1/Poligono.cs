using System;
using System.Collections.Generic;
using System.Linq;

public class Poligono
{
    // Lista de vértices do polígono
    private List<Vertice> vertices;

    // Propriedade para a quantidade de vértices (leitura pública)
    public int QuantidadeVertices => vertices.Count;

    // Construtor que inicializa os vértices do polígono
    public Poligono(List<Vertice> verticesIniciais)
    {
        if (verticesIniciais.Count < 3)
            throw new ArgumentException("O polígono deve ter pelo menos 3 vértices.");

        vertices = new List<Vertice>();

        foreach (var vertice in verticesIniciais)
        {
            AddVertice(vertice); // Adiciona os vértices iniciais, evitando duplicatas
        }
    }

    // Método para adicionar um novo vértice, retorna false se o vértice já existe
    public bool AddVertice(Vertice v)
    {
        if (vertices.Any(vertice => vertice.EhIgual(v)))
            return false;

        vertices.Add(v);
        return true;
    }

    // Método para remover um vértice do polígono
    public void RemoveVertice(Vertice v)
    {
        if (vertices.Count <= 3)
            throw new InvalidOperationException("O polígono deve ter pelo menos 3 vértices.");

        vertices.RemoveAll(vertice => vertice.EhIgual(v));
    }

    // Método para calcular o perímetro do polígono
    public double Perimetro()
    {
        double perimetro = 0.0;

        for (int i = 0; i < vertices.Count; i++)
        {
            Vertice atual = vertices[i];
            Vertice proximo = vertices[(i + 1) % vertices.Count]; // O próximo vértice ou o primeiro

            perimetro += atual.Distancia(proximo);
        }

        return perimetro;
    }
}


