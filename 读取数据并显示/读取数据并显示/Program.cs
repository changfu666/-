using System;
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

namespace 读取数据并显示
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.Run(new Form1());
        }
    }
    public class Form1:Form
     {
          private Button button1 ;
          private DataSet myDataSet ;
          private DataGrid DataGrid1 ;
          public Form1()
          {
              InitializeComponent();
              GetConnect();
          }
         
          private void GetConnect ( )
          {
              string strCon = " Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source = G:\\1北科大博士\\论文\\编程\\我的编程\\Cr AtoLines200-980.xls;Extended Properties=Excel 8.0";
           OleDbConnection myConn = new OleDbConnection(strCon);
           myConn.Open();
           string strCom = " select * from [Sheet1$] ";
           OleDbDataAdapter myCommand = new OleDbDataAdapter(strCom, myConn);
           myDataSet = new DataSet();
           myCommand.Fill(myDataSet, "[Sheet1$]"); 
           myConn.Close ( ) ;
          }
         private void InitializeComponent ( )
          {
           DataGrid1 = new DataGrid ( ) ;
           button1 = new Button ( ) ;
           SuspendLayout();
           DataGrid1.Name = "DataGrid1";
           DataGrid1.Size = new System.Drawing.Size ( 400 , 200 ) ;

           button1.Location = new System.Drawing.Point ( 124 , 240 ) ;
           button1.Name = "button1" ;
           button1.TabIndex = 1 ;
           button1.Text = "读取数据" ;
           button1.Size = new System.Drawing.Size (84 , 24 ) ;
           button1.Click += new System.EventHandler ( this.button1_Click ) ;

           this.AutoScaleBaseSize = new System.Drawing.Size ( 6 , 14 ) ;
           this.ClientSize = new System.Drawing.Size ( 400 , 280 ) ;
           this.Controls.Add ( button1 ) ;
           this.Controls.Add ( DataGrid1 ) ;
           this.Name = "Form1" ;
           this.Text = "读取Excle表格中的数据，并用DataGrid显示出来！" ;
           this.ResumeLayout ( false ) ;

          }
           private void button1_Click ( object sender , System.EventArgs e )
          {
          DataGrid1.DataMember= "[Sheet1$]" ;
          DataGrid1.DataSource = myDataSet ;
          }
    }
  
}
