// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter length or array (positive number):");
bool isValidLength = false;
int arrayLength = 0;

while (!isValidLength) {
    isValidLength = int.TryParse(Console.ReadLine(), out arrayLength) && arrayLength > 0;

    if (!isValidLength) {
        Console.WriteLine("Invalid number, try again:");
        continue;
    }
}

int[] numbers = new int[arrayLength];

Console.WriteLine("Enter {0} natural numbers:", numbers.Length);

for (int i = 0; i < numbers.Length; i++) {
    Console.WriteLine("Number {0}:", i);

    bool isValidNumber = false;

    while (!isValidNumber)
    {
        isValidNumber = int.TryParse(Console.ReadLine(), out numbers[i]) && numbers[i] > 0;

        if (!isValidNumber) {
            continue;
        }
    }
}

Console.WriteLine("Original array is: [{0}]", string.Join(", ", numbers));
// [5, 4, 1, 3, 8]
// [4, 5, 1, 3, 8]
// [1, 5, 4, 3, 8]

// [1, 4, 5, 3, 8]
// [1, 3, 5, 4, 8]

// [1, 3, 4, 5, 8]
// [1, 3, 4, 5, 8]

for (int i = 0; i < numbers.Length; i++) {

    for (int j = i + 1; j < numbers.Length; j++) {
        int temp = numbers[j];
        if (numbers[j] < numbers[i])
        {
            numbers[j] = numbers[i];
            numbers[i] = temp;
        }
    }


}

Console.WriteLine("Sorted array is: [{0}]", string.Join(", ", numbers));

