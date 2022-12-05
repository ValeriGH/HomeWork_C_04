// Задача на суперсдвиг. Положительное число - сдвиг вправо, отрицательное - влево.
Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите {i + 1} элемент массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Введите число для сдвига: ");
int k = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(k) > n) k %= n;
if (k > 0)
    k = n - k;
else if (k < 0)
    k = Math.Abs(k);

Console.WriteLine($"Число: {k}");
for (int i = k; i < n; i++)
    Console.Write($"{array[i]} ");
for (int i = 0; i < k; i++)
    Console.Write($"{array[i]} ");