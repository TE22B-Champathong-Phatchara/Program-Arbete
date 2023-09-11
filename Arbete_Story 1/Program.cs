string? namn;

Console.WriteLine("Du gick in i huset");
Thread.Sleep(2000);
Console.WriteLine("Vad heter du?")
namn = Console.ReadLine();

if (namn == "micke") 
{
    Console.WriteLine("Välkomen!");
}
else if (namn != "")
{
    Console.WriteLine("Vem fan är du!?");
}



Console.ReadKey();
