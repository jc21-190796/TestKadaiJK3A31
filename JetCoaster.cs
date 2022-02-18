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
            int maxRide = k;//最大乗客数
            int gPeek;//グループの人数
            int num = 0;//列の何グループ目か
            int result = 0;//乗車人数の総数
            int[] gSet = new int[g.Length];
            int[] escape = new int[g.Length];//最後尾に並ばせる
            int num2 = 0;//escapeの添字

            for(int i=0; i<g.Length; i++)
            {
                gSet[i] = g[i];
            }

            if (g.Length == 0)
            {
                return result;
            }
            else
            {
                for (int count = 1; r != 0 && count <= r;)//回数が0出ないとき&既定の回数に達するまで回す
                {

                    //Console.WriteLine("count:" + count);
                    gPeek = gSet[num];
                    Console.WriteLine(count + ":" + gPeek + ":" + result);
                    maxRide -= gPeek;//残席数を計算する

                    if (maxRide >= 0) //乗れるならまだ乗せる
                    {
                        result += gPeek;//総数に今のグループ人数を加算
                        if (num == gSet.Length - 1)//列の最後の人の時列が元に戻る
                        {
                            num = 0;
                            count++;
                            //Console.WriteLine("count:" + count);
                            continue;
                        }
                        escape[num] = gSet[num];
                        Console.WriteLine("escape[" + num + "]:" + escape[num]);
                        num++;
                    }
                    else
                    {
                        maxRide = k;//席数を初期化

                        for (int h = 0; h < gSet.Length; h++)
                        {
                            if (num < gSet.Length)
                            {
                                gSet[h] = gSet[num];
                                num++;
                                Console.WriteLine("g[" + h + "]:" + g[h]);

                            }
                            else
                            {
                                gSet[h] = escape[num2];
                                Console.WriteLine("g[" + h + "]:" + g[h]);
                                num2++;
                            }
                        }
                        count++;
                        //Console.WriteLine("count:" + count);
                        num = 0;
                        num2 = 0;
                    }
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