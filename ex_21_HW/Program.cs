/* 21 Напишите программу, которая принимает на вход 
координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53

A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/

int GetUserValue(string message){
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}


double GetDistanceFromCoordinate(int X1, int Y1, int X2, int Y2, int Z1, int Z2){
    double result = Math.Sqrt(Math.Pow((X2-X1), 2) + Math.Pow((Y2-Y1), 2)+ Math.Pow((Z2-Z1), 2));
    return result;
    
}

int userX1 = GetUserValue("Введите координаты первой точки Х : ");
int userY1 = GetUserValue("Введите координаты первой точки Y : ");
int userZ1 = GetUserValue("Введите координаты первой точки Z : ");
int userX2 = GetUserValue("Введите координаты второй точки Х : ");
int userY2 = GetUserValue("Введите координаты второй точки Y : ");
int userZ2 = GetUserValue("Введите координаты второй точки Z : ");

double distance = GetDistanceFromCoordinate(userX1, userY1, userX2, userY2, userZ1,userZ2 );
Console.WriteLine($"Расстояние между этими точками = {Math.Round(distance, 2)}");
