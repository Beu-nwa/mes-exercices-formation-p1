using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extensionsdeclass
{
    static class Extension
    {
        public static int Additionner(int a, int b)
        {
            return a + b;
        }
        public static double Additionner2(this double a, double b)
        {
            return a + b;
        }
        public static void Shuffle<T>(this List<T> list)
        {
            for(int i = 0; i< list.Count; i++)
            {
                int index = new Random().Next(list.Count);
                T tmp = list[i];
                list[i] = list[index];
                list[index] = tmp;
            }
        }
    }
}
