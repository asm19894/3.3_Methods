// Напишите программу, которая принимает на вход число N 
//и выдаёт произведение чисел от 1 до N.

//4-> 24
//5-> 120 == 1 * 2 * 3 * 4 * 5


int MoulNumber (int n) {
    int moul = 1;
    for (int i = 1; i <= n; i++)
        moul = moul * i;
    return moul;
}

Console.WriteLine("Введите целое число: ");
int s = int.Parse(Console.ReadLine());
Console.WriteLine($"Произведение чисел равно {MoulNumber(s)}");
