// Богомолов Даниил Средний уровень 13 вариант

Console.WriteLine("Введите текст для подсчета соотншения символов:");
string text = Console.ReadLine();
char[] symbols = text.ToCharArray();

int totalLong = symbols.Length;
int lowerCount = 0;
int upCount = 0;
for (int symbol= 0; symbol < totalLong; symbol++)
{
    if (char.IsLower(symbols[symbol])) lowerCount++;
    if (char.IsUpper(symbols[symbol])) upCount++;
}

double answer = (lowerCount + upCount) / totalLong * 100;

Console.WriteLine(answer + '%');

Console.Write($"{totalLong} \n{lowerCount} \n {upCount}");

