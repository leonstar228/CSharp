Console.WriteLine("Starting game");
double HP = 50;
double money = 1000;
double happy = 20;
double fullness = 20;
double intelegence = 20;

while (true)
{
    Console.WriteLine();
    Console.WriteLine("==================================");
    Console.WriteLine("1) Sleep");
    Console.WriteLine("2) Eat");
    Console.WriteLine("3) Drink (Byhat)");
    Console.WriteLine("4) Fight with homeless");
    Console.WriteLine("5) Study");
    Console.WriteLine("6) Work");
    Console.WriteLine("7) Try temky");
    Console.WriteLine("8) Show stats");
    Console.Write("Enter command: ");
    int result = Convert.ToInt32(Console.ReadLine());
    if (HP <= 0 || money <= 0 || happy <= 0 || fullness <= 0 || intelegence <= 0)
    {
        Console.WriteLine("Some of your stats less or equal 0. Game over :(");
    }
    else
    {
        if (result == 1)
        {
            Console.WriteLine("How much time do you want to sleep?(max = 24): ");
            double hours = Convert.ToDouble(Console.ReadLine());
            if (Sleep(hours))
            {
                Console.WriteLine("Student slept well!");
            }
            else
            {
                Console.WriteLine("Incorrect data");
            }
        }
        else if (result == 2)
        {
            Eat();
            Console.WriteLine("Student ate succesfully!");
        }
        else if (result == 3)
        {
            Console.WriteLine("How many bottles you wanna drink?(max = 6): ");
            int bottles = Convert.ToInt32(Console.ReadLine());
            if (Drink(bottles))
            {
                Console.WriteLine("Student drank perfectly!");
            }
            else
            {
                Console.WriteLine("Incorrect data");
            }
        }
        else if (result == 4)
        {
            Fight();
            Console.WriteLine("Student fought with homeless :(");
        }
        else if (result == 5)
        {
            Console.WriteLine("How many hours you wanna study?(max = 16): ");
            int hours = Convert.ToInt32(Console.ReadLine());
            if (Drink(hours))
            {
                Console.WriteLine("Student studied perfectly!");
            }
            else
            {
                Console.WriteLine("Incorrect data");
            }
        }
        else if (result == 6)
        {
            Console.WriteLine("How many hours you wanna work?(max = 20): ");
            int hours = Convert.ToInt32(Console.ReadLine());
            if (Drink(hours))
            {
                Console.WriteLine("Student worked perfectly!");
            }
            else
            {
                Console.WriteLine("Incorrect data");
            }
        }
        else if (result == 7)
        {
            TryTheme();
        }
        else if (result == 8)
        {
            Show();
        }
        else { Console.WriteLine("Incorrect choose, try another one!"); }
    }
}


bool Sleep(double hours)
{
    if (hours <= 0 || hours > 24)
    {
        return false;
    }
    else
    {
        while (hours != 0)
        {
            HP += 1.5;
            happy += 0.5;
            hours--;
            fullness -= 2;
        }
        return true;
    }
}
void Eat()
{
    HP += 5;
    money -= 150;
    happy += 3;
    fullness += 30;
}
bool Drink(int bottles)
{
    if (bottles <= 0 || bottles > 6)
    {
        return false;
    }
    else
    {
        while (bottles != 0)
        {
            HP -= 5;
            money -= 150;
            happy += 2;
            fullness += 1;
            intelegence -= 1;
            bottles--;
        }
        return true;
    }
}

void Fight()
{
    HP -= 15;
    happy -= 20;
    intelegence -= 5;
}
bool Study(int hours)
{
    if (hours <= 0 || hours > 17)
    {
        return false;
    }
    else
    {
        while (hours != 0)
        {
            HP -= 1;
            happy += 2;
            intelegence += 2;
            hours--;
        }
        return true;
    }
}

bool Work(int hours)
{
    if (hours <= 0 || hours > 21)
    {
        return false;
    }
    else
    {
        while (hours != 0)
        {
            HP -= 2;
            money += 100;
            happy -= 1;
            intelegence += 1;
            hours--;
        }
        return true;
    }
}

void TryTheme()
{
    Random rnd = new Random();

    Console.WriteLine("Choose a theme:");
    Console.WriteLine("1 - Easy Theme (70% success chance)");
    Console.WriteLine("2 - Medium Theme (50% success chance)");
    Console.WriteLine("3 - Hard Theme (30% success chance)");
    Console.Write("Enter your choice (1-3): ");

    int choice = Convert.ToInt32(Console.ReadLine());
    int roll = rnd.Next(1, 101);

    bool success = false;

    switch (choice)
    {
        case 1: // Easy Theme
            success = roll <= 70;
            if (success)
            {
                HP += 5;
                money += 1000;
                happy += 10;
                Console.WriteLine("Success! Easy theme boosted your stats.");
            }
            else
            {
                HP -= 2;
                money -= 200;
                happy -= 5;
                Console.WriteLine("Failure! Easy theme cost you a bit.");
            }
            break;

        case 2: // Medium Theme
            success = roll <= 50;
            if (success)
            {
                HP += 10;
                money += 3000;
                happy += 20;
                Console.WriteLine("Success! Medium theme gave you solid rewards.");
            }
            else
            {
                HP -= 5;
                money -= 1000;
                happy -= 10;
                Console.WriteLine("Failure! Medium theme backfired.");
            }
            break;

        case 3: // Hard Theme
            success = roll <= 30;
            if (success)
            {
                HP += 20;
                money += 10000;
                happy += 40;
                Console.WriteLine("Success! Hard theme paid off massively!");
            }
            else
            {
                HP -= 10;
                money -= 3000;
                happy -= 20;
                Console.WriteLine("Failure! Hard theme was a big loss.");
            }
            break;

        default:
            Console.WriteLine("Invalid choice!");
            return;
    }
}

void Show()
{
    Console.WriteLine($"Health: {HP}");
    Console.WriteLine($"Money: {money}");
    Console.WriteLine($"Happiness: {happy}");
    Console.WriteLine($"Fullness: {fullness}");
    Console.WriteLine($"Intelegence: {intelegence}");
}