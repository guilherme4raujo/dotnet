using System;

public enum TipoTriangulo
{
    Equilatero,
    Isosceles,
    Escaleno
}

public class Triangulo
{
    // Propriedades para os vértices do triângulo
    public Vertice Vertice1 { get; private set; }
    public Vertice Vertice2 { get; private set; }
    public Vertice Vertice3 { get; private set; }

    // Construtor que inicializa os vértices e verifica se formam um triângulo válido
    public Triangulo(Vertice v1, Vertice v2, Vertice v3)
    {
        Vertice1 = v1;
        Vertice2 = v2;
        Vertice3 = v3;

        if (!FormaTriangulo())
            throw new ArgumentException("Os vértices fornecidos não formam um triângulo.");
    }

    // Método que verifica se os três vértices formam um triângulo válido
    private bool FormaTriangulo()
    {
        double a = Vertice1.Distancia(Vertice2);
        double b = Vertice2.Distancia(Vertice3);
        double c = Vertice3.Distancia(Vertice1);

        return a + b > c && a + c > b && b + c > a;
    }

    // Método para verificar se dois triângulos são iguais
    public bool EhIgual(Triangulo outro)
    {
        return Vertice1.EhIgual(outro.Vertice1) && Vertice2.EhIgual(outro.Vertice2) && Vertice3.EhIgual(outro.Vertice3);
    }

    // Propriedade Perimetro para calcular o perímetro do triângulo
    public double Perimetro
    {
        get
        {
            double a = Vertice1.Distancia(Vertice2);
            double b = Vertice2.Distancia(Vertice3);
            double c = Vertice3.Distancia(Vertice1);
            return a + b + c;
        }
    }

    // Propriedade Tipo para identificar o tipo do triângulo (equilátero, isósceles, escaleno)
    public TipoTriangulo Tipo
    {
        get
        {
            double a = Vertice1.Distancia(Vertice2);
            double b = Vertice2.Distancia(Vertice3);
            double c = Vertice3.Distancia(Vertice1);

            if (a == b && b == c)
                return TipoTriangulo.Equilatero;
            else if (a == b || b == c || a == c)
                return TipoTriangulo.Isosceles;
            else
                return TipoTriangulo.Escaleno;
        }
    }

    // Propriedade Area para calcular a área do triângulo usando a fórmula de Herão
    public double Area
    {
        get
        {
            double a = Vertice1.Distancia(Vertice2);
            double b = Vertice2.Distancia(Vertice3);
            double c = Vertice3.Distancia(Vertice1);
            double s = Perimetro / 2;

            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
    }
}
