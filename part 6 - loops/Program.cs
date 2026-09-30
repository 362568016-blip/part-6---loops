using System.Numerics;
using System.Reflection.Emit;

int option, minNumber, maxNumber, awnser, dieNumber1, dieNumber2, balance, questionAwnser, withdrawNumber;
bool done;
Random generator = new Random();

Console.WriteLine("Witch Program do you want? (1 - Prompter, 2 - Bank Buisness, or 3 - Dice?)");
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
    balance = 150;
    done = false;
    while (!done)
    {
        Console.WriteLine($"What transation would you like to do? 1 - Withdraw, 2 - Deposit, 3 - bill payment or 4 - Quit? Current balance:{balance}");
        questionAwnser = Convert.ToInt32(Console.ReadLine());

        if (questionAwnser == 1)
        {
            Console.WriteLine("Type in a number that you would like to withdraw");
            withdrawNumber = Convert.ToInt32(Console.ReadLine());

            if (withdrawNumber > balance)
            {
                Console.WriteLine("AWNSER NOT VALID, TRY AGAIN");
                done = false;
            }

            if (withdrawNumber <= balance)
            {
                Console.WriteLine($"Okay, taking out {withdrawNumber} from your balance");
                balance = (balance - withdrawNumber);
                balance = (balance - 0.75);
            }
        }

        if (questionAwnser == 2)
        {

        }
    }
}
if (option == 3)
{
    Console.WriteLine("press ANY KEY to start");
    Console.ReadLine();
    done = false;
    while (!done)
    {
            dieNumber1 = generator.Next(1, 7);
            dieNumber2 = generator.Next(1, 7);

            if (dieNumber1 == dieNumber2)
            {
                Console.WriteLine($"Your two dice numbers are {dieNumber1} and {dieNumber2}.");
                Console.WriteLine("YOU GOT DOUBLES!!!");
                done = true;
            }
            else
            {
                Console.WriteLine($"Your two dice numbers are {dieNumber1} and {dieNumber2}.");
                Console.WriteLine("not doubles..");
                Console.WriteLine("press ANY KEY to continue");
                Console.ReadLine();
            }
    }
    
    
}
else
{
    Console.WriteLine("no");
}