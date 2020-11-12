using System;
using System.Windows.Forms;
using System.Drawing;

namespace LibreriaClases
{
    public class SWComboBox : ComboBox
    {
        public SWComboBox()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SWComboFK
            // 
            this.SelectedValueChanged += new System.EventHandler(this.SWComboFK_SelectedValueChanged);
            this.ResumeLayout(false);

        }

        private String _controlID;
        public String controlID
        {
            get { return _controlID; }
            set { _controlID = value; }
        }

        private string _CampMostrar;

        public string CampMostrar
        {
            get { return _CampMostrar; }
            set
            {
                _CampMostrar = value;
                DisplayMember = value;
            }
        }


        private string _CampID;

        public string CampID
        {
            get { return _CampID; }
            set
            {
                _CampID = value;
                ValueMember = value;
            }
        }






        private void SWComboFK_SelectedValueChanged(object sender, EventArgs e)
        {
            Form frm = FindForm();

            foreach (Control ctrl in frm.Controls)
            {
                if (ctrl.Name == controlID) ctrl.Text = SelectedValue.ToString();
            }
        }
    }
}
