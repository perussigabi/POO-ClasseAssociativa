public class Locacao
{
    private Cliente cliente;
    private Veiculo veiculo;
    private DateOnly dataRetirada;
    private int quantidadeDias;
    private decimal valorDiaria;

    public Cliente Cliente
    {
        get { return cliente; }
        set
        {
            if (value == null)
                throw new Exception("A locação precisa possuir um cliente.");

            cliente = value;
        }
    }

    public Veiculo Veiculo
    {
        get { return veiculo; }
        set
        {
            if (value == null)
                throw new Exception("A locação precisa possuir um veículo.");

            veiculo = value;
        }
    }

    public DateOnly DataRetirada
    {
        get { return dataRetirada; }
        set
        {
            dataRetirada = value;
        }
    }

    public int QuantidadeDias
    {
        get { return quantidadeDias; }
        set
        {
            if (value <= 0)
                throw new Exception("A quantidade de dias deve ser maior que zero.");

            quantidadeDias = value;
        }
    }

    public decimal ValorDiaria
    {
        get { return valorDiaria; }
        set
        {
            if (value <= 0)
                throw new Exception("O valor da diária deve ser maior que zero.");

            valorDiaria = value;
        }
    }

    public Locacao(
        Cliente cliente,
        Veiculo veiculo,
        DateOnly dataRetirada,
        int quantidadeDias,
        decimal valorDiaria)
    {
        Cliente = cliente;
        Veiculo = veiculo;
        DataRetirada = dataRetirada;
        QuantidadeDias = quantidadeDias;
        ValorDiaria = valorDiaria;
    }

    public decimal CalcularValorBruto()
    {
        return QuantidadeDias * ValorDiaria;
    }

    public decimal CalcularDesconto()
    {
        if (QuantidadeDias >= 15)
        {
        return CalcularValorBruto() * 0.15m;
        }
        else if (QuantidadeDias >= 7)
        {
        return CalcularValorBruto() * 0.10m;
        }

        return 0;
    }

    public decimal CalcularValorFinal()
    {
        return CalcularValorBruto() - CalcularDesconto();
    }

    public void ExibirResumo()
    {
        Console.WriteLine("===== RESUMO DA LOCAÇÃO =====");
        Console.WriteLine($"Cliente: {Cliente.Nome}");
        Console.WriteLine($"CPF: {Cliente.CPF}");
        Console.WriteLine($"Veículo: {Veiculo.Modelo}");
        Console.WriteLine($"Placa: {Veiculo.Placa}");
        Console.WriteLine($"Data de retirada: {DataRetirada:dd/MM/yyyy}");
        Console.WriteLine($"Quantidade de dias: {QuantidadeDias}");
        Console.WriteLine($"Valor da diária: R$ {ValorDiaria:F2}");
        Console.WriteLine($"Valor bruto: R$ {CalcularValorBruto():F2}");
        Console.WriteLine($"Desconto: R$ {CalcularDesconto():F2}");
        Console.WriteLine($"Valor final: R$ {CalcularValorFinal():F2}");
        Console.WriteLine("=============================");
    }
}