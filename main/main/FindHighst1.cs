using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FindHighst
{
    class FindHighst1
    {
        
        public static double[] WaveLengt=new double[]{};
        public static double[] cf = new double[] { };
        public  static double[] Strength = new double[] { };
        public static double[,] data = new double[,] { };
        public static double A1, A2, A3;
        public int row = data.Rank;//获取维数，这里指行数
        public int col = data.GetLength(1);//获取指定维度中的元素个数，这里也就是列数了。（0是第一维，1表示的是第二维）

        public void findhighst(double[,] data)
      {
          for (int j = 0; j < col; j++)
          {
              cf[j] = data[j, 1];
          }
          for (int i = 1; i < col-1; i++)
          {
              int q = 0;
              A1 = cf[i - 1];
              A2 = cf[i];
              A3 = cf[i + 1];
              double err1 = A2 - A1;
              double err2 = A3 - A2;
              if (err1 >= 0 && err2 <= 0)
              {
                 
                  WaveLengt[q] = data[i , 0];
                  Strength[q] = data[i, 1];
                  q++;
              }
             
          }
      }
        public void wl()
        {
            foreach (double s in WaveLengt)
            {
                Console.WriteLine("{0}", s);
            }
        }
    }
}
