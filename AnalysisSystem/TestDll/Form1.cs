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
        public Form1()
        {
            InitializeComponent();

            svm_model model = SvmLib.LoadModel(@"D:\105.model");
            svm_node[] node = new svm_node[3];
            node[0] = new svm_node(1, 0.690476);
            node[1] = new svm_node(2, 0.0122829);
            node[2] = new svm_node(-1, 0);

            double predictValue = SvmLib.Predict(model, node);
            return;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //int a = Convert.ToInt32(aTextBox.Text);
            //int b = Convert.ToInt32(bTextBox.Text);
            
            //resultTextBox.Text = SvmLib.A(a, b).ToString();
        }
    }
}
