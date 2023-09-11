
using System.Reflection.Metadata;

string yn; //Jag föredrar att skapa variabel först.
string ans1;
string ans2;


//Introduktion.
Console.WriteLine("Greeting...");
Thread.Sleep(2000); //Kommando för att göra texten kommer senare efter några sekuder(millisekunder). Det anväder för att skapa naturliga känslor för spelare. 
Console.WriteLine("It's fantastic too meet you!");
Thread.Sleep(3000);
Console.WriteLine("Don't you feel the same?");
Thread.Sleep(1500);
Console.WriteLine("Yes or No?");
Console.WriteLine("__________________________"); //Det är ju fint att ha en rad för att separera spelarens svar och texten!
Console.WriteLine("");// Ett lite utrymme.

//Svar 'yes' eller 'no'  Fixa texten att det ska vara låg bokstav.
yn = Console.ReadLine().ToLower();

if (yn == "yes") // Aktiv person
{
    Console.WriteLine("Great! I like an active person like you!");
    Thread.Sleep(2000);
    Console.WriteLine("All I'm going to do is ask a question...");
    Thread.Sleep(2000);
    Console.WriteLine("If you are in the dark forest what DO you want to see the most? A ghost? A dog? Or Nothing?");
    Console.WriteLine("__________________________");
    Console.WriteLine("");
    ans1 = Console.ReadLine().ToLower();
    if (ans1 == "a ghost")//End1.1
    {
        Console.WriteLine("__________________________");
        Console.WriteLine("Wow, you're a challenger!");
        Thread.Sleep(3000);
        Console.WriteLine("That's it. Good bye!");   
    }
    else if (ans1 == "a dog")//End1.2
    {
        Console.WriteLine("__________________________");
        Console.WriteLine("I think you might need to check your mental...");
        Thread.Sleep(2000);
        Console.WriteLine("A dog in the dark forest? That's a bit weird...");
        Console.WriteLine("But thanks for answer though.");
    }
    else if (ans1 == "nothing")//End1.3
    {
        Console.WriteLine("__________________________");
        Console.WriteLine("Maybe you're right! There is nothing!!");
        Thread.Sleep(2000);
        Console.WriteLine("Thanks for answer.");
    }
    else//Om man inte skiver rätt svar.
    {
        Console.WriteLine("__________________________");
        Console.WriteLine("Dude, if you don't answer the question you'll need to restart this. I'm too lazy to use 'while' command.");
    }

    
    
}
else if (yn == "no") //Tråkigt.
{
    Console.WriteLine("__________________________");
    Console.WriteLine("I see...");
    Thread.Sleep(3000);
    Console.WriteLine("Alright, just nevermind.");
        Console.WriteLine("All I'm going to do is ask a question...");
    Thread.Sleep(2000);
    Console.WriteLine("If you are in the dark forest what you DON'T want to see the most? A ghost? A dog? Or Nothing?"); //Lite skillad frågan.
    Console.WriteLine("__________________________");
    Console.WriteLine("");
    ans2 = Console.ReadLine().ToLower();
    if (ans2 == "a ghost")//End2.1
    {
        Console.WriteLine("__________________________");
        Console.WriteLine("Are you afraid of those thing? They're just imaginations");
        Thread.Sleep(1000);
        Console.WriteLine("You coward!! Woohoo!!");
    }
    else if (ans2 == "a dog")//End2.2
    {
        Console.WriteLine("__________________________");
        Console.WriteLine("That's really really really sad to hear...");
        Thread.Sleep(2000);
        Console.WriteLine("Who the hell hate dogs...");
    }
    else if (ans2 == "nothing")//End2.3
    {
        Console.WriteLine("__________________________");
        Console.WriteLine("What do you mean? Do you want to see somthing??");
        Thread.Sleep(2000);
        Console.WriteLine("Thanks for answer...? Don't forget to check your mental...");
    }
    else//Om man inte skiver rätt svar.
    {
        Console.WriteLine("__________________________");
        Console.WriteLine("Dude, if you don't answer the question you'll need to restart this. I'm too lazy to use 'while' command.");
    }

    
    
}
else//Om man inte skiver rätt svar.
{
    Console.WriteLine("__________________________");
    Console.WriteLine("Dude, if you don't answer the question you'll need to restart this. I'm too lazy to use 'while' command.");//Jag har inte lärt mig om det...
}

Console.ReadKey();