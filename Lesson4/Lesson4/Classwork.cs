////приклад1

//static void MyMethod1()
//{
//    Console.WriteLine("I just got executed!");
//}

//MyMethod1();
//MyMethod1();
//MyMethod1();
//MyMethod1();


////приклад2
//static void MyMethod2(string fname)
//{
//    Console.WriteLine(fname + "Congratulation");
//}

//MyMethod2("Liam");
//MyMethod2("Jenny");
//MyMethod2("Anja");


////приклад3
//static void MyMethod3(string country = "Norway")
//{
//    Console.WriteLine(country);
//}

//MyMethod3("Sweden");
//MyMethod3("India");
//MyMethod3();
//MyMethod3("USA");


////приклад4
//static void MyMethod4(string fname, int age)
//{
//    Console.WriteLine(fname + " is " + age);
//}

//MyMethod4("Liam", 5);
//MyMethod4("Jenny", 8);
//MyMethod4("Anja", 31);


////приклад5
//static int MyMethod5(int x)
//{
//    return 5 + x;
//}
//Console.WriteLine(MyMethod5(3));


////приклад6
//static string MyMethod6(string x)
//{
//    return x + "Hello World!";
//}
//Console.WriteLine(MyMethod6("Hi "));


////приклад7
//static void MyMethod7(string child1, string child2, string child3)
//{
//    Console.WriteLine("The youngest child is: " + child3);
//}
//MyMethod7(child3: "John", child1: "Lian", child2: "Liam");



////приклад8 (приклад перевантаження методу PlusMethod)

//class Program
//{
//    static int PlusMethod(int x, int y)
//    {
//        return x + y;
//    }

//    static double PlusMethod(double x, double y)
//    {
//        return x + y;
//    }

//    static void Class()
//    {
//        int myNum1 = PlusMethod(8, 5);
//        double myNum2 = PlusMethod(4.3, 6.26);
//        Console.WriteLine("Int: " + myNum1);
//        Console.WriteLine("Double: " + myNum2);
//    }
//}



////приклад9 (приклад2 перевантаження методу PlusMethod)
//Lesson4 less = new Lesson4();
//int myNum1 = less.PlusMethod(8, 5);
//double myNum2 = less.PlusMethod(4.3, 6.26);
//Console.WriteLine("Int: " + myNum1);
//Console.WriteLine("Double: " + myNum2);
//class Lesson4
//{
//    public int PlusMethod(int x, int y)
//    {
//        return x + y;
//    }
//    public double PlusMethod(double x, double y)
//    {
//        return x + y;
//    }
//}


////приклад10 (повний запис)
//void SayHello1()
//{
//    Console.WriteLine("Hello!");
//}

//SayHello1();


////приклад11 (скорочений запис)
//void SayHello2() => Console.WriteLine("Hello!");

//SayHello2();


////приклад12 (повний запис)
//string GetMessage()
//{
//    return "Hello!";
//}

//GetMessage();


////приклад13 (скорочений запис)
//string GetMessage() => "Hello!";

//GetMessage();


////приклад14 (без ref)
//void Increment1(int n)
//{
//    n++;
//    Console.WriteLine($"Число в методі Increment: {n}");
//}
//int number1 = 5;
//Console.WriteLine($"Число до методу Increment: {number1}");
//Increment1(number1);
//Console.WriteLine($"Число після методу Increment: {number1}");


////приклад14 (з ref)
//void Increment2(ref int n)
//{
//    n++;
//    Console.WriteLine($"Число в методі Increment: {n}");
//}
//int number2 = 5;
//Console.WriteLine($"Число до методу Increment: {number2}");
//Increment2(ref number2);
//Console.WriteLine($"Число після методу Increment: {number2}");


////приклад15 (з out)
//void Sum(int x, int y, out int result)
//{
//    result = x + y;
//}
//int number;
//Sum(10, 15, out number);
//Console.WriteLine(number);


////приклад16 (помилка з out )
//void Sum(int x, int y, out int result)
//{
//    Console.WriteLine(x + y);
//}


////приклад17 (з out)
//void GetRectangleData(int width, int height, out int rectArea, out int rectPerimetr)
//{
//    rectArea = width * height;       // Плоша прямокутника - множення ширини на висоту
//    rectPerimetr = (width + height) * 2; // Периметр прямокутника - сума довжин всіх сторін  
//}
//int area;
//int perimetr;
//GetRectangleData(10, 20, out area, out perimetr);
//Console.WriteLine($"Площа прямокутника: {area}");
//Console.WriteLine($"Периметр прямокутника: {perimetr}");


////приклад18 (Факторіал та його обчислення)
////n! = 1 * 2 * ... * n

//int Factorial(int n)
//{
//    if (n == 1) return 1;
//    return n * Factorial(n - 1);
//}
//int factorial4 = Factorial(4);  // відповідь: 24
//int factorial5 = Factorial(5);  // відповідь: 120
//int factorial6 = Factorial(6);  // відповідь: 720
//Console.WriteLine($"Факторіал числа 4 = {factorial4}");
//Console.WriteLine($"Факторіал числа 5 = {factorial5}");
//Console.WriteLine($"Факторіал числа 6 = {factorial6}");