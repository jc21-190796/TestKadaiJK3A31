using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class JetCoaster
    {

        public static int ride(int k,int[] g, int r)//k=最大乗客数,g=グループごとの人数,r=乗る回数
        {
            int maxRide = k;
            int gPeek;
            int count=1;
            int result=0;

            for (int j=0; j<g.Length; j++)
            {
                gPeek = g[j];
                Console.WriteLine(count+":"+gPeek + ":" + result);
                maxRide -= gPeek;

                if (maxRide >= 0) 
                {
                    result += gPeek;
                    if (j == g.Length - 1)
                    {
                        j = -1;
                    }
                    continue;
                }
                else
                {
                    maxRide = k;
                    j--;
                    count++;
                    if (count > r)
                        break;
                }    
            }
            Console.WriteLine("result:" + result);
            return result;
        }
    }
}
/*
 1.先頭のグループを乗せる
 2.残りの座席数を確認する
 3.座席が余ってたら次のグループも乗せる
 4.座席が余ってなかったら出発する
 5.乗り終わったグループは列の最後尾に並ぶ
 6.n回繰り返す
*/