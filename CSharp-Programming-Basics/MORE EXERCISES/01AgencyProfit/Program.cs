//1. Read input
/*. Име на авиокомпанията - текст
2. Брой билети за възрастни – цяло число в диапазона [1…400]
3. Брой детски билети – цяло число в диапазона [25…120]
4. Нетна цена на билет за възрастен – реално число в диапазона [100.0…1600.0]
5. Цената на такса обслужване - реално число в диапазона [10.0…50.0]*/
string company = Console.ReadLine();
int quantityAdultTickets = int.Parse(Console.ReadLine());
int quantityKidTickets = int.Parse(Console.ReadLine());
double priceAdultTicket = double.Parse(Console.ReadLine());
double serviceTax = double.Parse(Console.ReadLine());

//2. Calculate the profit from the tickets
double priceKidTickets = priceAdultTicket * 0.3 + serviceTax;
priceAdultTicket += serviceTax;
double total = ((quantityAdultTickets * priceAdultTicket) + (quantityKidTickets * priceKidTickets)) * 0.2;

//3. Print output
Console.WriteLine($"The profit of your agency from {company} tickets is {total:f2} lv.");