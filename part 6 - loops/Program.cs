using System.Numerics;
using System.Reflection.Emit;

int option, minNumber, maxNumber, awnser;
bool done;

Console.WriteLine("Witch Program do you want? (1 - Prompter, 2, or 3?)");
option = Convert.ToInt32(Console.ReadLine());

if (option == 1)
{
    Console.WriteLine("hey, type in a number");
    minNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Great! Now type in a number greater than the previous");
    maxNumber = Convert.ToInt32(Console.ReadLine());
    done = false;
    while (!done)
    {
        Console.WriteLine("Okay, now type in a number greater than number 1 but lower than number 2");
        awnser = Convert.ToInt32(Console.ReadLine());

        if (awnser > minNumber && awnser < maxNumber)
            {
               done = true;
            }
        
       
        
    }
}
if (option == 2)
{
    while (true)
    {

    }
}
if (option == 3)
{
    while (true)
    {

    }
}
else
{
    Console.WriteLine("no");
}