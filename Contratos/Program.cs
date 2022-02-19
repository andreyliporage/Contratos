using Contratos.Entities;
using Contratos.Services;
using System.Globalization;

Console.WriteLine("Entre com as informações do contrato");
Console.WriteLine("Número: ");
string numeroContrato = Console.ReadLine();

Console.WriteLine("Data: (dd/MM/yyyy): ");
DateTime dataContrato = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

Console.WriteLine("Valor do contrato: ");
double valorContrato = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Quantidade de parcelas: ");
int parcelas = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Contrato contrato = new Contrato(numeroContrato, dataContrato, valorContrato);

ParcelaService parcelaService = new ParcelaService(parcelas, new PayPalService());
parcelaService.ProcessaParcela(contrato);

contrato.Parcelas.ToList().ForEach(parcela =>
{
    Console.WriteLine(parcela);
});

