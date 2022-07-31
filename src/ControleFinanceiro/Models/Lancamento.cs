namespace ControleFinanceiro.Models
{
    public class Lancamento : List<Despesa>
    {
        public float Total => this.Sum(d => d.Valor);
    }
}