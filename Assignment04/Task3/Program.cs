// See https://aka.ms/new-console-template for more information

int[] arr1 = readArray(1);
int[] arr2 = readArray(2);
int[] arr3 = arrayConcat(arr1, arr2);
//int[] arr1 = new int[] { 4, 6, 2, 9 };
//int[] arr2 = new int[] { -1, 17, -4, 3 };
//int[] arr3 = arr1.Concat(arr2).ToArray();

Console.WriteLine("Enter order type: (asc or desc)");
string orderType = Console.ReadLine().ToLower() == "desc" ? "desc" : "asc";

sortArray(arr3, orderType);
Console.WriteLine(string.Join(" ", arr3));
//Array.Sort(arr3);
//Console.WriteLine(string.Join(" ", arr3.Reverse().ToArray()));

int[] readArray(int arrayOrder)
{
    Console.WriteLine("Enter array {0} number elements, seperated by space:", arrayOrder);
    string[] strings = Console.ReadLine().Split(" ");
    int[] result = new int[strings.Length];

    for (int i = 0; i < strings.Length; i++)
    {
        int.TryParse(strings[i], out result[i]);
    }

    //Console.WriteLine(string.Join(" ", result));
    return result;
}

int[] arrayConcat(int[] arr1, int[] arr2) {
    int[] result = new int[arr1.Length + arr2.Length];
    
    //result = arr1.Concat(arr2).ToArray();
    //return result;
    
    int ind = 0;
   
    foreach(int i in arr1)
    {
        result[ind] = i;
        ind++;
    }

    foreach (int i in arr2)
    {
        result[ind] = i;
        ind++;
    }

    return result;
}

void sortArray(int[] arr, string orderType)
{
    for(int i = 0; i < arr.Length; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            int temp = arr[j];
            if ((arr[j] < arr[i] && orderType == "asc") || (arr[j] > arr[i] && orderType == "desc"))
            {
                arr[j] = arr[i];
                arr[i] = temp;
            }
        }
    }
}