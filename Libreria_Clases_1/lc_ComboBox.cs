using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace Libreria_Clases_1
{
    public class lc_ComboBox : ComboBox
    {

        public lc_ComboBox()
        {
            InitializeComponent();
        }

        private String _controlID;
        public String controlID
        {
            get { return _controlID; }
            set { _controlID = value; }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // lc_ComboBox
            // 
            this.SelectedValueChanged += new System.EventHandler(this.lc_ComboBox_SelectedValueChanged);
            this.ResumeLayout(false);

        }

        private void lc_ComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Form frm = FindForm();

            foreach(Control ctrl in frm.Controls)
            {
                if (ctrl.Name == controlID) ctrl.Text = SelectedValue.ToString();
            }
        }
    }




}
