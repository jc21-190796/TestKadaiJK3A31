using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class DirectedE
    {
        public static int[] SEARCH(int[] first, int[] next, int dep)
        {
            int temp = 0;
            int n = first.Length;
            int m = next.Length;
            int[] start = { 1, 2, 3, 4, 2, 5, 4, 6 };
            int[] end = { 2, 3, 4, 1, 5, 4, 6, 2 };
            int[] current = new int[first.Length];
            int[] searchd = new int[next.Length];
            int[] path = new int[next.Length];

            for (int i = 0; i < first.Length; i++)
            {
                current[i] = first[i];
            }

            int top = 1;
            int last = m;
            int x = 1;

            while (last >= 1)
            {
                Console.WriteLine("current:" + current[x - 1]);
                if (current[x - 1] != 0)
                {
                    temp = current[x - 1];
                    searchd[top - 1] = temp;
                    current[x - 1] = next[temp - 1];
                    x = end[temp - 1];
                    top++;
                }
                else
                {
                    top--;
                    Console.WriteLine("top:" + top);
                    temp = searchd[top - 1];
                    path[last - 1] = temp;
                    Console.WriteLine("path:" + path[last - 1]);
                    x = start[temp - 1];
                    last--;
                }
            }

            return path;
        }
    }
}
