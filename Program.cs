Console.Write("Por favor, digite o valor em wons: ");
string input = Console.ReadLine()!;

double valorWon = Convert.ToDouble(input);

double taxaConversao = 0.0040;

double valorConvertido = valorWon * taxaConversao;

Console.WriteLine("O valor convertido em reais é: R$" + valorConvertido.ToString("F2"));
