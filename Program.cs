//Вид 1

void Method1()
{
    Console.WriteLine("Автор...");
}

//Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

Method2("Текст сообщения");
Method21("text", 4);
Method1();

//Вид 3

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

//Вид 4

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "asdf");
Console.WriteLine(res);

string Method5(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count;)
    {
        result = result + text;
        i++;
    }
    return result;
}

string reс = Method5(10, "asdf");
Console.WriteLine(reс);

for (int i = 2; i <= 10;i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}
int [] arr = {1,2,3,4,5,6,7,8,9,10,2,4,5,6,7,3,2,2};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i =0; i < count; i++)
    {
        Console.Write($"{array[i]}");

    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
        
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);