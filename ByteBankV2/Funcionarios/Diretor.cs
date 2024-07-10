namespace ByteBankV2.Funcionarios;

public class Diretor
{
    public string Nome {get; set;}
    public string CPF {get; set;}
    public double Salario {get; set;}

    public double GetBonificacao()
    {
        return Salario * 0.10;
    }




} 