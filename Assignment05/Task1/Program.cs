// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] numbers = new int[] { 2, 127, 123, 0, 15 };
int sum = sumOfDigit(numbers, 2);
Console.WriteLine(sum);

int sumOfDigit(int[] numbers, int index) {
    int number = 0;

    /*for (int i = 0; i < numbers.Length; i++) {
        if (i == index) {
            number = numbers[i];
            break;
        }
    }*/

    return getSumOfDigit(numbers[index]);
}

int getSumOfDigit(int n) {
    int result = 0;
    int number = Math.Abs(n);
    int tempNumber;

    while (number % 10 > 0)
    {
        tempNumber = number / 10;
        
        result = (tempNumber > 0) ? result + number % 10 :
            (n > 0) ? result + number : result - number;
    
        number = tempNumber;
    }

    return result;
}
