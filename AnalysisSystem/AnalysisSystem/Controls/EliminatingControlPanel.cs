using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AnalysisSystem.Forms;

namespace AnalysisSystem.Controls
{
    public partial class EliminatingControlPanel : UserControl
    {
        AnalysisSystemForm _analysisSystemForm;
        public AnalysisSystemForm AnalysisSystemForm
        {
            get { return _analysisSystemForm; }
            set { _analysisSystemForm = value; }
        }

        public EliminatingControlPanel()
        {
            InitializeComponent();
        }

        public EliminatingControlPanel(AnalysisSystemForm form)
            : this()
        {
            _analysisSystemForm = form;
        }
    }
}
