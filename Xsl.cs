using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mExcel = Microsoft.Office.Interop.Excel;


namespace USDMApp
{
    class Xls
    {
        private bool isNewXlsFile = false;
        private mExcel.Application xls;     // Excel自体 
        private mExcel.Workbook book = null;       // ブック 
        private mExcel.Worksheet sheet = null;     // シート
        private Require require;
       



        public Xls()
        {


            this.xls = new Microsoft.Office.Interop.Excel.Application();
            this.xls.Visible = false;

        }

        public void Openbook(string _path)
        {
            try
            {
                this.book = (mExcel.Workbook)(xls.Workbooks.Open(
                    _path,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing));
            }
            catch (Exception e)
            {
                if (null != this.xls)
                {
                    // 警告無視設定
                    this.xls.DisplayAlerts = false;

                    // アプリケーションの終了
                    this.xls.Quit();

                    // アプリケーションのオブジェクトの解放
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(this.book);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(this.xls);
                }

            }
            finally
            {
               
            }

        
         }


        public string read_require()
        {
            sheet = (mExcel.Worksheet)this.book.Sheets[1];
            return sheet.Range["C2"].Text;
        }



        public Boolean Check_Path(string _path)
        {
            if(_path == null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
