using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreriaClases
{
    public class SWCombonew : ComboBox
    {

        private String _ControlId;

        public String ControlId
        {
            get { return _ControlId; }
            set { _ControlId = value; }
        }


        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SWCombonew
            // 
            this.SelectedValueChanged += new System.EventHandler(this.SWCombonew_SelectedValueChanged);
            this.ResumeLayout(false);

        }

        private void SWCombonew_SelectedValueChanged(object sender, EventArgs e)
        {
            Form frm = FindForm();

            foreach (Control ctr in frm.Controls)
            {
                if(ctr.Name == ControlId)
                {
                    ctr.Text = SelectedValue.ToString();
                }
            }
        }
    }
}
