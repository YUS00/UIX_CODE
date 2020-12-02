using System;
using System.Windows.Forms;

namespace LibreriaControles
{
    public class UIXCombobox : ComboBox
    {
        public UIXCombobox()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // UIXCombobox
            // 
            this.SelectedValueChanged += new System.EventHandler(this.UIXCombobox_SelectedValueChanged);
            this.ResumeLayout(false);

        }

        private String _ControlId;
        public String ControlId
        {
            get { return _ControlId; }
            set { _ControlId = value; }
        }

        private string _CampMostrar;
        public string CampMostrar
        {
            get { return _CampMostrar; }
            set
            {
                _CampMostrar = value;
            }
        }



        private string _CampID;
        public string CampID
        {
            get { return _CampID; }
            set
            {
                _CampID = value;
            }
        }

        private String _CampoBBDD;
        public String CampoBBDD
        {
            get { return _CampoBBDD; }
            set { _CampoBBDD = value; }
        }

        private String _TaulaForanea;
        public String TaulaForanea
        {
            get { return _TaulaForanea; }
            set { _TaulaForanea = value; }
        }



        private void UIXCombobox_SelectedValueChanged(object sender, EventArgs e)
        {
            Form frm = FindForm();

            foreach (Control ctr in frm.Controls)
            {
                if (ctr.Name == ControlId)
                {
                    ctr.Text = SelectedValue.ToString();
                }
            }
        }
    }
}
