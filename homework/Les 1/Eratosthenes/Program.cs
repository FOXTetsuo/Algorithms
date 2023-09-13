// See https://aka.ms/new-console-template for more information

int maxNumber = 30;
bool[] isPrime = new bool[maxNumber + 1];

// make array of numbers
for (int i = 2; i <= maxNumber; i++)
{
    isPrime[i] = true;
}

// sieve that stuff
for (int i = 2; i * i <= maxNumber; i++)
{
    if (isPrime[i])
    {
        for (int k = i * i; k <= maxNumber; k += i)
        {
            isPrime[k] = false;
        }
    }
}

// print
for (int i = 2; i <= maxNumber; i++)
{
    if (isPrime[i])
    {
        Console.WriteLine(i);
    }
}
