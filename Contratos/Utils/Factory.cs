using Contratos.Entities;

namespace Contratos.Utils
{
    internal sealed class Factory
    {
        public static Parcela ParcelaFactory(DateTime dataPagamento, double valor)
        {
            return new Parcela(dataPagamento, valor);
        }
    }
}
