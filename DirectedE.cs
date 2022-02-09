using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class DirectedE
    {
        public static int SEARCH(int[] first,int[] next,int dep)
        {
            int temp = 0;
            int n = first.Length;
            int m = next.Length;
            int[] start = new int[first.Length];
            int[] end = new int[first.Length];
            int[] current = new int[first.Length];
            int[] searchd = new int[next.Length];
            int[] path = new int[next.Length];

            for (int i = 0; i < first.Length; i++){
                current[i] = first[i];
            }

            int top = 1;
            int last = m;
            int x = 1;

            while (last >= 1)
            {
                if (current[x] != 0)
                {
                    temp = current[x];
                    searchd[top] = temp;
                    current[x] = next[temp];
                    x = end[temp];
                    top++;
                }
                else
                {
                    top--;
                    temp = searchd[top];
                    path[last] = temp;
                    x = start[temp];
                    last--;
                }
            }

            return path[path.Length-1];
        }
    }
}
