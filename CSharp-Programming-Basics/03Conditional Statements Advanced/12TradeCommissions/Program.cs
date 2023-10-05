/*Град	0 ≤ s ≤ 500	|500 < s ≤ 1 000 | 1 000 < s ≤ 10 000 | s > 10 000
Sofia	    5%	            7%	              8%	            12%
Varna	    4.5%	        7.5%	            10%	            13%
Plovdiv 	5.5%	        8%	                12%	            14.5%
*/

string city = Console.ReadLine();
double sales = double.Parse(Console.ReadLine());

double commision = 0;

if (city == "Sofia")
{
    if(sales >= 0 && sales <= 500)
    {
        commision = commision * 0.05;
    }

}
else if (city == "Varna")
{
    
}
else if (city == "Plovdiv")
{

}
else
{
    Console.WriteLine("error");
}