// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//type casting 

//implicit typecasting
//int b = 15;
//double a;
//a = b;

//explicit typecasting
//int bc;
//double ac = 15.2D;
//bc = (int)ac;

//int xyz = Convert.ToInt32(ac);
//scan an input

//int name = Convert.ToInt32(Console.ReadLine());

//foreach loop
//int[] arr = { 1, 2, 3, 4, 5};

//foreach (int item in arr)
//{
//    Console.WriteLine(item);
//}

//binary search implementation

int[] array = { 1, 2, 3, 4, 8, 0 };
Array.Sort(array);
int key = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(BinarySearch(array, key));
static string BinarySearch(int[] arr, int key)
{
    int min = 0;
    int max = arr.Length - 1;
    int mid = 0;

    while (min <= max)
    {
        mid = (min + max) / 2;

        if (key == arr[mid])
            return "Found";
        else if (key < arr[mid])
            max = mid - 1;
        else if (key > arr[mid])
            min = mid + 1;

    }
    return "Not Found";



}