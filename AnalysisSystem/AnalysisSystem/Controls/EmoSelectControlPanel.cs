using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnalysisSystem.Controls
{
    public partial class EmoSelectControlPanel : UserControl
    {
        private EmoMappingControlPanel emoMappingControlPanel;
        public EmoSelectControlPanel(EmoMappingControlPanel emoMappingControlPanel, int id)
        {
            InitializeComponent();
            this.emoMappingControlPanel = emoMappingControlPanel;
            EmoTextbox.Text = id.ToString();

        }


        private void MinACombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int MinA = Convert.ToInt32(MinACombobox.Text);
            if (MinA > 0 && MinA <= 9)
            {
                for (int i = MinA + 1; i <= 9; i++)
                {
                    MaxACombobox.Items.Add(i);
                }
            }
            else
            {
                MessageBox.Show("Right number from 1 to 9", "Error");
            }

        }

        private void MinVCombobox_SelectedValueChanged(object sender, EventArgs e)
        {
            int MinV = Convert.ToInt32(MinVCombobox.Text);
            for (int i = MinV + 1; i <= 9; i++)
            {
                MaxVCombobox.Items.Add(i);
            }
        }


        private void ComboBox_Validating(object sender, CancelEventArgs e)
        {
            ComboBox _currentComboBox = (ComboBox)sender;
            try
            {
                Convert.ToInt32(_currentComboBox.Text);
            }
            catch (System.Exception ex)
            {
                if (_currentComboBox.Text == null)
                {
                    MessageBox.Show("Not Null", "Error");
                    _currentComboBox.Focus();
                }
                else
                {
                    MessageBox.Show("Not right format", "Error");
                    _currentComboBox.Focus();

                }
                return;
            }
        }
    }
}
