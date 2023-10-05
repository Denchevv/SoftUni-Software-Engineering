/*•	Баскетболни кецове – цената им е 40% по-малка от таксата за една година
•	Баскетболен екип – цената му е 20% по-евтина от тази на кецовете
•	Баскетболна топка – цената ѝ е 1 / 4 от цената на баскетболния екип
•	Баскетболни аксесоари – цената им е 1 / 5 от цената на баскетболната топка */

int yearlyTax = int.Parse(Console.ReadLine());

double sneakers = yearlyTax - (yearlyTax * 0.40);
double outfit = sneakers - (sneakers * 0.2);
double ball = outfit * 0.25;
double accessories = ball * 0.2;

double total = yearlyTax + sneakers + outfit + ball + accessories;

Console.WriteLine(total);