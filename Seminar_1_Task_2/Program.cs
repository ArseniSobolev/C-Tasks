Console.Write("enter number N ");
string numberN = Console.ReadLine();
int number = int.Parse(numberN);
int chetnye = 2;

while (chetnye <= number)
{
    if (chetnye % 2 == 0)
    {
        Console.WriteLine(chetnye);
    }
    chetnye = chetnye + 1;
}