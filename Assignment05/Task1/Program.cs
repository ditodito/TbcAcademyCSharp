// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] numbers = new int[] { 2, 127, 123, 0, 15 };
int sum = sumOfDigit(numbers, 2);
Console.WriteLine(sum);

int sumOfDigit(int[] numbers, int index) {
    int result = 0;
    int number = 0;

    for (int i = 0; i < numbers.Length; i++) {
        if (i == index) {
            number = numbers[i];
            break;
        }
    }

    while (number % 10 > 0) {
        result += number % 10;
        number = number / 10;
    }

    return result;
}
