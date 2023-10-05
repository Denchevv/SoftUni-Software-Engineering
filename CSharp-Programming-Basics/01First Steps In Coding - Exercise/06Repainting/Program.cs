/*1.	Необходимо количество найлон (в кв.м.) - цяло число в интервала [1... 100]
2.	Необходимо количество боя (в литри) - цяло число в интервала [1…100]
3.	Количество разредител (в литри) - цяло число в интервала [1…30]
4.	Часовете, за които майсторите ще свършат работата - цяло число в интервала [1…9] */
int nylonNeeded = int.Parse(Console.ReadLine());
int litersPaint = int.Parse(Console.ReadLine());
int thinner = int.Parse(Console.ReadLine());
int hoursNeeded = int.Parse(Console.ReadLine());

/*•	Предпазен найлон - 1.50 лв. за кв. метър + 2 кв м 
•	Боя - 14.50 лв. за литър + 10% количество боя
•	Разредител за боя - 5.00 лв. за литър
    + 0.40 лв за торбички 
    Майстор/час - 30% от всички разходи за материали */

double nylonTotal = (nylonNeeded + 2) * 1.50;
double paintTotal = (litersPaint + litersPaint * 0.1) * 14.50;
double thinnerTotal = thinner * 5.0;
double workingHours = hoursNeeded * ((nylonTotal + paintTotal + thinnerTotal + 0.4) * 0.3);

double totalExpenses = nylonTotal + paintTotal + thinnerTotal + workingHours + 0.4;

Console.WriteLine(totalExpenses);