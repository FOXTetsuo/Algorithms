// See https://aka.ms/new-console-template for more information
int GridSize = 15;
bool[,] currentArray = new bool[GridSize, GridSize];
currentArray[5, 6] = true;
currentArray[5, 7] = true;
currentArray[4, 6] = true;
currentArray[4, 7] = true;

void Propagate()
{
        // Loop over the 2D array
        for (int x = 0; x < GridSize; x++)
        {
                for (int y = 0; y < GridSize; y++)
                {
                        bool population = currentArray[x, y];

                        int amountOfAliveNeighbors = 0;
                        if (GetNeighbor(x - 1, y + 1)) amountOfAliveNeighbors++;
                        if (GetNeighbor(x, y + 1)) amountOfAliveNeighbors++;
                        if (GetNeighbor(x + 1, y + 1)) amountOfAliveNeighbors++;
                        if (GetNeighbor(x + 1, y)) amountOfAliveNeighbors++;
                        if (GetNeighbor(x + 1, y - 1)) amountOfAliveNeighbors++;
                        if (GetNeighbor(x, y - 1)) amountOfAliveNeighbors++;
                        if (GetNeighbor(x - 1, y - 1)) amountOfAliveNeighbors++;
                        if (GetNeighbor(x - 1, y)) amountOfAliveNeighbors++;

                        if (population && amountOfAliveNeighbors < 2) currentArray[x, y] = false;
                        else if (population && (amountOfAliveNeighbors == 2 || amountOfAliveNeighbors == 3)) currentArray[x, y] = true;
                        else if (population && amountOfAliveNeighbors > 3) currentArray[x, y] = false;
                        else if (!population && amountOfAliveNeighbors == 3) currentArray[x, y] = true;
                }
        }
}

bool GetNeighbor(int x, int y)
{
        if (x < 0) x = GridSize - 1;
        if (y < 0) y = GridSize - 1;
        if (x >= GridSize) x = 0;
        if (y >= GridSize) y = 0;
        return currentArray[x, y];
}

void PrintAll()
{
        for (int x = 0; x < GridSize; x++)
        {
                Console.WriteLine();
                for (int y = 0; y < GridSize; y++)
                {
                        bool population = currentArray[x, y]; // Access the value at position [i, j]
                        if (population) Console.Write("1");
                        else Console.Write("0");
                }

        }
}

while (true)
{
        PrintAll();
        Thread.Sleep(2000);
        Console.Clear();
        Propagate();
}

