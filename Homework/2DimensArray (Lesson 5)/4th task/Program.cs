int[,] array1 = new int[2, 3];
int[,] array2 = new int[array1.GetLength(0) - 1, array1.GetLength(1) - 1]; 
int min = array1[1, 1];
int stringIndex = 0;
int columnIndex = 0;

void CreateArray()
{
    for(int i = 0; i < array1.GetLength(0); i++)
    {
        for(int j = 0; j < array1.GetLength(1); j++)
        {
            array1[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray1() 
{
    for(int i = 0; i < array1.GetLength(0); i++)
    {
        for(int j = 0; j < array1.GetLength(1); j++)
        {
            System.Console.Write(array1[i, j] + " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void FindMinElement()
{
    
    for(int i = 0; i < array1.GetLength(0); i++)
    {
        for(int j = 0; j < array1.GetLength(1); j++)
        {
            if(array1[i, j] < min)
            {
                min = array1[i, j];
                stringIndex = i;
                columnIndex = j;

            }
            

        }
        
        
    }
    Console.WriteLine($"{min}");
    
    
}

void PrintArray2()
{
    for(int i = 0; i < array2.GetLength(0); i++)
    {
        for(int j = 0; j < array2.GetLength(1); j++)
        {
            if(i != stringIndex || j != columnIndex)
            {
                array2[i, j] = array1[i, j];
                System.Console.Write(array2[i, j] + " ");
            }
            else
            {
                i++;
                j++;
            }
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}


CreateArray();
PrintArray1();
FindMinElement();
PrintArray2();