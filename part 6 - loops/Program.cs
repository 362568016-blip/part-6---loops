using System.Numerics;
using System.Reflection.Emit;

int option, minNumber, maxNumber, awnser, dieNumber1, dieNumber2, balance, questionAwnser, withdrawNumber, depositNumber, IRLmoney;
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
    if (minNumber < maxNumber)
    {
        done = false;
        while (!done)
        {
            Console.WriteLine("Okay, now type in a number greater than number 1 but lower than number 2");
            awnser = Convert.ToInt32(Console.ReadLine());

            if (awnser > minNumber && awnser < maxNumber)
            {
                Console.WriteLine("Yep you can count!");
                done = true;
            }
            else
            {
                Console.WriteLine("nope, try again");
            }
        }
    }
    else
    { 
        Console.WriteLine("You cant count."); 
    }
}
if (option == 2)
{
    balance = 150;
    IRLmoney = 0;
    done = false;
    while (!done)
    {
        Console.WriteLine($"What transation would you like to do? 1 - Withdraw, 2 - Deposit, or 3 - Quit? Current balance:{balance} & current money irl:{IRLmoney}");
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
                IRLmoney = (withdrawNumber);
                balance = (balance - 1);
            }
        }

        if (questionAwnser == 2)
        {
            Console.WriteLine("type in a number you wish to deposit.");
            depositNumber = Convert.ToInt32(Console.ReadLine());

            if (depositNumber > IRLmoney)
            {
                Console.WriteLine("you dont have enough money.");
            }
            if (depositNumber <= IRLmoney)
            {
                Console.WriteLine($"Okay taking out {depositNumber}");
                balance = (balance + depositNumber);
                IRLmoney = (IRLmoney - depositNumber);
                balance = (balance - 1);
            }
        }
        if (questionAwnser == 3)
        {
            Console.WriteLine("okay, bye!");
            done = true;
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
if (option < 3)
{
    Console.WriteLine("no (ignore this no if you picked 1, 2, or 3 person.)");
}