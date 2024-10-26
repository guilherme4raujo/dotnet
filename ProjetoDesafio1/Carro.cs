using System;

public class Carro
{

    public string Placa { get; }
    public string Modelo { get; }
    private Motor motor;

  
    public Motor Motor
    {
        get => motor;
    }

    
    public Carro(string placa, string modelo, Motor motorInicial)
    {
        if (string.IsNullOrWhiteSpace(placa))
            throw new ArgumentException("A placa é obrigatória.");

        if (string.IsNullOrWhiteSpace(modelo))
            throw new ArgumentException("O modelo é obrigatório.");

        if (motorInicial == null)
            throw new ArgumentNullException(nameof(motorInicial), "O motor é obrigatório.");

        Placa = placa;
        Modelo = modelo;
        AlterarMotor(motorInicial);
    }

    // Método para trocar o motor do carro
    public void AlterarMotor(Motor novoMotor)
    {
        if (novoMotor == null)
            throw new ArgumentNullException(nameof(novoMotor), "O carro deve ter um motor.");

        if (novoMotor.CarroInstalado != null && novoMotor.CarroInstalado != this)
            throw new InvalidOperationException("O motor já está instalado em outro carro.");

        // Remove o motor atual, se houver, e instala o novo motor
        motor?.RemoverDeCarro();
        motor = novoMotor;
        motor.InstalarEmCarro(this);
    }

    // Método para calcular a velocidade máxima com base na cilindrada do motor
    public int VelocidadeMaxima()
    {
        if (motor.Cilindrada <= 1.0)
            return 140;
        else if (motor.Cilindrada <= 1.6)
            return 160;
        else if (motor.Cilindrada <= 2.0)
            return 180;
        else
            return 220;
    }
}
