using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AnalysisSystem.Controls;

namespace AnalysisSystem.Forms
{
    public partial class AnalysisSystemForm : Form
    {
        public FunctionControlPanel FunctionControlPanel
        {
            get { return functionControlPanel; }
            set { functionControlPanel = value; }
        }
        public ConvertingControlPanel ConvertingControlPanel
        {
            get { return convertingControlPanel; }
            set { convertingControlPanel = value; }
        }
        public EliminatingControlPanel EliminatingControlPanel
        {
            get { return eliminatingControlPanel; }
            set { eliminatingControlPanel = value; }
        }

        UserControl _currentVisibleControlPanel;
        public UserControl CurrentVisibleControlPanel
        {
            get { return _currentVisibleControlPanel; }
            set { _currentVisibleControlPanel = value; }
        }

        public AnalysisSystemForm()
        {
            InitializeComponent();

            functionControlPanel.AnalysisSystemForm = this;
            _currentVisibleControlPanel = convertingControlPanel;
            convertingControlPanel.Visible = true;
            eliminatingControlPanel.Visible = false;
        }
    }
}
