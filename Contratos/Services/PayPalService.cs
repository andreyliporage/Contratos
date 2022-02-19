namespace Contratos.Services
{
    internal class PayPalService : ITaxaService
    {
        private const double taxaPorParcela = 0.01;
        private const double taxaPorPagamento = 0.02;

        public double Taxa(double valorParcela, int numeroParcela)
        {
            double taxaPorMes = valorParcela * taxaPorParcela * numeroParcela;
            double valorComtaxaPorMes = valorParcela + taxaPorMes;
            double valorComTaxaPorPagamento = valorComtaxaPorMes + (valorComtaxaPorMes * taxaPorPagamento);

            return valorComTaxaPorPagamento;
        }
    }
}
