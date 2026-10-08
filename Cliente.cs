public class Cliente
{
    private string nome = "";
    private string cpf = "";

    public string Nome
    {
        get 
        {
            return nome;
        }
        set
        {
            if(string.IsNullOrWhiteSpace(value))
            throw new Exception("O nome nao pode ser vazio");
            nome = value;
        }
    }

    public string CPF
    {
        get
        {
            return cpf;
        }
        set
        {
            if(string.IsNullOrWhiteSpace(value))
            throw new Exception("O CPF nao pode ser vazio");
            cpf = value;
        }
    }

    public Cliente(string nome, string cpf)
    {
        Nome = nome;
        CPF = cpf;
    }
}