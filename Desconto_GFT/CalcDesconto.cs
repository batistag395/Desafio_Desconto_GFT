using System.Globalization;

namespace Desconto_GFT
{
    public class CalcDesconto
    {
        public double ValorTotal { get; set; }

        public CalcDesconto(double valorTotal)
        {
            ValorTotal = valorTotal;
        }

        public double ValorComDesconto()
        {
            double valorAnalise = ValorTotal - 300;
            int count = 0;
            if (ValorTotal >= 300)
            {
                while (valorAnalise  >= 0)
                {
                    if(count >= 20)
                    {
                        break;
                    }
                    valorAnalise -= 100.00;
                    count++;
                }
                Console.WriteLine($"Contemplado com desconto de {count}%");
            }
            else
            {
                Console.WriteLine("O valor da compra nao contempla desconto.");
            }
             return ValorTotal -= ValorTotal * (count / 100.00);
        }
        public override string ToString()
        {
            return 
                "Valor total = "
                + ValorComDesconto().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
