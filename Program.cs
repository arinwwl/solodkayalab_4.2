int n = 4; 
int m = 6; 
int[][] A = new int[n][];
for (int i = 0; i < n; i++)
{
    A[i] = new int[m];
}

int currentValue = 0;
for (int i = 0; i < n; i++)
{
    if (i % 2 == 0) 
    {
        for (int j = 0; j < m; j++)
        {
            A[i][j] = currentValue++;
        }
    }
    else 
    {
        for (int j = m - 1; j >= 0; j--)
        {
            A[i][j] = currentValue++;
        }
    }
}


for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(A[i][j] + " ");
    }
    Console.WriteLine();
}
   