﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;




namespace main
{
    class main
    {
        static void Main(string[] args)
        {
            string strCon = " Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source = G:\\1北科大博士\\论文\\编程\\我的编程\\lamda.xls;Extended Properties=Excel 8.0";
            OleDbConnection myConn = new OleDbConnection(strCon);
            myConn.Open();
            string strCom = " select * from [Sheet1$] ";
            OleDbDataAdapter myCommand = new OleDbDataAdapter(strCom, myConn);
            DataSet myDataSet = new DataSet();
            myCommand.Fill(myDataSet, "Sheet1");
            int row = myDataSet.Tables[0].Rows.Count;
            int col = myDataSet.Tables[0].Columns.Count;
            double[,] arr = new double[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr[i, j] = (double)(myDataSet.Tables[0].Rows[i][j]);
                }
            }

            foreach (double s in arr)
            {
                Console.WriteLine("{0}", s);
            }

        }
    }
}
