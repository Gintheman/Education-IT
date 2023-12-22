


int [,] array = new int [5,3];

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

void FindElement ()
{
    

    Console.WriteLine($"Enter the 1st index: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Enter the 2nd index: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    if(num1 < array.GetLength(0) && num2 < array.GetLength(1))
    {
        
        System.Console.WriteLine($"{array[num1, num2]}");
        
    }  
    else
    {
        System.Console.WriteLine($"No such element. Try again");
    }
    
}


CreateArray();
PrintArray();
FindElement();

