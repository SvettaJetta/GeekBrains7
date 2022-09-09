using System;

namespace GeekBrains07
{
    class Program
    {
        static void task47(int m, int n)
        {
            double[,] multy_array = new double[m,n];
            double value;
            int rows = multy_array.GetLength(0);
            int columns = multy_array.GetLength(1);

            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    Random rnd = new Random();
                    value = Math.Round(rnd.NextDouble() + new Random().Next(-10,10),2);
                    multy_array.SetValue(value,i,j);

                    Console.Write($"{multy_array[i, j]} \t");              

                }
                Console.Write('\n');   
            }


        }
        static string task50(int m, int n)
        {
            string str = "something wrong";
            try
            {
                int[,] multy_array = new int[5,6];
                int value;
                int rows = multy_array.GetLength(0);
                int columns = multy_array.GetLength(1);
                for(int i = 0; i < rows; i++)
                {
                    for(int j = 0; j < columns; j++)
                    {
                        Random rnd = new Random();
                        value = rnd.Next(-10, 10);
                        multy_array.SetValue(value,i,j);
                        Console.Write($"{multy_array[i, j]} \t");
                    }
                    Console.Write('\n');
                }                
                str = $"value with [{m},{n}] position is: {multy_array[m, n]}";                

            }
            catch
            {
                Console.WriteLine($"no value with [{m},{n}] position");

                str = $"no value with [{m},{n}] position";
               
            }
            return str;
        }

        static double[] task52()
        {
            int[,] multy_array = new int[5,6];
            int value;
            int rows = multy_array.GetLength(0);
            int columns = multy_array.GetLength(1);
            double[] result = new double[columns];
            int buff;
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    Random rnd = new Random();
                    value = rnd.Next(0, 10);
                    multy_array.SetValue(value,i,j);
                    Console.Write($"{multy_array[i, j]} \t");
                }
                Console.Write('\n');
                
            }
            for(int i = 0; i < columns; i++)
            {
                buff = 0;
                for(int j = 0; j < rows; j++)
                {
                   buff += multy_array[j,i];
                }
                result.SetValue((Convert.ToDouble(buff)/Convert.ToDouble(rows)),i);
            }

            Console.WriteLine($"");

            foreach(double x in result)
            {
                Console.Write($"{x} \t");

            }
            
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("task47");
            Console.WriteLine("Specify a two-dimensional array of size m×n");
            Console.Write("Enter value of m: ");
            int m = int.Parse((Console.ReadLine()));
            Console.Write("Enter value of n: ");
            int n = int.Parse((Console.ReadLine()));
            task47(m,n);
            Console.WriteLine("______________________________________");

            Console.WriteLine("task50");
            Console.WriteLine("Element positions in a two-dimensional array");
            Console.Write("Enter a position: ");
            string[] position = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);            
            Console.WriteLine("task50 result: "+ task50(int.Parse(position[0]),int.Parse(position[1])),'\n' );           
            Console.WriteLine("______________________________________");

            Console.WriteLine("task52");
            Console.WriteLine("Element positions in a two-dimensional array");
            task52();
        }
    }
}
