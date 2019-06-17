using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharp_3
{
    public class Matrix
    {
        private int width;
        private int heith;

        public Matrix()
        {
            width = 3;
            heith = 3;

        }

        public int[,] mas = new int[100, 100];

        public Matrix(int width, int heith)
        {
            this.width = width;
            this.heith = heith;

        }

        public void Vvod() //Метод ввода матрицы
        {
            Random rand = new Random();
            for (int i = 0; i < width; i++)
                for (int j = 0; j < heith; j++)
                {
                    mas[i, j] = rand.Next(1, 1000);
                }
        }

        public void Vivod() //Метод вывода матрицы
        {

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < heith; j++)
                {
                    //mas[i, j] = rand.Next(1, 1000);
                    Console.Write(mas[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
        }

        public void Transp() //Метод транспонирования матрицы
        {
            for (int j = 0; j < heith; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    Console.Write(mas[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }

        }

        public void Opr() //Метод нахождения определителя матрицы
        {

        }

        public int DLINA
        {       //установка свойства
            set { if (width != value) width = value; }
            get { return width; }
        }
        public int VISOTA
        {       //установка свойства
            set { if (heith != value) heith = value; }
            get { return heith; }
        }

        /*public static Matrix operator --(Matrix a)
        {

        }*/

    }

    class Program
    {
        static void Main()
        {

            Matrix a = new Matrix();
            Console.WriteLine("Начальные значения ");
            a.Vvod();
            a.Vivod();
            Console.WriteLine("-------------------------");

            Console.Write("Введите размерность:");
            int n = int.Parse(Console.ReadLine());
            int m = n;

            Matrix b = new Matrix();
            b.DLINA = n;
            b.VISOTA = m;
            b.Vvod();
            b.Vivod();
            Console.WriteLine("-------------------------");
            Console.WriteLine("Транспонированная матрица ");
            b.Transp();

            Console.ReadLine();
        }
    }
}
