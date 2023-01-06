/* Задача 19

Напишите программу, которая принимает на вход пятизначное число
 и проверяет, является ли оно палиндромом. 
 */

int GetUserValue(string message){
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

int GetReversNumber(int number){
    int revers = 0;
    while(number > 0){
        revers = revers * 10 + number % 10;
        number = number / 10;
    }
    return revers;
}



int UserNum = GetUserValue("Введите число:  ");
int reversNumber = GetReversNumber(UserNum);

if(UserNum == reversNumber){
    Console.WriteLine($"Да. {UserNum} -  палиндром.");
}
else{
    Console.WriteLine($"Нет. {UserNum} -  Не является палиндромом.");
}



//Console.WriteLine(reversNumber); 


//Console.WriteLine("Hello, World!");
