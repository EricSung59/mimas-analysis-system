using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnalysisSystem.Forms
{
    public partial class EmotionExceptChoosingForm : Form
    {
        private List<Int32> _emotionExceptList = new List<Int32>();
        private int _startLabel;
        private int _endLabel;

        //------------------------- CONSTRUCTOR -----------------------//

        public EmotionExceptChoosingForm()
        {
            InitializeComponent();

            AcceptButton = okButton;
            CancelButton = cancelButton;
        }

        public EmotionExceptChoosingForm(int startLabel, int endLabel)
            : this()
        {
            _startLabel = startLabel;
            _endLabel = endLabel;
        }

        //------------------------- EVENT HANDLERS---------------------//

        private void okButton_Click(object sender, EventArgs e)
        {
            String[] labelsString = emotionLabelExceptionTextBox.Text.Split(',');
            _emotionExceptList.Clear();

            try
            {
                foreach (String label in labelsString)
                {
                    int labelValue = Convert.ToInt32(label);
                    if (!(_startLabel <= labelValue && labelValue <= _endLabel))
                        throw new ArgumentException();

                    _emotionExceptList.Add(labelValue);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Phải nhập vào các số nguyên dương nằm trong khoảng " + _startLabel + " đến " + _endLabel, "Nhập sai");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        //------------------------ PROPERTIES -------------------------//

        public List<Int32> EmotionLabelExceptList
        {
            get { return _emotionExceptList; }
        }
    }
}
