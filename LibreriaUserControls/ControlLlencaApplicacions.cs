﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreriaUserControls
{
    public partial class ControlLlencaApplicacions : UserControl
    {
        public ControlLlencaApplicacions()
        {
            InitializeComponent();
        }


        public String LabelText
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }



        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        private String _Classe;

        public String ClasseObrir
        {
            get { return _Classe; }
            set { _Classe = value; }
        }

        private String _form;

        public String FormObrir
        {
            get { return _form; }
            set { _form = value; }
        }

        private void insertFormInPanel(Object form, String panelName = "pnlBackground")
        {
            Form frm = FindForm();
            Form formScreen = (Form)form;
            formScreen.TopLevel = false;
            formScreen.Dock = DockStyle.Fill;
            formScreen.TopMost = true;

            foreach (Control ctr in frm.Controls)
            {
                if (ctr.Name == panelName)
                {
                    Panel panel = (Panel)ctr;
                    panel.Controls.Clear();
                    panel.Refresh();
                    panel.Controls.Add(formScreen);
                    panel.Tag = formScreen;
                    panel.Refresh();

                    formScreen.Show();
                    formScreen.BringToFront();
                    return;

                }
            }
        }

        private void ControlLlencaApplicacions_Click(object sender, EventArgs e)
        {
            //Carreguem la dll. No fem constar cap path per que la
            // compilem a la carpeta on compilem tots els ensamblats
            Assembly ensamblat = Assembly.LoadFrom(ClasseObrir);
            //Declarem les variables
            Object dllBD;
            Type tipus;
            //recuperem el tipus de la classe que volem instanciar
            tipus = ensamblat.GetType(FormObrir);
            //instanciem l’objecte
            dllBD = Activator.CreateInstance(tipus);
            //el mostrem assumint que es tracta d’un form
            // i per això fem un cast amb (Form)
            insertFormInPanel(dllBD);
            //((Form)dllBD).Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Carreguem la dll. No fem constar cap path per que la
            // compilem a la carpeta on compilem tots els ensamblats
            Assembly ensamblat = Assembly.LoadFrom(ClasseObrir);
            //Declarem les variables
            Object dllBD;
            Type tipus;
            //recuperem el tipus de la classe que volem instanciar
            tipus = ensamblat.GetType(FormObrir);
            //instanciem l’objecte
            dllBD = Activator.CreateInstance(tipus);

            //el mostrem assumint que es tracta d’un form
            // i per això fem un cast amb (Form)
            insertFormInPanel(dllBD);

        }

        private void ControlLlencaApplicacions_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void ControlLlencaApplicacions_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }
    }
}
