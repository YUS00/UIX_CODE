using System;
using System.Reflection;
using System.Windows.Forms;

namespace LibreriaClases
{
    public class LlencaAplicacions : Button
    {
        public LlencaAplicacions()
        {
            InitializeComponent();
        }


        private String _Classe;

        public String Classe
        {
            get { return _Classe; }
            set { _Classe = value; }
        }

        private String _form;

        public String Form
        {
            get { return _form; }
            set { _form = value; }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // LlencaAplicacions
            // 
            this.Click += new System.EventHandler(this.LlencaAplicacions_Click);
            this.ResumeLayout(false);

        }

        private void LlencaAplicacions_Click(object sender, EventArgs e)
        {
            //Carreguem la dll. No fem constar cap path per que la
            // compilem a la carpeta on compilem tots els ensamblats
            Assembly ensamblat = Assembly.LoadFrom(Classe);
            //Declarem les variables
            Object dllBD;
            Type tipus;
            //recuperem el tipus de la classe que volem instanciar
            tipus = ensamblat.GetType(Form);
            //instanciem l’objecte
            dllBD = Activator.CreateInstance(tipus);
            //el mostrem assumint que es tracta d’un form
            // i per això fem un cast amb (Form)
            ((Form)dllBD).Show();
        }
    }
}
