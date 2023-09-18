var rand = new Random();
int [] RandArray(int size, int min, int max)
{
    int [] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(min, max);
    }
    return array;
}
int count = 0;
int [] rand1 = RandArray(10,100,1000);
int Chet(int count)
{
    for (int i = 0; i < rand1.Length; i++)
    {   if (rand1[i]%2 == 0)
    {
        count++;
    }
       
    }
    return count;
}

int c = Chet(count); 
System.Console.WriteLine(string.Join(", ",rand1));
System.Console.WriteLine($"Колличество четных чисел в массиве = {c}");