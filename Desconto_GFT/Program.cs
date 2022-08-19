using Desconto_GFT;

CalcDesconto desconto;

Console.WriteLine("Digite o valor do produto:");
double valor = double.Parse(Console.ReadLine());

desconto = new CalcDesconto(valor);

Console.WriteLine(desconto);