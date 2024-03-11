using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[0];
        int[] arr2 = new int[0];
        int[] arrtrans = new int[0];
        ConsoleKeyInfo K;
        do
        {
            Console.Clear();
            Console.WriteLine("1.Создать массив");
            Console.WriteLine("2.Вывести исходный массив");
            Console.WriteLine("3.Быстрая Сортировка");
            Console.WriteLine("4.Сортировка выбором");
            Console.WriteLine("5.Вывести отсортированный массив");
            Console.WriteLine("Esc. Выход из программы");
            K = Console.ReadKey();
            switch (K.Key)
            {
                case ConsoleKey.D1: case ConsoleKey.NumPad1: // если нажата клавиша с цифрой 1
                    {
                        arr = Input();
                        arr2 = Copy(arr);
                        break;
                    }
                case ConsoleKey.D2: case ConsoleKey.NumPad2:// если нажата клавиша с цифрой 2
                    {
                        Output(arr2);
                        // действие 
                        break;
                    }
                case ConsoleKey.D3: case ConsoleKey.NumPad3:// если нажата клавиша с цифрой 3
                    {
                        try
                        {
                            arr = Copy(arr2);
                            arrtrans = QuickSortvoid(arr);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        } 
                        break;
                    }
                case ConsoleKey.D4: case ConsoleKey.NumPad4:// если нажата клавиша с цифрой 4
                    {
                        try
                        {

                            arr = Copy(arr2);
                            arrtrans = SelectionSortvoid(arr);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    }
                case ConsoleKey.D5: case ConsoleKey.NumPad5:// если нажата клавиша с цифрой 5
                    {
                        if (arrtrans == arr)
                        {
                            Outputtrans(arrtrans);
                        }
                        else
                        {
                            Console.WriteLine("\nМассив не отсортирована");
                        }
                        break;
                    }
                default: break;
            }
            System.Threading.Thread.Sleep(2000); // 2 сек.
        }
        while (K.Key != ConsoleKey.Escape);
    }
    static int[] Copy(int[] arr)
    {
        int[] arr2 = new int[arr.Length];
        Array.Copy(arr, arr2, arr.Length);
        return arr2;
    }
    static int[] Input()
    {
        int[] arr = new int[0];
        try
        {
            Console.WriteLine("\nВведите размерность массива.");
            int N = int.Parse(Console.ReadLine());
            if (N <= 0)
            {
                throw new Exception("Данные массива введены неверно!!!");
            }
            arr = Input(N);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex.Message}");
        }
        return arr;
    }
    static int[] Input(int N)
    {
        int[] arr = new int[N];
        Random r = new Random();
        for (int i = 0; i < N; i++)
        {
            arr[i] = r.Next(-100, 100);
        }
        return arr;
    }
    static int[] QuickSort(int[] arr, int low, int high) //метод реализации быстрой сортировкой. Он принимает массив для сортировки, а также индексы начала и конца сортировки.
    {
        if (low < high)
        {
            int pi = Part(arr, low, high);
            QuickSort(arr, low, pi - 1);
            QuickSort(arr, pi + 1, high);
        }return arr;
        
    }
    static int Part(int[] arr, int low, int high) // этот метод является частью алгоритма быстрой сортировки и выполняет разделение массива на две части относительно опорного элемента.
    {
        int pivot = arr[high];
        int i = low - 1;
        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr [j] = temp;
            }
        }
        int temp1 = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = temp1;

        return i + 1;
    }
    static int[] SelectionSort(int[] arr) // сортировка выбором. Проходит по всем элементам массива находя минимальный и определяя его в новый массив удаляя его из старого и так до конца.
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        } return arr;
    }
    static void Outputtrans(int[] arr)
    {
        Console.WriteLine("\nПеределанный массив: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + "\t");
        }
    }
    static void Output(int[] arr)
    {
        Console.WriteLine("\nНачальный массив: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + "\t");
        }
    }
    static int[] SelectionSortvoid(int[] A)
    {
        int[] arr = new int[0];
        if (A.Length > 0)
        {
            Stopwatch SelectionSortTime = new Stopwatch();
            SelectionSortTime.Start();
            arr = SelectionSort(A);
            SelectionSortTime.Stop();
            Console.WriteLine();
            Console.WriteLine("Время на сортировку: " + SelectionSortTime.Elapsed.TotalMilliseconds);
        }
        else
        {
            Console.WriteLine("Ошибка, введите данные массива верно!");
        }
        return A;
    }
    static int[] QuickSortvoid(int[] A)
    {
        int[] arr = new int[0];
        if (A.Length > 0)
        {
            Stopwatch QuickSortTime = new Stopwatch();
            QuickSortTime.Start();
            arr = QuickSort(A, 0, arr.Length);
            QuickSortTime.Stop();
            Console.WriteLine();
            Console.WriteLine("Время на сортировку: " + QuickSortTime.Elapsed.TotalMilliseconds);
        }
        else
        {
            Console.WriteLine("Данные массива ведены неверно!!");
        }
        return A;
    }
}

