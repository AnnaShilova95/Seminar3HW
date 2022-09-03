/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
//Пользовательский ввод числа,создаем массив
int[] createArray(){
int[] myNum = new int[5];
for (int i = 0; i < myNum.Length; i++)
    {
    Console.Write("Введите одну цифру [" + i + "]:\t");
    myNum [i]  = int.Parse(Console.ReadLine());
    }
for (int i = 0; i < myNum.Length; i++)
    {
    Console.Write(myNum[i] + "");
    }
    return myNum;
}
Console.WriteLine("");
//Сравниваем числа 

int [] itogArr = createArray();
if (itogArr[0] == itogArr[4] && itogArr[1] == itogArr[3]){
    Console.WriteLine(" ОГО! Ваше число настоящий палиндромом!");
}
else{
    Console.WriteLine(" Увы");
}


//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2
// Задаем метод, считающий дейстивия под корнем

double average (double X1, double Y1, double Z1, double X2, double Y2, double Z2){
   double XYZ; 
   XYZ = (X2-X1)*(X2-X1) + (Y2-Y1)*(Y2-Y1)+(Z2-Z1)*(Z2-Z1);
   return XYZ;
}
double answer;

// Пользовательский ввод координат двух точек (1; 4,5 и тд)
Console.Write("Введите X1: ");
double X1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Y1: ");
double Y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите X2: ");
double Z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Y2: ");
double Y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите X3: ");
double X2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Y3: ");
double Z2 = Convert.ToDouble(Console.ReadLine());
//Считаем корень и выводим результат
answer = average (X1, Y1,Z1,X2,Y2,Z2);
Console.WriteLine(Math.Sqrt(answer));



//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//Задаем метод, считающий куб
void Cube(int n){
    int current = 1;
    while (current <= n){
        Console.Write(current*current*current + " ");
    current++;
    }
    
}
//Пользовательский ввод числа
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
//Если число больше нуля, то обращемся к методу
if (num <= 0) Console.WriteLine("Ошибка");
else Cube(num);


*/