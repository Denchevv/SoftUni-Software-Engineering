/*•	Пилешко меню –  10.35 лв. 
•	Меню с риба – 12.40 лв. 
•	Вегетарианско меню  – 8.15 лв.  
    Десерт - 20% от общата сметка 
    Доставка - 2.50 лв*/
int chikenMenus = int.Parse(Console.ReadLine());
int fishMenus = int.Parse(Console.ReadLine());
int vegatarianMenus = int.Parse(Console.ReadLine());

double desert = (chikenMenus * 10.35 + fishMenus * 12.40 + vegatarianMenus * 8.15) * 0.2;
double totalSum = chikenMenus * 10.35 + fishMenus * 12.40 + vegatarianMenus * 8.15 + desert + 2.50;

Console.WriteLine(totalSum);

