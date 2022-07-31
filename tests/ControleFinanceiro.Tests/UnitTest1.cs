using ControleFinanceiro.Models;

namespace ControleFinanceiro.Tests;

public class UnitTest1
{
    [Fact]
    public void DeveraSomarTotalDeDespesas()
    {
        var lancamento = new Lancamento();
        lancamento.Add(new Despesa(default, string.Empty, 100));
        lancamento.Add(new Despesa(default, string.Empty, 100));
        lancamento.Add(new Despesa(default, string.Empty, 100));

        Assert.Equal(300, lancamento.Total);
    }

    [Fact]
    public void DeveraIncluirJuros()
    {
        if(true)
        {

        }
        
        // Given
        var despesa = new Despesa(default, string.Empty, 100);
        // When
        despesa.IncluirJuros();
        
        // Then
        Assert.Equal(105, despesa.Valor);
    }

    [Fact]
    public void DeveraTerDataCorreta()
    {
        var data = DateTime.Now;
         // Given
        var despesa = new Despesa(data, string.Empty, 100);
        
        // Then
        Assert.Equal(data.ToShortDateString(), despesa.Data.ToShortDateString());
    }
}