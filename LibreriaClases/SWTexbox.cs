using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibreriaClases
{

    public class SWTextbox : TextBox
    {
        public SWTextbox()
        {
            InitializeComponent();
            string Texto_SWTextbox = this.Text;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SWTextbox
            // 
            this.Enter += new System.EventHandler(this.Class1_Enter);
            this.Leave += new System.EventHandler(this.Class1_Leave);
            this.ResumeLayout(false);
        }

        private void Class1_Leave(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void Class1_Enter(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        public enum tb_parametros { Texto, Fecha, Codigo, Numero };

        private tb_parametros _tb_txtpermitido;

        public tb_parametros tb_txtpermitido
        {
            get { return _tb_txtpermitido; }
            set { _tb_txtpermitido = value; }
        }


        private String _CampoBBDD;
        public String CampoBBDD
        {
            get { return _CampoBBDD; }
            set { _CampoBBDD = value; }
        }


        private bool _Campo_obligatorio;
        public bool Campo_obligatorio
        {
            get { return _Campo_obligatorio; }
            set { _Campo_obligatorio = value; }
        }

        private bool _ForeignKey;
        public bool ForeignKey
        {
            get { return _ForeignKey; }
            set { _ForeignKey = value; }
        }

    }

    

}

