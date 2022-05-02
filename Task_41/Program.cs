// Пользователь вводит с клавиатуры М чисел. Посчитайте сколько чисел больше 0 ввёл пользователь
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223 -> 3

Console.WriteLine("Введите несколько отрицательных и положительных чисел через запятую");
string M = Console.ReadLine(); // задаём строку для введения числа
string[] Mass = M.Split(','); // считывание строки с числами, как массива

int[] mass = new int[Mass.Length]; 

    int result = 0; // для хранения результатов для начала равное нулю
    for (int i = 0; i < Mass.Length; i++) 
    {
        int num = Convert.ToInt32(Mass[i]);
        if(num > 0)
        result ++;
    }
    System.Console.WriteLine(result);
