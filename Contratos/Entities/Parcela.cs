using System.Globalization;

namespace Contratos.Entities
{
    internal class Parcela
    {
        public DateTime DataPagamento { get; set; }
        public double Valor { get; set; }

        public Parcela(DateTime dataPagamento, double valor)
        {
            DataPagamento = dataPagamento;
            Valor = valor;
        }

        public override string ToString()
        {
            return DataPagamento.ToString("dd/MM/yyyy") 
                + " - " 
                + Valor.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
