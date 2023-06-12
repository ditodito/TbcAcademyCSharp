// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter array size:");
int arrayLength;
while(!int.TryParse(Console.ReadLine(), out arrayLength) || arrayLength <= 0)
{
    Console.WriteLine("Invalid number, try again:");
}


//int[] numbers = new int[] { 0, -1, 2, 3, 0, 5, -10, 20, 0};
int[] numbers = generateArray(arrayLength);
Console.WriteLine("Array: " + string.Join(",", numbers));

int[] maxInterval = getArrayLargerInterval(numbers);
Console.WriteLine("Interval: " + string.Join(",", maxInterval));
int[] generateArray(int arrayLength) 
{
    int[] numbers = new int[arrayLength];

    for (int i = 0; i < numbers.Length; i++)
    {
        Console.WriteLine("Number {0}:", i);
        while (!int.TryParse(Console.ReadLine(), out numbers[i]))
        {
            Console.WriteLine("Invalid number, try again:");
        }
    }

    return numbers;
}

int[] getArrayLargerInterval(int[] numbers) {
    int[] result;
    int count = 0;
    int maxCount = 0;
    int index = 0;

    for (int i = 0; i < numbers.Length - 1; i++)
    {
        //Console.WriteLine(numbers[i] + " " + numbers[i + 1]);
        count = (numbers[i + 1] > numbers[i]) ? count + 1 : 0;

        if (count > 0 && count > maxCount)
        {
            maxCount = count;
            index = i + 1;
        }
    }

    result = new int[maxCount + 1];

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = numbers[index - maxCount + i];
    }

    return result;
}
