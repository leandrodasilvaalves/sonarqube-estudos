using System.Diagnostics.CodeAnalysis;
using ControleFinanceiro.Models;

[ExcludeFromCodeCoverage]
public class Program
{
    static void Main(string[] args)
    {
        var lancamento = new Lancamento();

        lancamento.Add(new Despesa(DateTime.Now, "Teste 1", 5.55f));
        lancamento.Add(new Despesa(DateTime.Now, "Teste 2", 3.25f));
        lancamento.Add(new Despesa(DateTime.Now, "Teste 2", 3.25f));
        ImprimirDespesas(lancamento);

        lancamento.Add(new Despesa(DateTime.Now, "Teste 4", 10.11f));
        lancamento.Add(new Despesa(DateTime.Now, "Teste 5", 35.99f));
        ImprimirDespesas(lancamento);

        var despesaComJuros = new Despesa(DateTime.Now, "Teste 6", 100.00f);
        despesaComJuros.IncluirJuros();
        lancamento.Add(despesaComJuros);
        ImprimirDespesas(lancamento);

        static void ImprimirDespesas(Lancamento lancamento)
        {
            foreach (var desp in lancamento)
            {
                Console.WriteLine("Data: {0}, Descricao: {1}, Valor: {2}",
                    desp.Data.ToString("dd/MM/yyyy"), desp.Descricao, desp.Valor.ToString("c2"));
            }
            Console.WriteLine("Total: {0}", lancamento.Total.ToString("c2"));
        }
    }
}