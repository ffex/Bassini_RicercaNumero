using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bassini_RicercaNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            RiempiArray(arr);
            Console.Write("Inserisci numero: ");
            int n =Convert.ToInt32(Console.ReadLine());

            bool result = RicercaNumeroAsync(arr,n).Result;
            Console.WriteLine(result);
            Console.ReadLine();
        }

        private static void RiempiArray(int[] arr)
        {
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i]=r.Next(0, 100);
                Console.WriteLine(arr[i]);
            }
        }

        private static async Task<bool>  RicercaNumeroAsync(int[] arr,int v)
        {
            bool trovato = false;

            await Task.Run(() =>
            {
                
                for (int i = 0; i < 100; i++)
                {
                    if (arr[i] == v)
                    {
                        trovato = true;
                    }
                }

            });

            return trovato;
        }
    }
}
