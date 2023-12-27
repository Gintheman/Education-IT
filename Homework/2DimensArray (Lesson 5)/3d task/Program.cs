int [,] array = new int [3,5];

void CreateArray()
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray() 
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void FindMinSum()
{
    int sumElement = 0;
    int min = 100;
    int index = 0;

    for(int i = 0; i < array.GetLength(0); i++)
    {
        
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sumElement += array[i, j];
            
            
        }
        System.Console.WriteLine($"{sumElement}");
        
        if(min > sumElement)
        {   
            min = sumElement;
            index = i;
        }

        
       
        
        
    }
    System.Console.WriteLine($"Минимальная сумма в строке {index}");
    







}

CreateArray();
PrintArray();
FindMinSum();