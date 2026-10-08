public class Veiculo
{
    private string modelo;
    private string placa;

    public string Modelo
    {
        get { return modelo; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new Exception("O modelo não pode ser vazio.");

            modelo = value;
        }
    }

    public string Placa
    {
        get { return placa; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new Exception("A placa não pode ser vazia.");

            placa = value;
        }
    }

    public Veiculo(string modelo, string placa)
    {
        Modelo = modelo;
        Placa = placa;
    }
}
