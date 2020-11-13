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
            // SWComboBox
            // 
            this.SelectedValueChanged += new System.EventHandler(this.SWComboBox_SelectedValueChanged);
            this.ResumeLayout(false);

        }

        private String _ControlId;
        public String ControlId
        {
            get { return _ControlId; }
            set { _ControlId = value; }
        }



        public string CampMostrar
        {
            get { return DisplayMember; }
            set
            {
                DisplayMember = value;
            }
        }




        public string CampID
        {
            get { return ValueMember; }
            set
            {
                ValueMember = value;
            }
        }

        private void SWComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Form frm = FindForm();

            foreach (Control ctr in frm.Controls)
            {
                if (ctr.Name == )
                {

                }
            }
        }
    }
}
