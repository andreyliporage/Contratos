namespace Contratos.Entities
{
    internal class Contrato
    {
        public string Numero { get; set; }
        public DateTime Data { get; set; }
        public double Valor { get; private set; }

        public List<Parcela> Parcelas { get; private set; }

        public Contrato(string numero, DateTime data, double valor)
        {
            Numero = numero;
            Data = data;
            Valor = valor;
            Parcelas = new List<Parcela>();
        }

        public void AdicionaParcela(Parcela parcela)
        {
            Parcelas.Add(parcela);
        }
    }
}
