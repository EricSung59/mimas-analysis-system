using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop;

namespace AnalysisSystem.Test
{
    public partial class ExcelTest : Form
    {
        public ExcelTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Microsoft.Office.Interop.Excel.Application xl = new Microsoft.Office.Interop.Excel.Application();
            //Microsoft.Office.Interop.Excel.Workbook xlWorkBook = (Microsoft.Office.Interop.Excel.Workbook)xl.Workbooks.Open("D:\\Test\\VOIP_X.xls", 0, true, 5, "", "", true, Microsoft.Office.Interop.Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            //Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets[1];
            //Microsoft.Office.Interop.Excel.Range r = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Range["A30", "A30"];
           
            //MessageBox.Show(r.Value.ToString());
        }
    }
}
