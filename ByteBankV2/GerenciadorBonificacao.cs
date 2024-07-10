using ByteBankV2.Funcionarios;

namespace ByteBankV2;

public class GerenciadorBonificacao
{
     private double _totalBonificacao; 

     public void Registrar(Funcionario funcionario)
     {
        _totalBonificacao += funcionario.GetBonificacao();
     }

    public void Registrar(Diretor diretor)
     {
        _totalBonificacao += diretor.GetBonificacao();
     }

    public double GetTotalBonificacao()
    {
        return _totalBonificacao;
    }
}
