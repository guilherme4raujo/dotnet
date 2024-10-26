using System;

public class Motor
{
    
    public double Cilindrada { get; }
    public Carro CarroInstalado { get; private set; }

    
    public Motor(double cilindrada)
    {
        if (cilindrada <= 0)
            throw new ArgumentException("A cilindrada do motor deve ser positiva.");

        Cilindrada = cilindrada;
    }

    // Método para instalar o motor em um carro
    internal void InstalarEmCarro(Carro carro)
    {
        if (CarroInstalado != null && CarroInstalado != carro)
            throw new InvalidOperationException("Este motor já está instalado em outro carro.");

        CarroInstalado = carro;
    }

    // Método para remover o motor de um carro
    internal void RemoverDeCarro()
    {
        CarroInstalado = null;
    }
}
