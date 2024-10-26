using System;
using System.Collections.Generic;
using System.Linq;

/*

class Program
{
    static void Main()
    {
        try
        {
            Piramide piramide = new Piramide(4); // Teste com N = 4
            piramide.Desenha();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

*/



/*
class Program
{
    static void Main()
    {
        // Criando os 2 vertices
        Vertice vertice1 = new Vertice(3, 4);
        Vertice vertice2 = new Vertice(6, 8);

        // Teste de distância:
        Console.WriteLine("Distância entre vértice1 e vértice2: " + vertice1.Distancia(vertice2));

        // Método MOVE:
        vertice1.Move(6, 8);
        Console.WriteLine($"Nova posição de vertice1: ({vertice1.X}, {vertice1.Y})");

        // Teste de igualdade entre vértices
        bool saoIguais = vertice1.EhIgual(vertice2);
        Console.WriteLine("Os vértices são iguais? " + (saoIguais ? "Sim" : "Não"));
    }
}
*/

/*
class Program
{
    static void Main()
    {
        Vertice v1 = new Vertice(0, 0);
        Vertice v2 = new Vertice(4, 0);
        Vertice v3 = new Vertice(0, 3);

        try
        {
            Triangulo triangulo = new Triangulo(v1, v2, v3);
            Console.WriteLine("Perímetro do triângulo: " + triangulo.Perimetro);
            Console.WriteLine("Área do triângulo: " + triangulo.Area);
            Console.WriteLine("Tipo do triângulo: " + triangulo.Tipo);

            // Testando igualdade com outro triângulo
            Vertice v4 = new Vertice(0, 0);
            Vertice v5 = new Vertice(4, 0);
            Vertice v6 = new Vertice(0, 3);
            Triangulo outroTriangulo = new Triangulo(v4, v5, v6);

            Console.WriteLine("Os triângulos são iguais? " + (triangulo.EhIgual(outroTriangulo) ? "Sim" : "Não"));
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

*/

/*
class Program
{
    static void Main()
    {
        Vertice v1 = new Vertice(0, 0);
        Vertice v2 = new Vertice(4, 0);
        Vertice v3 = new Vertice(4, 3);

        // Inicializa o polígono com três vértices
        Poligono poligono = new Poligono(new List<Vertice> { v1, v2, v3 });
        Console.WriteLine("Quantidade de vértices: " + poligono.QuantidadeVertices);

        // Adiciona um novo vértice
        Vertice v4 = new Vertice(0, 3);
        bool adicionado = poligono.AddVertice(v4);
        Console.WriteLine("Vértice (0, 3) foi adicionado? " + (adicionado ? "Sim" : "Não"));
        Console.WriteLine("Quantidade de vértices: " + poligono.QuantidadeVertices);

        // Tenta adicionar o mesmo vértice novamente
        adicionado = poligono.AddVertice(v4);
        Console.WriteLine("Vértice (0, 3) foi adicionado novamente? " + (adicionado ? "Sim" : "Não"));

        // Calcula o perímetro do polígono
        Console.WriteLine("Perímetro do polígono: " + poligono.Perimetro());

        // Remove um vértice
        poligono.RemoveVertice(v4);
        Console.WriteLine("Quantidade de vértices após remoção: " + poligono.QuantidadeVertices);

        // Tenta remover mais um vértice, mantendo o mínimo de 3
        poligono.RemoveVertice(v1);
        Console.WriteLine("Quantidade de vértices após segunda remoção: " + poligono.QuantidadeVertices);

        try
        {
            // Tenta remover mais um vértice, o que causará uma exceção
            poligono.RemoveVertice(v2);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
        }
    }
}
*/

/*
class Program
{
    static void Main()
    {
        // Criação de dois intervalos
        Intervalo intervalo1 = new Intervalo(new DateTime(2023, 10, 26, 8, 0, 0), new DateTime(2023, 10, 26, 12, 0, 0));
        Intervalo intervalo2 = new Intervalo(new DateTime(2023, 10, 26, 10, 0, 0), new DateTime(2023, 10, 26, 14, 0, 0));

        // Teste da duração do intervalo
        Console.WriteLine("Duração do intervalo1: " + intervalo1.Duracao);

        // Verificar interseção entre intervalos
        bool temIntersecao = intervalo1.TemIntersecao(intervalo2);
        Console.WriteLine("Intervalo1 tem interseção com Intervalo2? " + (temIntersecao ? "Sim" : "Não"));

        // Verificar se dois intervalos são iguais
        Intervalo intervalo3 = new Intervalo(new DateTime(2023, 10, 26, 8, 0, 0), new DateTime(2023, 10, 26, 12, 0, 0));
        bool saoIguais = intervalo1.EhIgual(intervalo3);
        Console.WriteLine("Intervalo1 é igual ao Intervalo3? " + (saoIguais ? "Sim" : "Não"));

        // Teste de exceção ao criar um intervalo inválido
        try
        {
            Intervalo intervaloInvalido = new Intervalo(new DateTime(2023, 10, 26, 15, 0, 0), new DateTime(2023, 10, 26, 12, 0, 0));
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Erro ao criar intervalo: " + ex.Message);
        }
    }
}

*/

