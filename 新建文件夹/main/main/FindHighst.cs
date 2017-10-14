using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FindHighst
{
    class FindHighst
    {
        public int i;
        static double[] WaveLengt=new double[]{};
        static double[] cf = new double[] { };
        static double[] Strength = new double[] { };
        static double[,] data = new double[,] { };
        static double x, y, z;
        int row = data.Rank;//获取维数，这里指行数
        int col = data.GetLength(1);//获取指定维度中的元素个数，这里也就是列数了。（0是第一维，1表示的是第二维）
     
        public void findhighst()
      {
          for (int i = 0; i < col; i++)
          {
              cf[i] = data[i, 1];
          }


      }
        

    }
}
