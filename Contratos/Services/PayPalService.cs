namespace Contratos.Services
{
    internal class PayPalService : ITaxaService
    {

        public double Taxa(double valorParcela, int numeroParcela)
        {
            double taxaPorMes = valorParcela * 0.01 * numeroParcela;
            double valorComtaxaPorMes = valorParcela + taxaPorMes;
            double valorComTaxaPorPagamento = valorComtaxaPorMes + (valorComtaxaPorMes * 0.02);

            return valorComTaxaPorPagamento;
        }
    }
}
