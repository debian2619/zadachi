Console.WriteLine(" Hi! My friend!");
Console.WriteLine(" what is your name? ");
string name = Console.ReadLine();
Console.WriteLine("Hi! My friend " + name);
Console.WriteLine(" Would you like to see drama or comedy?");
string genre = Console.ReadLine();
Console.WriteLine("In this case I'd like to recomend you to see next movies: ");
if(genre == "comedy")
{
    
    Console.WriteLine(" * Ivan Vasilievich changes profession.");
    Console.WriteLine(" * Only girls in jas ");
    Console.WriteLine(" * Back to the future ");
}
else
{
    Console.WriteLine(" * Green mile.");
    Console.WriteLine(" * Escape from Showshenko.");
}
Console.ReadLine();




