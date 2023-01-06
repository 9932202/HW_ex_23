// программа принимает 2 числа и проверяет является
// ли одно число квадратом второго

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 == num2 * num2 || num2 == num1 * num1 ){
    Console.WriteLine("Является квадратом ");
}
else{
    Console.WriteLine("Не является квадратом ");
}
   
   
   

   //Console.WriteLine($"{result}");






 /* 
     int DivideResult(int num1, int num2) {
        
        if(num1 > num2){   
        int result = num1 / num2;
        return result;
    }
    else{
        int result = num2 / num1;
        return result;
    }
    }
    


   int result = DivideResult(num1, num2);


     
     
     
     int DivideResult(int num1, int num2) {
        
        if(num1 > num2){
        int result = num1 / num2;
        return result;
    }
    else{
        int result = num2 / num1;
        return result;
    }
    }
   int result2 = DivideResult(num1, num2);
   Console.WriteLine($"{result2}");




*/


