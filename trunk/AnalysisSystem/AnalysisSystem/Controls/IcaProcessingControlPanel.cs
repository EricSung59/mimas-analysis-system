using System.Windows.Forms;
using AnalysisSystem.Forms;
using AnalysisSystem.Matlab;

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
            get
            {
                return _analysisSystemForm;
            }
            set
            {
                _analysisSystemForm = value;
                choosingControlPanel.AnalysisSystemForm = value;
            }
        }
    }
}
