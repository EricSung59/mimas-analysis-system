using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnalysisSystem.Test
{
    public partial class Test : Form
    {
        AnalysisSystemDataContext _db = new AnalysisSystemDataContext();

        public Test()
        {
            InitializeComponent();
        }

        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            label1.Text = "In validating of ComboBox 1";
            if (comboBox1.Text != "")
                e.Cancel = true;
        }


    }
}