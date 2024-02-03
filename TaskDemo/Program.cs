using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace TaskDemo
{
    internal class Program
    {
        public static async Task<string> WashCloth()
        {
            Console.WriteLine(DateTime.Now + " Wash Cloth Start....");
            await Task.Delay(3000);
            Console.WriteLine(DateTime.Now + " Wash Cloth End.");
            return "Wet Cloths";
        }
        public static async Task DryCloth(string washCloth)
        {
            Console.WriteLine(DateTime.Now + " Dry Cloth Start....");
            await Task.Delay(3000);
            Console.WriteLine(DateTime.Now + " Dry Cloth End.");
        }
        public static async Task HouseClean()
        {
            Console.WriteLine(DateTime.Now + " House Clean Start....");
             await Task.Delay(3000);
            Console.WriteLine(DateTime.Now +" House Clean End.");
        }
        public static async Task Cooking()
        {
            Console.WriteLine(DateTime.Now + " Cooking Start....");
            await Task.Delay(3000);
            Console.WriteLine(DateTime.Now + " Cooking End.");
        }
        static void Main(string[] args)
        {

            async void RunAll()
            {
                Console.WriteLine(DateTime.Now + " --Task Start--");
                Task t1 = WashDryCloth();
                Task t2 = HouseClean();
                Task t3 = Cooking();

                await Task.WhenAll(t1, t2, t3);
                Console.WriteLine(DateTime.Now + " --Task End--");
            }
            RunAll();
            Console.ReadKey();
        }

        private static async Task WashDryCloth()
        {
            string cloths = await WashCloth();
            await DryCloth(cloths);
            
        }
    }
}
