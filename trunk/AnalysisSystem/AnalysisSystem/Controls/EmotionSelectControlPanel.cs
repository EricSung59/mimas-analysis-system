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
    public partial class EmotionSelectControlPanel : UserControl
    {
        private EmoMappingControlPanel _emoMappingControlPanel;

        private int _row;
        private int _column;
        private int _emotion;

        private static int _rowsCount;
        private static int _columnsCount;
        private static int _minArousal = 1;
        private static int _maxArousal = 9;
        private static int _minValence = 1;
        private static int _maxValence = 9;

        private int _arousalStartValue_Start;
        private int _arousalStartValue_End;
        private int _arousalEndValue_Start;
        private int _arousalEndValue_End;
        private int _valenceStartValue_Start;
        private int _valenceStartValue_End;
        private int _valenceEndValue_Start;
        private int _valenceEndValue_End;

        //private static bool _isContinuousValue = true;

        //------------------------ CONSTRUCTOR ----------------------//

        public EmotionSelectControlPanel(EmoMappingControlPanel emoMappingControlPanel, int emotion, int row, int column)
        {
            InitializeComponent();

            _emoMappingControlPanel = emoMappingControlPanel;
            Emotion = emotion;
            _row = row;
            _column = column;

            _valenceStartValue_Start = _column + 1;
            _valenceStartValue_End = _maxValence - (_columnsCount - _column) + 1;
            _valenceEndValue_Start = _valenceStartValue_Start;
            _valenceEndValue_End = _valenceStartValue_End;

            _arousalStartValue_Start = _rowsCount - _row;
            _arousalStartValue_End = _maxArousal - _row;
            _arousalEndValue_Start = _arousalStartValue_Start;
            _arousalEndValue_End = _arousalStartValue_End;

            updateArousalValue();
            updateValenceValue();
        }   

        //------------------------ EVENT HANDLERS -------------------//

        private void valenceStartComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox senderComboBox = sender as ComboBox;
            _valenceStartValue_Start = (int)senderComboBox.SelectedItem;
            this.UpdateValue();

            List<EmotionSelectControlPanel> list = _emoMappingControlPanel.GetEmotionSelectControlPanelsByRow(_row);
            for (int i = 0; i < list.Count - 1; i++)
            {
                EmotionSelectControlPanel currentPanel = list[i] as EmotionSelectControlPanel;
                EmotionSelectControlPanel nextPanel = list[i + 1] as EmotionSelectControlPanel;

                // Neu end1 + 1 < start2 -> chinh end1 len
                if ((int)currentPanel.ValenceEndComboBox.SelectedItem + 1 < (int)nextPanel.ValenceStartComboBox.SelectedItem)
                {
                    currentPanel.ValenceEndComboBox.SelectedItem = (int)nextPanel.ValenceStartComboBox.SelectedItem - 1;
                }

                // Neu end1 + 1 > start2 -> chinh ValenceStartValue_Start cua start2
                else if ((int)currentPanel.ValenceEndComboBox.SelectedItem + 1 > (int)nextPanel.ValenceStartComboBox.SelectedItem)
                {
                    nextPanel.ValenceStartValue_Start = (int)currentPanel.ValenceEndComboBox.SelectedItem + 1;
                }

                nextPanel.UpdateValue();
            }
        }

        private void valenceEndComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            List<EmotionSelectControlPanel> list = _emoMappingControlPanel.GetEmotionSelectControlPanelsByRow(_row);

            for (int i = 0; i < list.Count - 1; i++)
            {
                EmotionSelectControlPanel currentPanel = list[i] as EmotionSelectControlPanel;
                EmotionSelectControlPanel nextPanel = list[i + 1] as EmotionSelectControlPanel;



                if (nextPanel.ValenceStartValue_Start != (int)currentPanel.ValenceEndComboBox.SelectedItem + 1)
                {
                    nextPanel.ValenceStartValue_Start = (int)currentPanel.ValenceEndComboBox.SelectedItem + 1;
                    nextPanel.ValenceEndValue_Start = nextPanel.ValenceStartValue_Start;
                    nextPanel.UpdateValue();
                }
            }
        }

        private void arousalStartComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox senderComboBox = sender as ComboBox;
            _arousalStartValue_Start = (int)senderComboBox.SelectedItem;
            this.UpdateValue();

            List<EmotionSelectControlPanel> list = _emoMappingControlPanel.GetEmotionSelectControlPanelsByColumn(_column);
            for (int i = 0; i < list.Count - 1; i++)
            {
                EmotionSelectControlPanel currentPanel = list[i] as EmotionSelectControlPanel;
                EmotionSelectControlPanel nextPanel = list[i + 1] as EmotionSelectControlPanel;

                // Neu end1 + 1 < start2 -> chinh end1 len
                if ((int)currentPanel.ArousalEndComboBox.SelectedItem + 1 < (int)nextPanel.ArousalStartComboBox.SelectedItem)
                {
                    currentPanel.ArousalEndComboBox.SelectedItem = (int)nextPanel.ArousalStartComboBox.SelectedItem - 1;
                }

                // Neu end1 + 1 > start2 -> chinh ArousalStartValue_Start cua start2
                else if ((int)currentPanel.ArousalEndComboBox.SelectedItem + 1 > (int)nextPanel.ArousalStartComboBox.SelectedItem)
                {
                    nextPanel.ArousalStartValue_Start = (int)currentPanel.ArousalEndComboBox.SelectedItem + 1;
                }

                nextPanel.UpdateValue();
            }
        }

        private void arousalEndComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            List<EmotionSelectControlPanel> list = _emoMappingControlPanel.GetEmotionSelectControlPanelsByColumn(_column);

            for (int i = 0; i < list.Count - 1; i++)
            {
                EmotionSelectControlPanel currentPanel = list[i] as EmotionSelectControlPanel;
                EmotionSelectControlPanel nextPanel = list[i + 1] as EmotionSelectControlPanel;



                if (nextPanel.ArousalStartValue_Start != (int)currentPanel.ArousalEndComboBox.SelectedItem + 1)
                {
                    nextPanel.ArousalStartValue_Start = (int)currentPanel.ArousalEndComboBox.SelectedItem + 1;
                    nextPanel.ArousalEndValue_Start = nextPanel.ArousalStartValue_Start;
                    nextPanel.UpdateValue();
                }
            }
        }

        //------------------------ PUBLIC METHODS -------------------//

        public void UpdateValue(int valenceStartValue_Start, int valenceStartValue_End,
                                int valenceEndValue_Start, int valenceEndValue_End,
                                int arousalStartValue_Start, int arousalStartValue_End,
                                int arousalEndValue_Start, int arousalEndValue_End)
        {
            _valenceStartValue_Start = valenceStartValue_Start > 0 ? valenceStartValue_Start : _valenceStartValue_Start;
            _valenceStartValue_End = valenceStartValue_End > 0 ? valenceStartValue_End : _valenceStartValue_End;
            _valenceEndValue_Start = valenceEndValue_Start > 0 ? valenceEndValue_Start : _valenceEndValue_Start;
            _valenceEndValue_End = valenceEndValue_End > 0 ? valenceEndValue_End : _valenceEndValue_End;
            _arousalStartValue_Start = arousalStartValue_Start > 0 ? arousalStartValue_Start : _arousalStartValue_Start;
            _arousalStartValue_End = arousalStartValue_End > 0 ? arousalStartValue_End : _arousalStartValue_End;
            _arousalEndValue_Start = arousalEndValue_Start > 0 ? arousalEndValue_Start : _arousalEndValue_Start;
            _arousalEndValue_End = arousalEndValue_End > 0 ? arousalEndValue_End : _arousalEndValue_End;
           
            updateArousalValue();
            updateValenceValue();
        }

        public void UpdateValue()
        {
            updateArousalValue();
            updateValenceValue();
        }

        //------------------------ PRIVATE HELPERS ------------------//

        /// <summary>
        /// Abscissa axis
        /// </summary>
        private void updateValenceValue()
        {
            int currentValenceEndValue = -1;
            
            if (_valenceEndValue_Start < _valenceStartValue_Start)
            {
                _valenceEndValue_Start = _valenceStartValue_Start;
            }

            if (valenceEndComboBox.SelectedItem != null && (int)valenceEndComboBox.SelectedItem > _valenceStartValue_Start)
            {
                currentValenceEndValue = (int)valenceEndComboBox.SelectedItem;
            }

            valenceStartComboBox.Items.Clear();
            valenceEndComboBox.Items.Clear();

            if (_column == 0)
            {
                valenceStartComboBox.Enabled = false;
                valenceStartComboBox.Items.Add(_minValence);
            }
            else
            {
                for (int i = _valenceStartValue_Start; i <= _valenceStartValue_End; i++)
                {
                    valenceStartComboBox.Items.Add(i);
                }
            }

            if (_column == (_columnsCount - 1))
            {
                valenceEndComboBox.Enabled = false;
                valenceEndComboBox.Items.Add(_maxValence);
            }
            else
            {
                for (int i = _valenceEndValue_Start; i <= _valenceEndValue_End; i++)
                {
                    valenceEndComboBox.Items.Add(i);
                }
            }

            valenceStartComboBox.SelectedIndex = 0;
            valenceEndComboBox.SelectedIndex = 0;

            if (currentValenceEndValue != -1)
                valenceEndComboBox.SelectedItem = currentValenceEndValue;
        }

        /// <summary>
        /// Ordinate axis
        /// </summary>
        private void updateArousalValue()
        {
            int currentArousalEndValue = -1;

            if (_arousalEndValue_Start < _arousalStartValue_Start)
            {
                _arousalEndValue_Start = _arousalStartValue_Start;
            }

            if (arousalEndComboBox.SelectedItem != null && (int)arousalEndComboBox.SelectedItem > _arousalStartValue_Start)
            {
                currentArousalEndValue = (int)arousalEndComboBox.SelectedItem;
            }

            arousalStartComboBox.Items.Clear();
            arousalEndComboBox.Items.Clear();

            if (_row == 0)
            {
                arousalEndComboBox.Enabled = false;
                arousalEndComboBox.Items.Add(_maxArousal);
            }
            else
            {
                for (int i = _arousalEndValue_Start; i <= _arousalEndValue_End; i++)
                {
                    arousalEndComboBox.Items.Add(i);
                }
            }

            if (_row == (_rowsCount - 1))
            {
                arousalStartComboBox.Enabled = false;
                arousalStartComboBox.Items.Add(_minArousal);
            }
            else
            {
                for (int i = _arousalStartValue_Start; i <= _arousalStartValue_End; i++)
                {
                    arousalStartComboBox.Items.Add(i);
                }
            }

            arousalStartComboBox.SelectedIndex = 0;
            arousalEndComboBox.SelectedIndex = 0;

            if (currentArousalEndValue != -1)
                arousalEndComboBox.SelectedItem = currentArousalEndValue;
        }

        //------------------------ PROPERTIES -----------------------//

        public ComboBox ArousalStartComboBox
        {
            get { return arousalStartComboBox; }
        }

        public ComboBox ArousalEndComboBox
        {
            get { return arousalEndComboBox; }
        }

        public ComboBox ValenceStartComboBox
        {
            get { return valenceStartComboBox; }
        }

        public ComboBox ValenceEndComboBox
        {
            get { return valenceEndComboBox; }
        }

        public TextBox EmotionTextBox
        {
            get { return emotionTextBox; }
        }

        public int Row
        {
            set { _row = value; }
        }

        public int Column
        {
            set { _column = value; }
        }

        public int Emotion
        {
            set
            {
                _emotion = value;
                emotionTextBox.Text = value.ToString();
            }
            get { return _emotion; }
        }

        public static int RowsCount
        {
            set { _rowsCount = value; }
        }

        public static int ColumnsCount
        {
            set { _columnsCount = value; }
        }

        public static int MinArousal
        {
            get { return _minArousal; }
            set { _minArousal = value; }
        }

        public static int MaxArousal
        {
            get { return _maxArousal; }
            set { _maxArousal = value; }
        }

        public static int MinValence
        {
            get { return _minValence; }
            set { _minValence = value; }
        }

        public static int MaxValence
        {
            get { return _maxValence; }
            set { _maxValence = value; }
        }

        public int ArousalStartValue_Start
        {
            get { return _arousalStartValue_Start; }
            set { _arousalStartValue_Start = value; }
        }

        public int ArousalStartValue_End
        {
            get { return _arousalStartValue_End; }
            set { _arousalStartValue_End = value; }
        }

        public int ArousalEndValue_Start
        {
            get { return _arousalEndValue_Start; }
            set { _arousalEndValue_Start = value; }
        }

        public int ArousalEndValue_End
        {
            get { return _arousalEndValue_End; }
            set { _arousalEndValue_End = value; }
        }

        public int ValenceStartValue_Start
        {
            get { return _valenceStartValue_Start; }
            set { _valenceStartValue_Start = value; }
        }

        public int ValenceStartValue_End
        {
            get { return _valenceStartValue_End; }
            set { _valenceStartValue_End = value; }
        }

        public int ValenceEndValue_Start
        {
            get { return _valenceEndValue_Start; }
            set { _valenceEndValue_Start = value; }
        }

        public int ValenceEndValue_End
        {
            get { return _valenceEndValue_End; }
            set { _valenceEndValue_End = value; }
        }
    }
}

/***
 * Backup
 * 
 *          _valenceStartValue_Start = _column + 1;
            _valenceStartValue_End = _maxValence - (_columnsCount - _column) + 1;
            _valenceEndValue_Start = _valenceStartValue_Start;
            _valenceEndValue_End = _valenceStartValue_End;

            _arousalStartValue_Start = _rowsCount - _row;
            _arousalStartValue_End = _maxArousal - _row;
            _arousalEndValue_Start = _arousalStartValue_Start;
            _arousalEndValue_End = _arousalStartValue_End;
 * 
 */

//EmotionSelectControlPanel[,] emotionSelectControlPanelArray = _emoMappingControlPanel.EmotionSelectControlPanelArray;

//// Change valence end value of previous panel
//if (_isContinuousValue && _column > 0)
//{
//    EmotionSelectControlPanel previousPanel = emotionSelectControlPanelArray[_row, _column - 1];
//    previousPanel.ValenceEndComboBox.SelectedItem = (int)senderComboBox.SelectedItem - 1;
//}

//// Remove items of this panel
//this.UpdateValue((int)senderComboBox.SelectedItem, 0, 0, 0, 0, 0, 0, 0);