//сума = депозирана сума  + срок на депозита * ((депозирана сума * годишен лихвен процент ) / 12)

double deposit = double.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());
double interestPerYear = double.Parse(Console.ReadLine());

double interestMonth = (deposit * interestPerYear / 100) / 12;

double totalMoney = deposit + length*interestMonth;

Console.WriteLine(totalMoney);