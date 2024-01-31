
using System;

namespace Program
{

    class dvuhmassive
    {
        int[,] array;

        public dvuhmassive(bool user, int n, int c)
        {
            if (user == true)
            {
                array = sozdanieuser(n, c);
            }
            else
            {
                array = sozdaniernd(n, c);
            }
        }


        static int[,] sozdanieuser(int n, int c)
        {
            int[,] l = new int[n, c];
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j<c; j++)
                {
                    Console.WriteLine("Y: " + i + "X: " + j);
                    l[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return l;
        }
        static int[,] sozdaniernd(int n, int c)
        {
            Random rnd = new Random();
            int[,] mas = new int[n, c];
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < c; j++)
                {
                    int r = rnd.Next(1, 200); 
                    mas.SetValue(r, i, j);
                }
            }
            return mas;
        }

        public decimal nomerodin(int n, int c)
        {
            int[,] l = array;
            decimal summ = 0;
            decimal sred = 0;
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < c; j++)
                {
                    summ += array[i, j] ;
                    int len = l.Length;
                    sred = summ / len;
                }
            }

            return sred;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите true если хотите ввод с клавиатуры, если хотите с помощью рандома, напишите false");
            bool user = bool.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов в двухмерном массиве");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество строк в двухмерном массиве");
            int c = int.Parse(Console.ReadLine());
            dvuhmassive array = new dvuhmassive(user, n, c);
            decimal s = array.nomerodin(n, c);
            Console.WriteLine($"Среднее кол-во элементов в массиве: {s}");
            

            
        }
    }
}
