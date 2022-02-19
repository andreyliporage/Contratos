using Contratos.Entities;
using Contratos.Utils;

namespace Contratos.Services
{
    internal class ParcelaService
    {
        public int QuantidadeParcelas { get; set; }

        private readonly ITaxaService _taxaService;

        public ParcelaService(int quantidadeParcelas, ITaxaService taxaService)
        {
            QuantidadeParcelas = quantidadeParcelas;
            _taxaService = taxaService;
        }

        public void ProcessaParcela(Contrato contrato)
        {
            double valorParcelaSemTaxa = contrato.Valor / QuantidadeParcelas;
            for (int i = 1; i <= QuantidadeParcelas; i++)
            {
                double valorParcelaFinal = _taxaService.Taxa(valorParcelaSemTaxa, i);
                DateTime dataPagamento = contrato.Data.AddMonths(i);
                Parcela parcela = Factory.ParcelaFactory(dataPagamento, valorParcelaFinal);

                contrato.AdicionaParcela(parcela);
            }
        }
    }
}
