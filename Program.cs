using System;
using System.Xml.Linq;
namespace arr1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[2];
            Console.WriteLine("Enter array size");
            int N = Convert.ToInt32(Console.ReadLine());
            Array.Resize(ref arr, N);
            for (int i = 0; i != arr.Length; i++)
            {
                arr[i] = 0;
                Console.Write(arr[i].ToString() + " ");
            }
            Console.WriteLine("\nEnter the numbers of new elements ");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select insert position");
            int K = Convert.ToInt32(Console.ReadLine());
            Array.Resize(ref arr, N + M);
            for (int i = K; i < K + M; i++)
            {
                arr[i] = 1;
            }
            Console.WriteLine("Result:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i].ToString() + " ");
            }
        }
    }
}
