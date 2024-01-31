using System;


    class trehmassive
    {
        public int[][] array;
        public int n;

        public trehmassive(bool user, int N)
        {
            n = N;
            if (user == true)
            {
                sozdanieuser();
            }
            else
            {
                sozdaniernd();
            }
        }


        public void sozdanieuser()
        {
            array = new int[n][];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Напишите количество элементов в {i+1} строке");
                int c = int.Parse(Console.ReadLine());
                int[] tmp = new int[c];
                for(int j = 0; j<c; j++)
                {
                    Console.WriteLine($"Введите элемент {j+1} в {i+1} строке");
                    tmp[j] = int.Parse(Console.ReadLine());
                }
                array[i]= tmp;
            }
        }
        public void sozdaniernd()
        {
            Random rnd = new Random();
            array = new int[n][];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Напишите количество элементов в {i+1} строке");
                int c = int.Parse(Console.ReadLine());
                int[] tmp = new int[c];
                for(int j = 0; j < c; j++)
                {
                    tmp[j] = rnd.Next(0, 100);
                }
                array[i] = tmp;
            }
        }

        public decimal nomerodin()
        {
            int[][] l = array;
            decimal summ = 0;
            int all_sz = 0;
            for (int i = 0; i < n; i++)
            {
                all_sz += array[i].Length;
                
                for(int j = 0; j < l[i].Length; j++)
                {
                    summ += array[i][j];
                }
            }

            return summ/all_sz;
        }
        
        public void change()
        {
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < array[i].Length; j++) {
                    if (array[i][j] % 2 == 0) {
                        array[i][j] = (i + 1) * (j + 1);
                    }
                }
            }
        }
        
        public void print()
        {
            Console.WriteLine("Вывод массива");
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < array[i].Length; j++) {
                    Console.Write($"{array[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите true если хотите ввод с клавиатуры, если хотите с помощью рандома, напишите false");
            bool user = bool.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество строк в ступенчатом массиве");
            int n = int.Parse(Console.ReadLine());
            trehmassive array = new trehmassive(user, n);
            
            Console.WriteLine($"Среднее в массиве: {array.nomerodin()}");
            
            array.change();
            array.print();
            
            
        }
    }
