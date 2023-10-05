/*Брой пакети химикали - цяло число в интервала [0...100]
•	Брой пакети маркери - цяло число в интервала [0...100]
•	Литри препарат за почистване на дъска - цяло число в интервала [0…50]
•	Процент намаление - цяло число в интервала [0...100]*/
int pens = int.Parse(Console.ReadLine());
int markers = int.Parse(Console.ReadLine());
int litersBoardCleaner = int.Parse(Console.ReadLine());
int discount = int.Parse(Console.ReadLine());

/*•	Пакет химикали - 5.80 лв. 
•	Пакет маркери - 7.20 лв. 
•	Препарат - 1.20 лв (за литър)*/

double sum = pens * 5.80 + markers * 7.20 + litersBoardCleaner * 1.20;
double disctountedTotal = sum - (sum * discount / 100);

Console.WriteLine(disctountedTotal);