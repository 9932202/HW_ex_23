/* программа выводит случайное трехзначное число 
и удаляет вторую цифру этого числа*/
Console.Clear();

int GetNumberFromRandom(int start, int end){
    int number = new Random().Next(start, end);
    return number;
}

int DelitDigit(int number){
    int digit3 = number / 100;
    int digit1= number % 10;
    int result = digit3 * 10 + digit1;
    return result;
}
int resultNumber = GetNumberFromRandom(100, 1000);
Console.WriteLine(resultNumber);
int DeletedNumber = DelitDigit(resultNumber);
 Console.WriteLine(DeletedNumber);