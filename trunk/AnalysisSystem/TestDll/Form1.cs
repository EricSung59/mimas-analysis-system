using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TestDll
{
    public partial class Form1 : Form
    {
        [DllImport("SvmLib.dll", EntryPoint = "add")]
        private static extern Int32 Unmanaged_add(Int32 a, Int32 b);

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(aTextBox.Text);
            int b = Convert.ToInt32(bTextBox.Text);
            int result = Unmanaged_add(a, b);

            resultTextBox.Text = result.ToString();
        }
    }
}