/*
class Program
{
    static void Main()
    {
        // Criando alguns intervalos
        Intervalo intervalo1 = new Intervalo(new DateTime(2023, 10, 26, 8, 0, 0), new DateTime(2023, 10, 26, 10, 0, 0));
        Intervalo intervalo2 = new Intervalo(new DateTime(2023, 10, 26, 11, 0, 0), new DateTime(2023, 10, 26, 13, 0, 0));
        Intervalo intervalo3 = new Intervalo(new DateTime(2023, 10, 26, 9, 0, 0), new DateTime(2023, 10, 26, 12, 0, 0)); // Interseção com intervalo1 e intervalo2
        Intervalo intervalo4 = new Intervalo(new DateTime(2023, 10, 26, 14, 0, 0), new DateTime(2023, 10, 26, 15, 0, 0));

        // Criando a lista de intervalos
        ListaIntervalo listaIntervalo = new ListaIntervalo();

        // Adicionando intervalos
        Console.WriteLine("Intervalo1 adicionado? " + (listaIntervalo.Add(intervalo1) ? "Sim" : "Não"));
        Console.WriteLine("Intervalo2 adicionado? " + (listaIntervalo.Add(intervalo2) ? "Sim" : "Não"));
        Console.WriteLine("Intervalo3 adicionado? " + (listaIntervalo.Add(intervalo3) ? "Sim" : "Não")); // Deve retornar Não (interseção com intervalo1 e intervalo2)
        Console.WriteLine("Intervalo4 adicionado? " + (listaIntervalo.Add(intervalo4) ? "Sim" : "Não"));

        // Exibindo a lista de intervalos (ordenada)
        Console.WriteLine("\nLista de Intervalos:");
        foreach (var intervalo in listaIntervalo.Intervalos)
        {
            Console.WriteLine($"Intervalo: {intervalo.DataHoraInicial} - {intervalo.DataHoraFinal}");
        }
    }
}

*/

/*
class Program
{
    static void Main()
    {
        Console.WriteLine("Números de Armstrong de 1 a 10000:");

        for (int i = 1; i <= 10000; i++)
        {
            if (i.IsArmstrong()) // Usa o método de extensão
            {
                Console.WriteLine(i);
            }
        }
    }
}

*/

/*
class Program
{
    static void Main()
    {
        // Cria uma pessoa sem certidão
        Pessoa pessoa = new Pessoa("João Silva");
        Console.WriteLine($"Pessoa: {pessoa.Nome}");

        // Cria uma certidão de nascimento associada à pessoa
        CertidaoNascimento certidao = new CertidaoNascimento(new DateTime(2023, 10, 26), pessoa);

        // Associa a certidão à pessoa
        pessoa.RegistrarCertidao(certidao);

        Console.WriteLine($"Certidão associada em: {pessoa.Certidao.DataEmissao}");

        // Tentativa de registrar uma nova certidão para a mesma pessoa (gera exceção)
        try
        {
            CertidaoNascimento novaCertidao = new CertidaoNascimento(new DateTime(2024, 1, 1), pessoa);
            pessoa.RegistrarCertidao(novaCertidao);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
        }
    }
}
*/

/*
class Program
{
    static void Main()
    {
        // Criação de um motor
        Motor motor1 = new Motor(1.6);
        Motor motor2 = new Motor(2.0);

        // Criação de um carro
        Carro carro = new Carro("ABC1234", "Sedan", motor1);
        Console.WriteLine($"Carro: {carro.Modelo}, Placa: {carro.Placa}, Motor: {carro.Motor.Cilindrada}");
        Console.WriteLine($"Velocidade máxima: {carro.VelocidadeMaxima()} km/h");

        // Tentativa de trocar o motor do carro
        carro.AlterarMotor(motor2);
        Console.WriteLine($"Novo motor do carro: {carro.Motor.Cilindrada}");
        Console.WriteLine($"Velocidade máxima após troca de motor: {carro.VelocidadeMaxima()} km/h");

        // Tentativa de usar o motor1 em outro carro
        Carro outroCarro = new Carro("DEF5678", "SUV", motor1);
    }
}
*/