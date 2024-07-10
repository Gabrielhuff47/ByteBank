
using ByteBankV2;
using ByteBankV2.Funcionarios;


public class Program 
{
static void Main (string [] args)
{

GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
Funcionario carlos = new Funcionario (); 
carlos.Nome = "Carlos";
carlos.CPF = "3209321019";
carlos.Salario = 5000;

Diretor gabriel = new Diretor ();
gabriel.Nome = "Gabriel";
gabriel.CPF = "2031342303412";
gabriel.Salario = 10000;

gerenciador.Registrar (carlos);
gerenciador.Registrar (gabriel);
Console.WriteLine("Total de bonificacoes: " +gerenciador.GetTotalBonificacao());
Console.WriteLine ("TESTE");
}
}