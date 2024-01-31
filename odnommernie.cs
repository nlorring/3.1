using System;

namespace Program
{

    class odnommassive
    {
        int[] array;
        int[] array2;

        public odnommassive(bool user, int n)
        {
            if (user == true)
            {
                array = sozdanieuser(n);
            }
            else
            {
                array = sozdaniernd(n);
            }
        }


        static int[] sozdanieuser(int n)
        {
            int[] l = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите элемент {i + 1}");
                int d = int.Parse(Console.ReadLine());
                l.SetValue(d, i);
            }
            return l;
        }
        static int[] sozdaniernd(int n)
        {
            Random rnd = new Random();
            int[] mas = new int[n];
            for (int i = 0; i < n; i++)
            {
                int r = rnd.Next(1, 200);
                mas.SetValue(r, i);
            }
            return mas;
        }

        public int[] nomerdva()
        {
            int n = array.Length;
            int[] d = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (Math.Abs(array[i]) <= 100)
                {
                    d.SetValue(array[i], i);

                }
            }
            return d;
        }

        public int[] nomertri()
        {
            int n = array.Length;
            int[] res = new int[n];
            int k = 0;
            bool f;
            foreach (int i in array)
            {
                f = true;
                for (int j = 0; j < k; j++)
                {
                    if (i == res[j])
                    {
                        f = false;
                    }
                }
                if (f)
                {
                    res[k] = i;
                    k += 1;
                }
            }
            Array.Resize(ref res, k);
            return res;
        }
        public decimal nomerodin(int n)
        {
            int[] l = array;
            decimal summ = 0;
            decimal sred = 0;
            for (int i = 0; i < l.Length; i++)
            {
                summ += array[i];
                int len = l.Length;
                sred = summ / len;
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
            Console.WriteLine("Введите количество элементов в одномерной массиве");
            int n = int.Parse(Console.ReadLine());
            odnommassive array = new odnommassive(user, n);
            decimal s = array.nomerodin(n);
            Console.WriteLine($"Среднее кол-во элементов в массиве: {s}");
            int[] n2 = new int[n];
            n2 = array.nomerdva();

            Console.WriteLine("Без повторов:");
            int[] n3 = array.nomertri();
            for (int i = 0; i < n3.Length; i++)
            {
                Console.WriteLine(n3[i]);

            }

            Console.WriteLine("Массив без чисел больше 100:");
            for (int z = 0; z < n; z++)
            {
                if (n2[z] != 0)
                {
                    Console.WriteLine(n2[z]);
                }
            }
        }
    }
}
