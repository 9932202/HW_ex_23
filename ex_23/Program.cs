/* Задача 23

Напишите программу, которая принимает на вход число (N)
и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int GetUserValue(string message){
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

int userNumber = GetUserValue("Введите число: ");
int i = userNumber;
while(i > 0){
int result = i*i*i;
Console.WriteLine(result);
i=i - 1;
}



//Console.WriteLine("Hello, World!");


