using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AnalysisSystem.Controls;
using System.IO;

namespace AnalysisSystem.Forms
{
    public partial class AnalysisSystemForm : Form
    {
        UserControl _currentVisibleControlPanel;

        public AnalysisSystemForm()
        {
            InitializeComponent();

            convertingControlPanel.AnalysisSystemForm = this;
            eliminatingControlPanel.AnalysisSystemForm = this;
            functionControlPanel.AnalysisSystemForm = this;

            _currentVisibleControlPanel = convertingControlPanel;
            convertingControlPanel.Visible = false;
            eliminatingControlPanel.Visible = true;
        }

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
        public Label StatusLabel
        {
            get { return statusLabel; }
            set { statusLabel = value; }
        }
        public UserControl CurrentVisibleControlPanel
        {
            get { return _currentVisibleControlPanel; }
            set { _currentVisibleControlPanel = value; }
        }
    }
}
