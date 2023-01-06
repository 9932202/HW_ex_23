/*
программа выводит случайное число из отрезка (10,  99 )
и показывает наибольшую цифру числа 
*/
Console.Clear();
int GetNumberFromRandom(int start, int end){
    int number = new Random().Next(start, end+1);
    return number;
}


int GetMaxDigit(int number){
    int digit1 = number % 10;
    int digit2 = number / 10;
    if(digit1 > digit2){
        Console.WriteLine($"Максимальная цифра числа = {digit1}");
        return digit1;
    }
    else{
        Console.WriteLine($"Максимальная цифра числа = {digit2}");
        return digit2;
    }
}

int RandomNumber = GetNumberFromRandom(10, 99);
Console.WriteLine(RandomNumber);
int maxDigit = GetMaxDigit(RandomNumber);

