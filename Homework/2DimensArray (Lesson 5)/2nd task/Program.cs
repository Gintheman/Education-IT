int [,] array = new int [3,3];
int [,] array2 = new int[array.GetLength(0), array.GetLength(1)];

void CreateArray()
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            System.Console.Write(array[i, j] + " ");

        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();  
}

void ChangeArray()
{
   int temp;
   for (int i = 0; i < array.GetLength(0); i++)
   {
      if (i == 0)
      {
         for (int j = 0; j < array.GetLength(1); j++)
         {
            temp = array[i,j];
            array[i,j] = array[array.GetLength(0)-1,j];
            array[array.GetLength(0)-1,j] = temp;
         }
         Console.WriteLine();

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






CreateArray();
ChangeArray();
PrintArray();


