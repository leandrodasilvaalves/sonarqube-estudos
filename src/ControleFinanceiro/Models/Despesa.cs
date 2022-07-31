namespace ControleFinanceiro.Models
{
    public class Despesa : IDisposable
    {
        public Despesa(DateTime data, string descricao, float valor)
        {
            Data = DateTime.Now;
            Descricao = descricao;
            Valor = valor;
        }

        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public float Valor { get; set; }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disponsing)
        {
            Console.WriteLine("Encerrando a instancia com sucesso");
        }

        public void IncluirJuros()
        {
            Valor += Valor * 0.05f;
        }
    }
}