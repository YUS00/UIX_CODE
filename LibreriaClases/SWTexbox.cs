using System;
using System.Drawing;
using System.Text.RegularExpressions;
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
            this.Validating += new System.ComponentModel.CancelEventHandler(this.SWTextbox_Validating);
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

        public enum tb_parametros { Texto, Fecha, Codigo, Numero, Alfanumérico, Perzonalizado };

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

        private void SWTextbox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            int num;
            DateTime fecha = DateTime.Now;
            String fecha_cadena = fecha.ToString(@"dd/MM/yyyy");

            String tb_Texto = this.Text;


            if (Campo_obligatorio && this.Text == "")
            {
                MessageBox.Show("Debe rellenar este campo");
            }

            else
            {
                if (!(this.Text == ""))
                {

                    switch (_tb_txtpermitido)
                    {
                        case tb_parametros.Texto:
                            if (!System.Text.RegularExpressions.Regex.IsMatch(this.Text, "^[a-zA-Z ]"))
                            {
                                MessageBox.Show("Debe utilizar valores alfabéticos.");
                                this.Clear();
                            }
                            break;
                        case tb_parametros.Numero:
                            if (!int.TryParse(tb_Texto, out num))
                            {
                                MessageBox.Show("Debe utilizar valores numéricos");
                                this.Clear();
                            }
                            break;
                        case tb_parametros.Fecha:
                            if (!DateTime.TryParse(tb_Texto, out fecha))
                            {
                                MessageBox.Show("Debe introducir una fecha");
                                this.Clear();
                            }
                            break;
                        case tb_parametros.Codigo:
                            if (!Formato_codigo())
                            {
                                MessageBox.Show("Debe introducir un código válido");
                                this.Clear();
                            }
                            break;
                        case tb_parametros.Alfanumérico:
                            if (!Formato_alfanumerico())
                            {
                                MessageBox.Show("Debe introducir un código válido");
                                this.Clear();
                            }
                            break;
                        default:
                            break;
                    }
                }
            }

            bool Formato_codigo()
            {
                bool codigo_correcto;
                // Definir parámetros del regex
                Regex rx = new Regex(@"^[0-9a-zA-Z]{4}\-\d{3}\/\d*[13579]{1}\w*[aeyiuo]{1}$",
                  RegexOptions.Compiled | RegexOptions.IgnoreCase);

                if (rx.IsMatch(this.Text))
                {
                    codigo_correcto = true;
                }
                else
                {
                    codigo_correcto = false;
                }

                return codigo_correcto;
            }

            bool Formato_alfanumerico()
            {
                bool codigo_correcto;
                // Definir parámetros del regex
                Regex rx = new Regex("^[a-zA-Z0-9]*$",
                  RegexOptions.Compiled | RegexOptions.IgnoreCase);

                if (rx.IsMatch(this.Text))
                {
                    codigo_correcto = true;
                }
                else
                {
                    codigo_correcto = false;
                }

                return codigo_correcto;
            }
        }
    }



}

