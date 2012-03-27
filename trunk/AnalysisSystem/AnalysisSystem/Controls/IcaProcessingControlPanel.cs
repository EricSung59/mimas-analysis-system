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
    public partial class IcaProcessingControlPanel : UserControl
    {
        AnalysisSystemForm _analysisSystemForm;

        //------------------------ CONSTRUCTOR -------------------------//

        public IcaProcessingControlPanel()
        {
            InitializeComponent();
        }

        //------------------------ PROPERTIES --------------------------//

        public AnalysisSystemForm AnalysisSystemForm
        {
            get { return _analysisSystemForm; }
            set { _analysisSystemForm = value; }
        }
    }
}
