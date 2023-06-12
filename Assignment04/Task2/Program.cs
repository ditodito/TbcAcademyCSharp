// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information

int arrayLength = getArraySize();
string[] arr1 = generateArray<string>(arrayLength);
//Console.WriteLine("Array1 is: [{0}]", string.Join(", ", arr1));

//int arrayLength2 = getArraySize();
int[] arr2 = generateArray<int>(arrayLength);
//Console.WriteLine("Array2 is: [{0}]", string.Join(", ", arr2));

string[] finalArr = new string[arr1.Length];

for (int i = 0; i < finalArr.Length; i++)
{
    finalArr[i] = arr1[1] + " " + arr2[i];
}
Console.WriteLine("Final is: [{0}]", string.Join(", ", finalArr));

int getArraySize() {
    Console.WriteLine("Enter array length (positive number):");
    bool isValidLength = false;
    int arrayLength = 0;

    while (!isValidLength)
    {
        isValidLength = Int32.TryParse(Console.ReadLine(), out int value) && value > 0;

        if (!isValidLength)
        {
            Console.WriteLine("You enter invalid number, try again:");
            continue;
        }

        arrayLength = value;
    }

    return arrayLength;
}

T[] generateArray<T>(int l) {
    T[] numbers = new T[l];

    Console.WriteLine(typeof(T).FullName);

    Console.WriteLine("Enter {0} value:", numbers.Length);

    for (int i = 0; i < numbers.Length; i++)
    {
        //bool isValid = typeof(T).TryParse(Console.ReadLine(), out T value);
        /* Console.WriteLine("Value {0}:", i);

         bool isValidNumber = false;

         while (!isValidNumber)
         {
             isValidNumber = int.TryParse(Console.ReadLine(), out T value) && value > 0;
             //isValidNumber = Console.ReadLine();
             isValidNumber = ;

             if (!isValidNumber)
             {
                 continue;
             }

             numbers[i] = Console.ReadLine();
         }*/
        //int.TryParse(Console.ReadLine(), out T value) && value > 0;
        numbers[i] = (T) Convert.ChangeType(Console.ReadLine(), typeof(T));
    }

    return numbers;
}




